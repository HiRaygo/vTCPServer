/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:05
 * 
 */
namespace vTCPServer.Forms
{
	partial class CommForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxTCP1 = new System.Windows.Forms.ComboBox();
			this.textBoxServerPort = new System.Windows.Forms.TextBox();
			this.comboBoxServerIP = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonStartServer = new System.Windows.Forms.Button();
			this.textBoxLogdata = new System.Windows.Forms.TextBox();
			this.textBoxSend = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cBAutoSend = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxInterval = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxAutoClear = new System.Windows.Forms.CheckBox();
			this.checkBoxLoopBack = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableRule = new System.Windows.Forms.CheckBox();
			this.checkBoxShowdata = new System.Windows.Forms.CheckBox();
			this.checkBoxShowHex = new System.Windows.Forms.CheckBox();
			this.checkBoxSendHex = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBoxTCP2 = new System.Windows.Forms.ComboBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.textBoxClientPort = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxClentIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxTCP1);
			this.groupBox1.Controls.Add(this.textBoxServerPort);
			this.groupBox1.Controls.Add(this.comboBoxServerIP);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonStartServer);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(161, 124);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server Config";
			// 
			// comboBoxTCP1
			// 
			this.comboBoxTCP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTCP1.FormattingEnabled = true;
			this.comboBoxTCP1.Items.AddRange(new object[] {
									"TCP",
									"UDP"});
			this.comboBoxTCP1.Location = new System.Drawing.Point(101, 56);
			this.comboBoxTCP1.Name = "comboBoxTCP1";
			this.comboBoxTCP1.Size = new System.Drawing.Size(49, 20);
			this.comboBoxTCP1.TabIndex = 15;
			// 
			// textBoxServerPort
			// 
			this.textBoxServerPort.Location = new System.Drawing.Point(46, 56);
			this.textBoxServerPort.MaxLength = 6;
			this.textBoxServerPort.Name = "textBoxServerPort";
			this.textBoxServerPort.Size = new System.Drawing.Size(45, 21);
			this.textBoxServerPort.TabIndex = 14;
			this.textBoxServerPort.Text = "65432";
			// 
			// comboBoxServerIP
			// 
			this.comboBoxServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxServerIP.FormattingEnabled = true;
			this.comboBoxServerIP.Location = new System.Drawing.Point(46, 23);
			this.comboBoxServerIP.Name = "comboBoxServerIP";
			this.comboBoxServerIP.Size = new System.Drawing.Size(104, 20);
			this.comboBoxServerIP.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 54);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Port:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "IP:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonStartServer
			// 
			this.buttonStartServer.Location = new System.Drawing.Point(11, 88);
			this.buttonStartServer.Name = "buttonStartServer";
			this.buttonStartServer.Size = new System.Drawing.Size(139, 23);
			this.buttonStartServer.TabIndex = 0;
			this.buttonStartServer.Text = "Start";
			this.buttonStartServer.UseVisualStyleBackColor = true;
			this.buttonStartServer.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBoxLogdata
			// 
			this.textBoxLogdata.Location = new System.Drawing.Point(192, 41);
			this.textBoxLogdata.Multiline = true;
			this.textBoxLogdata.Name = "textBoxLogdata";
			this.textBoxLogdata.ReadOnly = true;
			this.textBoxLogdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLogdata.Size = new System.Drawing.Size(396, 238);
			this.textBoxLogdata.TabIndex = 1;
			// 
			// textBoxSend
			// 
			this.textBoxSend.Location = new System.Drawing.Point(192, 312);
			this.textBoxSend.Multiline = true;
			this.textBoxSend.Name = "textBoxSend";
			this.textBoxSend.Size = new System.Drawing.Size(322, 74);
			this.textBoxSend.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(192, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Log Data:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(192, 286);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Data to send:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cBAutoSend
			// 
			this.cBAutoSend.Location = new System.Drawing.Point(351, 285);
			this.cBAutoSend.Name = "cBAutoSend";
			this.cBAutoSend.Size = new System.Drawing.Size(72, 24);
			this.cBAutoSend.TabIndex = 5;
			this.cBAutoSend.Text = "AutoSend";
			this.cBAutoSend.UseVisualStyleBackColor = true;
			this.cBAutoSend.CheckedChanged += new System.EventHandler(this.CBAutoSendCheckedChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(450, 286);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 23);
			this.label9.TabIndex = 6;
			this.label9.Text = "Interval";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxInterval
			// 
			this.textBoxInterval.Location = new System.Drawing.Point(507, 287);
			this.textBoxInterval.Name = "textBoxInterval";
			this.textBoxInterval.Size = new System.Drawing.Size(48, 21);
			this.textBoxInterval.TabIndex = 7;
			this.textBoxInterval.Text = "500";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(561, 286);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(19, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "ms";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxAutoClear);
			this.groupBox2.Controls.Add(this.checkBoxLoopBack);
			this.groupBox2.Controls.Add(this.checkBoxEnableRule);
			this.groupBox2.Location = new System.Drawing.Point(13, 271);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(161, 115);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Rule Config";
			// 
			// checkBoxAutoClear
			// 
			this.checkBoxAutoClear.Checked = true;
			this.checkBoxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAutoClear.Location = new System.Drawing.Point(8, 87);
			this.checkBoxAutoClear.Name = "checkBoxAutoClear";
			this.checkBoxAutoClear.Size = new System.Drawing.Size(135, 24);
			this.checkBoxAutoClear.TabIndex = 4;
			this.checkBoxAutoClear.Text = "AutoClear";
			this.checkBoxAutoClear.UseVisualStyleBackColor = true;
			this.checkBoxAutoClear.CheckedChanged += new System.EventHandler(this.CheckBoxAutoClearCheckedChanged);
			// 
			// checkBoxLoopBack
			// 
			this.checkBoxLoopBack.Location = new System.Drawing.Point(8, 23);
			this.checkBoxLoopBack.Name = "checkBoxLoopBack";
			this.checkBoxLoopBack.Size = new System.Drawing.Size(135, 24);
			this.checkBoxLoopBack.TabIndex = 3;
			this.checkBoxLoopBack.Text = "LoopBack";
			this.checkBoxLoopBack.UseVisualStyleBackColor = true;
			this.checkBoxLoopBack.CheckedChanged += new System.EventHandler(this.CheckBoxLoopBackCheckedChanged);
			// 
			// checkBoxEnableRule
			// 
			this.checkBoxEnableRule.Location = new System.Drawing.Point(8, 54);
			this.checkBoxEnableRule.Name = "checkBoxEnableRule";
			this.checkBoxEnableRule.Size = new System.Drawing.Size(148, 24);
			this.checkBoxEnableRule.TabIndex = 0;
			this.checkBoxEnableRule.Text = "Enable reply rules";
			this.checkBoxEnableRule.UseVisualStyleBackColor = true;
			this.checkBoxEnableRule.CheckedChanged += new System.EventHandler(this.CheckBoxEnableRuleCheckedChanged);
			// 
			// checkBoxShowdata
			// 
			this.checkBoxShowdata.Checked = true;
			this.checkBoxShowdata.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShowdata.Location = new System.Drawing.Point(286, 15);
			this.checkBoxShowdata.Name = "checkBoxShowdata";
			this.checkBoxShowdata.Size = new System.Drawing.Size(77, 24);
			this.checkBoxShowdata.TabIndex = 3;
			this.checkBoxShowdata.Text = "Show log";
			this.checkBoxShowdata.UseVisualStyleBackColor = true;
			this.checkBoxShowdata.CheckedChanged += new System.EventHandler(this.CheckBoxShowdataCheckedChanged);
			// 
			// checkBoxShowHex
			// 
			this.checkBoxShowHex.Location = new System.Drawing.Point(376, 15);
			this.checkBoxShowHex.Name = "checkBoxShowHex";
			this.checkBoxShowHex.Size = new System.Drawing.Size(57, 24);
			this.checkBoxShowHex.TabIndex = 2;
			this.checkBoxShowHex.Text = "Hex";
			this.checkBoxShowHex.UseVisualStyleBackColor = true;
			this.checkBoxShowHex.CheckedChanged += new System.EventHandler(this.CheckBoxShowHexCheckedChanged);
			// 
			// checkBoxSendHex
			// 
			this.checkBoxSendHex.Location = new System.Drawing.Point(286, 285);
			this.checkBoxSendHex.Name = "checkBoxSendHex";
			this.checkBoxSendHex.Size = new System.Drawing.Size(48, 24);
			this.checkBoxSendHex.TabIndex = 1;
			this.checkBoxSendHex.Text = "Hex";
			this.checkBoxSendHex.UseVisualStyleBackColor = true;
			this.checkBoxSendHex.CheckedChanged += new System.EventHandler(this.CheckBoxSendHexCheckedChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(520, 312);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 74);
			this.button2.TabIndex = 0;
			this.button2.Text = "Send";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(520, 16);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(68, 23);
			this.buttonClear.TabIndex = 10;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBoxTCP2);
			this.groupBox3.Controls.Add(this.buttonConnect);
			this.groupBox3.Controls.Add(this.textBoxClientPort);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.textBoxClentIP);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(13, 143);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(161, 122);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Client Config";
			// 
			// comboBoxTCP2
			// 
			this.comboBoxTCP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTCP2.FormattingEnabled = true;
			this.comboBoxTCP2.Items.AddRange(new object[] {
									"TCP",
									"UDP"});
			this.comboBoxTCP2.Location = new System.Drawing.Point(101, 55);
			this.comboBoxTCP2.Name = "comboBoxTCP2";
			this.comboBoxTCP2.Size = new System.Drawing.Size(49, 20);
			this.comboBoxTCP2.TabIndex = 17;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(11, 85);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(139, 23);
			this.buttonConnect.TabIndex = 16;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			// 
			// textBoxClientPort
			// 
			this.textBoxClientPort.Location = new System.Drawing.Point(46, 54);
			this.textBoxClientPort.MaxLength = 5;
			this.textBoxClientPort.Name = "textBoxClientPort";
			this.textBoxClientPort.Size = new System.Drawing.Size(45, 21);
			this.textBoxClientPort.TabIndex = 15;
			this.textBoxClientPort.Text = "65432";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Port:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxClentIP
			// 
			this.textBoxClentIP.Location = new System.Drawing.Point(46, 24);
			this.textBoxClentIP.Name = "textBoxClentIP";
			this.textBoxClentIP.Size = new System.Drawing.Size(104, 21);
			this.textBoxClentIP.TabIndex = 4;
			this.textBoxClentIP.Text = "127.0.0.1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "IP:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SocketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.checkBoxSendHex);
			this.Controls.Add(this.checkBoxShowdata);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.checkBoxShowHex);
			this.Controls.Add(this.textBoxInterval);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cBAutoSend);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxSend);
			this.Controls.Add(this.textBoxLogdata);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SocketForm";
			this.Text = "SocketForm";
			this.Load += new System.EventHandler(this.SocketFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox comboBoxTCP2;
		private System.Windows.Forms.ComboBox comboBoxTCP1;
		private System.Windows.Forms.TextBox textBoxClentIP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxClientPort;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBoxAutoClear;
		private System.Windows.Forms.CheckBox checkBoxLoopBack;
		private System.Windows.Forms.CheckBox checkBoxEnableRule;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.ComboBox comboBoxServerIP;
		private System.Windows.Forms.TextBox textBoxServerPort;
		private System.Windows.Forms.CheckBox checkBoxShowdata;
		private System.Windows.Forms.CheckBox checkBoxShowHex;
		private System.Windows.Forms.CheckBox checkBoxSendHex;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxInterval;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox cBAutoSend;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxSend;
		private System.Windows.Forms.TextBox textBoxLogdata;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonStartServer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		
	}
}
