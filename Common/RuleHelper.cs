/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/28
 * Time: 22:41
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace vTCPServer.Common
{
	/// <summary>
	/// Description of RuleHelper.
	/// </summary>
	public class RuleHelper
	{
		private static List<RuleMsg> Rules = new List<RuleMsg>();
		private static List<RuleInfo> Infos = new List<RuleInfo>();
		
		private static bool modifying;
		private static int[] delays = new int[10];
		RuleHelper()
		{			
		}
		
		~RuleHelper()
		{
			//Rules.Clear(); cause crash of UI
		}
		
		public static List<RuleMsg> GetRules()
		{
			return Rules;
		}
		
				
		public static void SetRules(List<RuleMsg> list)
		{
			modifying = true;
			Rules = list;
			if(Rules == null)
			{
				modifying = false;
				return;
			}
			
			Infos.Clear();			
			foreach(RuleMsg item in Rules)
			{
				RuleInfo info = new RuleInfo();
				info.isMatched =false;
				if(item.isHex)
				{
					info.rBytes = HexString.HexString2Bytes(item.rString);
					info.mBytes = HexString.HexString2Bytes(item.mString);
				}
				else
				{
					info.rBytes = HexString.AsciiString2Bytes(item.rString);
					info.mBytes = HexString.AsciiString2Bytes(item.mString);
				}
				Infos.Add(info);
			}
			modifying = false;
		}
		
		/// <summary>
		/// Import rules from xml file
		/// </summary>
		/// <param name="filename">file name</param>
		public static void ImportRulesFromXml(string filename)
		{
			modifying = true;
			Rules.Clear();
			Infos.Clear();
			
			XmlDocument xmlDoc=new XmlDocument(); 
			xmlDoc.Load(filename); 
			XmlNode root = xmlDoc.SelectSingleNode("Rules");
			XmlNodeList nlist = root.ChildNodes;
			
			RuleMsg item = new RuleMsg();
			RuleInfo info = new RuleInfo();
			
			foreach(XmlNode xn in nlist)
			{
				XmlElement xe = (XmlElement)xn;
				try{
					item.iDelay = int.Parse(xe.GetAttribute("Delayms"));
					item.isAddCRC16 = (xe.GetAttribute("AddCRC16") == "True")? true:false;
					item.isEnable = (xe.GetAttribute("Enable") == "True")? true:false;
					item.isHex = (xe.GetAttribute("Hex") == "True")? true:false;
					item.isMatchOnce = (xe.GetAttribute("MatchOnce") == "True")? true:false;
					item.isMatchPart = (xe.GetAttribute("MatchPart") == "True")? true:false;
					item.isContinueNext = (xe.GetAttribute("ContinueNext") == "True")? true:false;
					
					item.name = xe.GetAttribute("Name");
					item.rString = xe.GetAttribute("RecvData");					
					item.mString = xe.InnerText;
					if(item.isHex)
					{
						info.rBytes = HexString.HexString2Bytes(item.rString);
						info.mBytes = HexString.HexString2Bytes(item.mString);
					}
					else
					{
						info.rBytes = HexString.AsciiString2Bytes(item.rString);
						info.mBytes = HexString.AsciiString2Bytes(item.mString);
					}
					info.isMatched =false;
				}
				catch{
					continue;
				}
				Rules.Add(item);
				Infos.Add(info);
			}
			modifying = false;
		}
		
		/// <summary>
		/// Export the rules to xml file
		/// </summary>
		/// <param name="filename">file name to be saved to</param>
		public static void ExportRulesToXml(string filename)
		{
			XmlTextWriter xmlWriter;
			xmlWriter = new XmlTextWriter(filename, Encoding.Default);
			xmlWriter.Formatting = Formatting.Indented;
			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("Rules");
			
			foreach(RuleMsg rm in Rules)
			{
				xmlWriter.WriteStartElement("Rule");
				xmlWriter.WriteAttributeString("Name", rm.name);
				
				if(rm.isEnable)
					xmlWriter.WriteAttributeString("Enable", "True");
				else
					xmlWriter.WriteAttributeString("Enable", "False");
				
				if(rm.isHex)
					xmlWriter.WriteAttributeString("Hex", "True");
				else
					xmlWriter.WriteAttributeString("Hex", "False");
				
				if(rm.isMatchPart)
					xmlWriter.WriteAttributeString("MatchPart", "True");
				else
					xmlWriter.WriteAttributeString("MatchPart", "False");
				
				if(rm.isMatchOnce)
					xmlWriter.WriteAttributeString("MatchOnce", "True");
				else
					xmlWriter.WriteAttributeString("MatchOnce", "False");
				
				if(rm.isAddCRC16)
					xmlWriter.WriteAttributeString("AddCRC16", "True");
				else
					xmlWriter.WriteAttributeString("AddCRC16", "False");
				
				if(rm.isContinueNext)
					xmlWriter.WriteAttributeString("ContinueNext", "True");
				else
					xmlWriter.WriteAttributeString("ContinueNext", "False");
				
				xmlWriter.WriteAttributeString("Delayms", rm.iDelay.ToString());
				xmlWriter.WriteAttributeString("RecvData",rm.rString);
				xmlWriter.WriteString(rm.mString);
				xmlWriter.WriteEndElement();
			}
			
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}
		
		/// <summary>
		/// get the rule msg matched to the received data
		/// </summary>
		/// <param name="rdata">received data</param>
		/// <param name="mdata">matched data</param>
		/// <param name="MatchedInfo">additonal info of matched data</param>
		/// <returns>true for matched</returns>
		public static bool GetMatchedMesage(byte[] rdata, out byte[][] mdata, out MatchedInfo minfo)
		{
			if(modifying)
			{
				minfo.NofMsg = 0;
				minfo.Delays = null;
				mdata = null;
				return false;
			}

			int NofMsg = 0; //Number of matched msg
			mdata = new byte[10][];			
			
			int index = -1;
			RuleInfo info;
			foreach(RuleMsg rule in Rules)
			{
				index++;
				info = Infos[index];
				//if not enable, check the next
				if(!rule.isEnable)
					continue;
				//if only matched one time, check the next
				if(rule.isMatchOnce && info.isMatched)
					continue;
				
				//get the matched item
				//Check the message length
				byte[] rbyte = info.rBytes;
				if(rdata.Length < rbyte.Length)
					continue;
				
				if(!rule.isMatchPart)
				{
					if(rbyte.Length != rdata.Length)
						continue;					
				}

				int i =0;
				while(i< rbyte.Length)
				{
					if(rdata[i] != rbyte[i])
						break;
					i++;
				}
				if(i < rbyte.Length)
					continue;
												
				//get the matched msg					
				if(rule.isAddCRC16)
				{
					mdata[NofMsg] = CRC.AddCRC(info.mBytes);
				}
				else
				{
					mdata[NofMsg] = info.mBytes;
				}
				info.isMatched = true;
				Infos[index] = info;
				delays[NofMsg] = rule.iDelay;
				NofMsg++;
				
				//continue to match the next one or not
				if(rule.isContinueNext)
					continue;
				else
					break;
			}
			
			//return the matched info
			if(NofMsg == 0)
			{
				minfo.NofMsg = 0;
				minfo.Delays = null;
				mdata = null;
				return false;
			}
			else
			{
				minfo.NofMsg = NofMsg;
				minfo.Delays = delays;
				return true;
			}
		}
	}
	
	/// <summary>
	/// Rule Message
	/// </summary>
	public struct RuleMsg
	{
		public string name;
		public bool isEnable;
		public bool isHex;
		public bool isMatchOnce;
		public bool isMatchPart;
		public bool isContinueNext;
		public bool isAddCRC16;
		
		public string rString;
		public string mString;
		
		public int iDelay;
	}
	
	/// <summary>
	/// Add info of Rule
	/// </summary>
	public struct RuleInfo
	{
		private bool Matched;
		public bool isMatched{
			set{
				Matched = value;
			}
			get{
				return Matched;
			}
		}
		
		public byte[] rBytes;
		public byte[] mBytes;
	}
	
	/// <summary>
	/// Additional info of matched message
	/// </summary>
	public struct MatchedInfo
	{
		/// <summary>
		/// number of matched message
		/// </summary>
		public int NofMsg;
		
		/// <summary>
		/// element 0: the delay ms of message 1
		/// element 1: the delay ms of message 2
		/// element 2: the delay ms of message 3
		/// ......
		/// element n-1: the delay ms of message n
		/// </summary>
		public int[] Delays;
		
	}
}
