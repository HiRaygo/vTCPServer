/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:06
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using vTCPServer.Common;
using vTCPServer.Forms;

namespace vTCPServer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		RuleForm rForm;
		CommForm sForm;
		CaptureForm cForm;
		HelpForm hForm;
		int formtype;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//rForm = new RuleForm();
			sForm = new CommForm();
			//vForm = new VSPDForm();
		}
		
		private void SwitchForm(Form form)
		{
			panel1.Controls.Clear();	//移除所有控件
			form.TopLevel = false;	  //设置为非顶级窗体
			form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
			form.Dock = System.Windows.Forms.DockStyle.Fill;				  //设置样式是否填充整个panel
			panel1.Controls.Add(form);	//添加窗体
			form.Show();	
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{			
			SwitchForm(sForm);
			formtype = 0;
			toolStripBtnSocket.Checked = true;
		}
		
		void ToolStripBtnSocketClick(object sender, EventArgs e)
		{
			if(formtype != 0)
			{
				if(sForm == null)
					sForm = new CommForm();
				SwitchForm(sForm);
				formtype = 0;
				toolStripBtnRule.Checked = false;
				toolStripBtnSocket.Checked = true;
				toolStripBtnCapture.Checked = false;
			}
		}
				
		void ToolStripBtnRuleClick(object sender, EventArgs e)
		{
			if(formtype != 1)
			{
				if(rForm ==null)
					rForm = new RuleForm();
				SwitchForm(rForm);
				formtype = 1;
				toolStripBtnRule.Checked = true;
				toolStripBtnSocket.Checked = false;
				toolStripBtnCapture.Checked = false;
			}
		}
		
		
		void ToolStripButtonCaptureClick(object sender, EventArgs e)
		{
			if(formtype != 2)
			{
				if(cForm ==null)
					cForm = new CaptureForm();
				SwitchForm(cForm);
				formtype = 2;
				toolStripBtnRule.Checked = false;
				toolStripBtnSocket.Checked = false;
				toolStripBtnCapture.Checked = true;
			}
		}
				
		void ToolStripBtnTopMostClick(object sender, EventArgs e)
		{
			if(this.TopMost)
			{
				this.TopMost = false;
				toolStripBtnTopMost.Checked = false;
			}
			else
			{
				this.TopMost = true;
				toolStripBtnTopMost.Checked = true;
			}
		}
		
		
		void HelpToolStripButtonClick(object sender, EventArgs e)
		{
			if(formtype != 4)
			{
				if(hForm ==null)
					hForm = new HelpForm();
				SwitchForm(hForm);
				formtype = 4;
				toolStripBtnRule.Checked = false;
				toolStripBtnSocket.Checked = false;
				toolStripBtnCapture.Checked = false;
			}
		}
	}
}
