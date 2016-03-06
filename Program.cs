/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/23
 * Time: 11:09
 * 
 */
using System;
using System.Windows.Forms;
using vTCPServer.Forms;

namespace vTCPServer
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
