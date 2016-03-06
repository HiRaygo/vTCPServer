/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:05
 * 
 */
using System;
using System.Drawing;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

using vTCPServer.Common;

namespace vTCPServer.Forms
{
	/// <summary>
	/// Description of CommForm.
	/// </summary>
	public partial class CommForm : Form
	{
		SerialPort port = null;
		bool isShowHex;
		bool isSendHex;
		bool isLogData;
		bool isEnableRule;
		bool isLoopBack;
		bool isAutoSend;
		bool isAutoClear;
		bool ReceiveEventFlag = false;
		int iii = 0;
		
		delegate void LogDataHandler(string str, int type);
		LogDataHandler ld;
		
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
		}
		
		/// <summary>
		/// work when form load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void SocketFormLoad(object sender, EventArgs e)
		{
			comboBoxTCP1.SelectedIndex = 0;
			comboBoxTCP2.SelectedIndex = 0;
			if(!GetLocalIP()){
				MessageBox.Show("Get IP fail.");
				return;}
			comboBoxServerIP.SelectedIndex = 0;
		}
		
		/// <summary>
		/// get the local ips
		/// </summary>
		/// <returns></returns>
		public bool GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName();
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                    	comboBoxServerIP.Items.Add(IpEntry.AddressList[i].ToString());
                    }
                }
                comboBoxServerIP.Items.Add("127.0.0.1");
            }
            catch
            {
                return false;
            }
            return true;
        }
		
		/// <summary>
		/// click the open port button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button1Click(object sender, EventArgs e)
		{

		}
		
	
		/// <summary>
		/// event when port received data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
			int len = port.BytesToRead;
			if(len <= 0)
				return;
			
			byte[] rcvdata = new byte[len];
			int rlen = port.Read(rcvdata, 0, len);
			port.DiscardInBuffer();	
			if(rlen ==0)
				return;
			
			if(isShowHex)
			{
				LogData(HexString.Bytes2HexString(rcvdata), 2);
			}
			else
			{
				LogData(HexString.Bytes2AsciiString(rcvdata), 2);
			}
			
			if(isEnableRule)
			{
				byte[][] rspdata;
				MatchedInfo minfo;
				if(RuleHelper.GetMatchedMesage(rcvdata, out rspdata, out minfo))
				{
					for(int i=0; i<minfo.NofMsg; i++)
					{
						System.Threading.Thread.Sleep(minfo.Delays[i]);
						port.Write(rspdata[i], 0, rspdata[i].Length);
						if(isShowHex)
						{
							LogData(HexString.Bytes2HexString(rspdata[i]), 1);
						}
						else
						{
							LogData(HexString.Bytes2AsciiString(rspdata[i]), 1);
						}
					}
				}
			}
			else
			{
				if(isLoopBack)
				{
					port.Write(rcvdata, 0, rcvdata.Length);
					if(isShowHex)
					{
						LogData(HexString.Bytes2HexString(rcvdata), 1);
					}
					else
					{
						LogData(HexString.Bytes2AsciiString(rcvdata), 1);
					}
				}
			}
		}
		
		/// <summary>
		/// click the send button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Button2Click(object sender, EventArgs e)
		{			
			PortSendData();
		}
		
		/// <summary>
		/// send data
		/// </summary>
		void PortSendData()
		{
					
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
