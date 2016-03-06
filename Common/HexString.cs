/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 16:29
 * 
 */
using System;
using System.Text;

namespace vTCPServer.Common
{
	/// <summary>
	/// Description of HexString.
	/// </summary>
	public class HexString
	{
		public HexString()
		{
		}
		
		/// <summary>
		/// Converts a hex string into a byte array.
		/// </summary>
		/// <param name="hexstr">string to be converted</param>
		/// <returns>byte array converted from hexstr</returns>
		public static byte[] HexString2Bytes(string hexstr)
		{
			if (hexstr == null)
            	throw new ArgumentNullException("hex");
			hexstr = hexstr.Replace("\n", "");
			hexstr = hexstr.Replace(" ", "");
        
			if (hexstr.Length % 2 != 0)
			{
			    throw new ArgumentException("Invalid hex string!", "hex");
			}
			
			byte[] bytes = new byte[hexstr.Length / 2];
			
			for (int i = 0; i < bytes.Length; i++)
			{
			    bytes[i] = Convert.ToByte(hexstr.Substring(i * 2, 2), 16);
			}
			return bytes;			
		}
		
		/// <summary>
		/// Converts a ascii string into a byte array.
		/// </summary>
		/// <param name="ascstr">string to be converted</param>
		/// <returns>byte array converted from ascstr</returns>
		public static byte[] AsciiString2Bytes(string ascstr)
		{
			if (ascstr == null)
            	throw new ArgumentNullException("ascii");

			return Encoding.Default.GetBytes(ascstr);
		}
	
		/// <summary>
		/// Converts a byte array to hex string.
		/// </summary>
		/// <param name="bytes">the input byte array</param>
		/// <returns>hex string representation of bytes</returns>
		public static String Bytes2HexString(byte[] bytes)
		{
			StringBuilder sb = new StringBuilder();
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                	sb.Append(bytes[i].ToString("X2"));
                }
            }
            return sb.ToString();
		}
		
		/// <summary>
		/// Converts a byte array to string.
		/// </summary>
		/// <param name="bytes">the input byte array</param>
		/// <returns>ascii string representation of bytes</returns>
		public static String Bytes2AsciiString(byte[] bytes)
		{
			return Encoding.Default.GetString(bytes, 0, bytes.Length);
		}
		
		/// <summary>
        /// 从汉字转换到16进制
        /// </summary>
        /// <param name="s"></param>
        /// <param name="charset">编码,如"utf-8","gb2312"</param>
        /// <param name="fenge">是否每字符用逗号分隔</param>
        /// <returns></returns>
        public static string ToHex(string s, string charset, bool fenge)
        {
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                //throw new ArgumentException("s is not valid chinese string!");
            }
            Encoding chs = Encoding.GetEncoding(charset);
            byte[] bytes = chs.GetBytes(s);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
                if (fenge && (i != bytes.Length - 1))
                {
                    str += string.Format("{0}", ",");
                }
            }
            return str.ToLower();
        }
        
        /// <summary>
        /// 从16进制转换成汉字
        /// </summary>
        /// <param name="hex"></param>
        /// <param name="charset">编码,如"utf-8","gb2312"</param>
        /// <returns></returns>
        public static string UnHex(string hex, string charset)
        {
            if (hex == null)
                throw new ArgumentNullException("hex");
            hex = hex.Replace(",", "");
            hex = hex.Replace("\n", "");
            hex = hex.Replace("\\", "");
            hex = hex.Replace(" ", "");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
            }
            // 需要将 hex 转换成 byte 数组。 
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。 
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    // Rethrow an exception with custom message. 
                    throw new ArgumentException("hex is not a valid hex number!", "hex");
                }
            }
            
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            return chs.GetString(bytes);
        }
	}
}
