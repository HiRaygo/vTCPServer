/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:05
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Transport;
using vTCPServer.Common;

namespace vTCPServer.Forms
{
	/// <summary>
	/// Description of CommForm.
	/// </summary>
	public partial class CommForm : Form
	{
		bool isShowHex;
		bool isSendHex;
		bool isLogData;
		bool isEnableRule;
		bool isLoopBack;
		bool isAutoSend;
		bool isAutoClear;
		bool isServering;
		bool running;
		int iii = 0;
		int iTimeout;
		
		string filterstr;
		string sMac;
		string sIp;
		string sPort;		
		IList<LivePacketDevice> allDevices;
        PacketDevice selectedDevice;
        Thread serverthread;
        
		delegate void LogDataHandler(string str, int type);
		LogDataHandler ld;
		private static TCPStatus tcpStatus = TCPStatus.CLOSED;
		
		public CommForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			isShowHex = false;
			isSendHex = false;
			isLogData = true;
			isEnableRule = false;
			isLoopBack = false;
			isAutoSend = false;
			isAutoClear = true;
			ld = new LogDataHandler(LogData);
			
			// Retrieve the device list from the local machine
			allDevices = LivePacketDevice.AllLocalMachine;
		}
		
		/// <summary>
		/// work when form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void SocketFormLoad(object sender, EventArgs e)
		{
			if (allDevices.Count == 0)
            {
                //Console.WriteLine("No interfaces found! Make sure WinPcap is installed.");
                return;
            }

            // Print the list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                //Console.Write((i + 1) + ". " + device.Name);
                if (device.Description != null)
                    //Console.WriteLine(" (" + device.Description + ")");
                	comboBoxDevices.Items.Add(device.Description);
            }
            
            if(comboBoxDevices.Items.Count>0)
            	comboBoxDevices.SelectedIndex =0;
		}
		
	
		/// <summary>
		/// click the open port button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ButtonStartServerClick(object sender, EventArgs e)
		{
			if(isServering)
			{
				running = false;
				//serverthread.Abort();
				Thread.Sleep(1000);
	            buttonStartServer.Text = "Start";
	            isServering = false;
			}
			else
			{
				sMac = textBoxMac.Text;
				sIp = textBoxServerIP.Text;
				sPort = textBoxServerPort.Text;
				if(string.IsNullOrEmpty(sMac) || string.IsNullOrEmpty(sIp) || string.IsNullOrEmpty(sPort))
				{
					MessageBox.Show("IP, Port or Mac is error. Please check.");
					return;
				}
				if(!int.TryParse(textBoxTimeout.Text, out iTimeout))
					iTimeout = 10;
				int deviceIndex = comboBoxDevices.SelectedIndex;
				// Take the selected adapter
		        selectedDevice = allDevices[deviceIndex];
		        filterstr = "tcp and host "+ sIp + " and port " + sPort;
		        
		        serverthread = new Thread(new ThreadStart(StartServer));
		        serverthread.IsBackground = true;
		        serverthread.Start();
		        Thread.Sleep(1000);
		        if(isServering)
		            buttonStartServer.Text = "Stop";
			}
		}
		
		
		/// <summary>
		/// Thread of server
		/// </summary>
		public void  StartServer()
		{
			// Open the device
            using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, iTimeout))
            {
            	EndPointInfo endPointInfo = new EndPointInfo();
                endPointInfo.SourceMac = sMac;
                endPointInfo.SourceIp = sIp;
                endPointInfo.SourcePort = ushort.Parse(sPort);
                //Console.WriteLine("Listening on " + selectedDevice.Description + "...");
				using (BerkeleyPacketFilter filter = communicator.CreateFilter(filterstr))
                {
                    // Set the filter
                    communicator.SetFilter(filter);
                }
				tcpStatus = TCPStatus.LISTENING;
				isServering = true;
				LogData("Server is listening port "+ sPort, 0);
                // Retrieve the packets
                Packet packet;
                running = true;
	            do
	            {
	                PacketCommunicatorReceiveResult result = communicator.ReceivePacket(out packet);	
	                switch (result)
	                {
	                    case PacketCommunicatorReceiveResult.Timeout:
	                        // Timeout elapsed
	                        continue;
	                    case PacketCommunicatorReceiveResult.Ok:
	                        bool isRecvedPacket = (packet.Ethernet.IpV4.Destination.ToString() == endPointInfo.SourceIp) ? true : false;
	                        if (isRecvedPacket)
	                        {
	                        	switch (packet.Ethernet.IpV4.Tcp.ControlBits)
					            {
	                        		case (TcpControlBits.Push | TcpControlBits.Acknowledgment):
	                        			if (tcpStatus == TCPStatus.ESTABLISHED)
					                    {
					                        Packet ack = TCPUtils.BuildTcpResponsePacket(packet, TcpControlBits.Acknowledgment);
					                        communicator.SendPacket(ack);
					                        string rstring = packet.Ethernet.IpV4.Tcp.Payload.ToHexadecimalString();
					                        LogData(rstring, 2);
					                        if(isLoopBack)
					                        {
					                        	byte[] rbytes = Encoding.Default.GetBytes(rstring);
					                        	Packet rsp = TCPUtils.BuildTcpPacket(endPointInfo, TcpControlBits.Push|TcpControlBits.Acknowledgment, null, true, rbytes);
					                        	LogData(rstring, 1);
					                        }
					                    }
	                        			break;
					                case TcpControlBits.Synchronize:
					                    if (tcpStatus == TCPStatus.LISTENING)
					                    {
					                        endPointInfo.DestinationMac = packet.Ethernet.Source.ToString();
					                        endPointInfo.DestinationIp = packet.Ethernet.IpV4.Source.ToString();
					                        endPointInfo.DestinationPort = packet.Ethernet.IpV4.Tcp.SourcePort;
					
					                        Packet synAck = TCPUtils.BuildTcpResponsePacket(packet, TcpControlBits.Synchronize | TcpControlBits.Acknowledgment);
					                        communicator.SendPacket(synAck);
					                        tcpStatus = TCPStatus.SYN_RECEIVED;
					                    }
					                    break;
					                case TcpControlBits.Acknowledgment:
					                    if (tcpStatus == TCPStatus.SYN_RECEIVED)
					                    {
					                        tcpStatus = TCPStatus.ESTABLISHED;
					                        LogData(endPointInfo.DestinationIp + ":" + endPointInfo.DestinationPort + " is connected.", 0);
					                    }
					                    else if (tcpStatus == TCPStatus.LAST_ACK)
					                    {
					                        tcpStatus = TCPStatus.CLOSED;
					                        LogData(endPointInfo.DestinationIp + ":" + endPointInfo.DestinationPort + " is disconnected.", 0);
					                        tcpStatus = TCPStatus.LISTENING;
					                    }
					                    else if (tcpStatus == TCPStatus.FIN_WAIT_1)
					                    {
					                        tcpStatus = TCPStatus.FIN_WAIT_2;
					                    }
					                    break;
					                case (TcpControlBits.Fin | TcpControlBits.Acknowledgment):
					                    if (tcpStatus == TCPStatus.FIN_WAIT_2)
					                    {
					                        Packet ack = TCPUtils.BuildTcpResponsePacket(packet, TcpControlBits.Acknowledgment);
					                        communicator.SendPacket(ack);
					                        tcpStatus = TCPStatus.TIME_WAIT;
					                    }
					                    else if (tcpStatus == TCPStatus.ESTABLISHED)
					                    {
					                        Packet ack = TCPUtils.BuildTcpResponsePacket(packet, TcpControlBits.Acknowledgment);
					                        communicator.SendPacket(ack);
					                        tcpStatus = TCPStatus.CLOSE_WAIT;
					                    }
					                    break;
					                case (TcpControlBits.Reset | TcpControlBits.Acknowledgment):
					                    if (tcpStatus == TCPStatus.ESTABLISHED)
					                    {
					                        tcpStatus = TCPStatus.CLOSED;
					                        LogData(endPointInfo.DestinationIp + ":" + endPointInfo.DestinationPort + " is disconnected.", 0);
					                        tcpStatus = TCPStatus.LISTENING;
					                    }
					                    break;
					                default:
					                    TCPUtils.PacketInfoPrinter(packet);
					                    break;
					            }
	                        }
	                        break;
	                    default:
	                        throw new InvalidOperationException("The result " + result + " should never be reached here");
	                }
	            } while (running);
            }
            isServering = false;
            LogData("Server is stopped.", 0);
		}
	
		
		/// <summary>
		/// show the log in the textbox
		/// </summary>
		/// <param name="str"></param>
		/// <param name="type"></param>
		void LogData(string str, int type)
		{
			if(!isLogData)
				return;
			
			if(textBoxLogdata.InvokeRequired)
			{				
				this.Invoke(ld, new object[]{str, type});
			}
			else
			{
				//Auto clear
				if(isAutoClear)
				{
					iii++;
					if(iii > 50)
					{
						iii = 0;
						if(textBoxLogdata.TextLength > 10000)
							textBoxLogdata.Clear();						
					}
				}
				//Log data
				if(type == 1)
					textBoxLogdata.AppendText("Send: "+ str + "\n");
				else if(type ==2)
					textBoxLogdata.AppendText("Recv: "+ str + "\n");
				else
					textBoxLogdata.AppendText("Info: "+ str + "\n");
			}			
		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			this.textBoxLogdata.Clear();
		}
		
		void CheckBoxShowHexCheckedChanged(object sender, EventArgs e)
		{
			isShowHex = checkBoxShowHex.Checked;			
		}
		
		void CheckBoxShowdataCheckedChanged(object sender, EventArgs e)
		{
			isLogData = checkBoxShowdata.Checked;
		}
		
		void CheckBoxSendHexCheckedChanged(object sender, EventArgs e)
		{
			isSendHex = checkBoxSendHex.Checked;			
		}
		
		void CBAutoSendCheckedChanged(object sender, EventArgs e)
		{
			isAutoSend = cBAutoSend.Checked;			
		}
		
		void CheckBoxEnableRuleCheckedChanged(object sender, EventArgs e)
		{
			isEnableRule = checkBoxEnableRule.Checked;
			if(isEnableRule)
			{
				checkBoxLoopBack.Checked = false;
			}
		}
		
		
		void ButtonLoadRulesClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "XML Document(*.xml)|*.xml";
			ofd.Multiselect = false;
			ofd.ValidateNames = true;
			if(ofd.ShowDialog() == DialogResult.OK)
            {
				try{
					RuleHelper.ImportRulesFromXml(ofd.FileName);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
		}
		
		void CheckBoxLoopBackCheckedChanged(object sender, EventArgs e)
		{
			isLoopBack = checkBoxLoopBack.Checked;
			if(isLoopBack)
			{
				checkBoxEnableRule.Checked = false;
			}
		}
		
		void CheckBoxAutoClearCheckedChanged(object sender, EventArgs e)
		{
			isAutoClear = checkBoxAutoClear.Checked;
		}
	}
}
