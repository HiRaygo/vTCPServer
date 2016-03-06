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
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using vTCPServer.Common;
using PcapDotNet.Core;
using PcapDotNet.Packets;

namespace vTCPServer.Forms
{
	/// <summary>
	/// Description of CaptureForm.
	/// </summary>
	public partial class CaptureForm : Form
	{
		bool isShowHex;
		bool isLogData;
		bool isIPSelect;
		bool isPortSelect;
		int iii = 0;
		string filterstr;
		
		bool isCapturing;
		
		delegate void LogDataHandler(string str);
		LogDataHandler ld;
		
        IList<LivePacketDevice> allDevices;
        PacketDevice selectedDevice;
        Thread capthread;
        
		public CaptureForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			isShowHex = true;
			isLogData = true;
			isIPSelect = false;
			isPortSelect = false;
			isCapturing = false;
			ld = new LogDataHandler(LogData);
			
			// Retrieve the device list from the local machine
			allDevices = LivePacketDevice.AllLocalMachine;
						
		}
		
		/// <summary>
		/// update the device list
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void CaptureFormLoad(object sender, EventArgs e)
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
		/// show the log in the textbox
		/// </summary>
		/// <param name="str"></param>
		/// <param name="type"></param>
		void LogData(string str)
		{
			if(!isLogData)
				return;
			
			if(textBoxLogdata.InvokeRequired)
			{				
				this.Invoke(ld, new object[]{str});
			}
			else
			{
				textBoxLogdata.AppendText(str + "\n");
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
		
		
		void ButtonStartCaptureClick(object sender, EventArgs e)
		{
			if(isCapturing)
			{
				capthread.Abort();
				Thread.Sleep(2000);
	            if(!capthread.IsAlive)
	            {
	            	buttonStartCapture.Text = "Capture";
	            	isCapturing = false;
	            }
			}
			else
			{
				int deviceIndex = comboBoxDevices.SelectedIndex;
				// Take the selected adapter
	            selectedDevice = allDevices[deviceIndex];
	            //if
	            filterstr = "tcp";
	            if(isIPSelect)
	            	filterstr = filterstr + " and host " + textBoxIP.Text;
	            if(isPortSelect)
	            	filterstr = filterstr + " and port " + textBoxPort.Text;
	            
	            capthread = new Thread(new ThreadStart(StartCapture));
	            capthread.IsBackground = true;
	            capthread.Start();
	            Thread.Sleep(2000);
	            if(isCapturing)
	            	buttonStartCapture.Text = "Stop";
			}
		}
		
		public void  StartCapture()
		{
			// Open the device
            using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                //Console.WriteLine("Listening on " + selectedDevice.Description + "...");
				using (BerkeleyPacketFilter filter = communicator.CreateFilter(filterstr))
                {
                    // Set the filter
                    communicator.SetFilter(filter);
                }
				
				isCapturing = true;
				
                // Retrieve the packets
                Packet packet;
                do
                {
                    PacketCommunicatorReceiveResult result = communicator.ReceivePacket(out packet);
                    switch (result)
                    {
                        case PacketCommunicatorReceiveResult.Timeout:
                            // Timeout elapsed
                            continue;
                        case PacketCommunicatorReceiveResult.Ok:
                            LogData(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff"));
                            string log = string.Format("{0}:{1} ---> {2}:{3}  [{4}]",
							                packet.Ethernet.IpV4.Source, packet.Ethernet.IpV4.Tcp.SourcePort,
							                packet.Ethernet.IpV4.Destination, packet.Ethernet.IpV4.Tcp.DestinationPort,
							                packet.Ethernet.IpV4.Tcp.Payload.ToString());
                            LogData(log);
//                            if(isLogData && isShowHex)
//                            {
//                            	LogData(HexString.Bytes2HexString(packet.Buffer));
//                            }
//                            else if(isLogData)
//                            {
//                            	LogData(HexString.Bytes2AsciiString(packet.Buffer));
//                            }                            
                            break;
                        default:
                            throw new InvalidOperationException("The result " + result + " shoudl never be reached here");
                    }
                } while (true);
            }
            isCapturing = false;
		}
		
		
		void CheckBoxIPCheckedChanged(object sender, EventArgs e)
		{
			isIPSelect = checkBoxIP.Checked;
		}
		
		void CheckBoxPortCheckedChanged(object sender, EventArgs e)
		{
			isPortSelect =checkBoxPort.Checked;
		}
	}
}
