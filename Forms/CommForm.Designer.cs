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
			this.comboBoxDevices = new System.Windows.Forms.ComboBox();
			this.textBoxMac = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxTimeout = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxServerIP = new System.Windows.Forms.TextBox();
			this.textBoxServerPort = new System.Windows.Forms.TextBox();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxLoopBack = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableRule = new System.Windows.Forms.CheckBox();
			this.checkBoxAutoClear = new System.Windows.Forms.CheckBox();
			this.checkBoxShowdata = new System.Windows.Forms.CheckBox();
			this.checkBoxSendHex = new System.Windows.Forms.CheckBox();
			this.buttonSend = new System.Windows.Forms.Button();
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
			this.groupBox1.Controls.Add(this.comboBoxDevices);
			this.groupBox1.Controls.Add(this.textBoxMac);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.textBoxTimeout);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBoxServerIP);
			this.groupBox1.Controls.Add(this.textBoxServerPort);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonStartServer);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(161, 231);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server Config";
			// 
			// comboBoxDevices
			// 
			this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDevices.FormattingEnabled = true;
			this.comboBoxDevices.Location = new System.Drawing.Point(10, 25);
			this.comboBoxDevices.Name = "comboBoxDevices";
			this.comboBoxDevices.Size = new System.Drawing.Size(139, 20);
			this.comboBoxDevices.TabIndex = 23;
			// 
			// textBoxMac
			// 
			this.textBoxMac.Location = new System.Drawing.Point(45, 57);
			this.textBoxMac.Name = "textBoxMac";
			this.textBoxMac.Size = new System.Drawing.Size(104, 21);
			this.textBoxMac.TabIndex = 21;
			this.textBoxMac.Text = "AB:CD:EF:12:34:56";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(10, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Mac:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxTimeout
			// 
			this.textBoxTimeout.Location = new System.Drawing.Point(104, 159);
			this.textBoxTimeout.MaxLength = 6;
			this.textBoxTimeout.Name = "textBoxTimeout";
			this.textBoxTimeout.Size = new System.Drawing.Size(45, 21);
			this.textBoxTimeout.TabIndex = 18;
			this.textBoxTimeout.Text = "10";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Timeout(ms):";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxServerIP
			// 
			this.textBoxServerIP.Location = new System.Drawing.Point(45, 91);
			this.textBoxServerIP.Name = "textBoxServerIP";
			this.textBoxServerIP.Size = new System.Drawing.Size(104, 21);
			this.textBoxServerIP.TabIndex = 16;
			this.textBoxServerIP.Text = "129.9.191.100";
			// 
			// textBoxServerPort
			// 
			this.textBoxServerPort.Location = new System.Drawing.Point(104, 123);
			this.textBoxServerPort.MaxLength = 6;
			this.textBoxServerPort.Name = "textBoxServerPort";
			this.textBoxServerPort.Size = new System.Drawing.Size(45, 21);
			this.textBoxServerPort.TabIndex = 14;
			this.textBoxServerPort.Text = "65432";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(10, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Port listened:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "IP:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonStartServer
			// 
			this.buttonStartServer.Location = new System.Drawing.Point(10, 194);
			this.buttonStartServer.Name = "buttonStartServer";
			this.buttonStartServer.Size = new System.Drawing.Size(139, 23);
			this.buttonStartServer.TabIndex = 0;
			this.buttonStartServer.Text = "Start";
			this.buttonStartServer.UseVisualStyleBackColor = true;
			this.buttonStartServer.Click += new System.EventHandler(this.ButtonStartServerClick);
			// 
			// textBoxLogdata
			// 
			this.textBoxLogdata.Location = new System.Drawing.Point(192, 41);
			this.textBoxLogdata.Multiline = true;
			this.textBoxLogdata.Name = "textBoxLogdata";
			this.textBoxLogdata.ReadOnly = true;
			this.textBoxLogdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLogdata.Size = new System.Drawing.Size(516, 303);
			this.textBoxLogdata.TabIndex = 1;
			// 
			// textBoxSend
			// 
			this.textBoxSend.Location = new System.Drawing.Point(175, 47);
			this.textBoxSend.Multiline = true;
			this.textBoxSend.Name = "textBoxSend";
			this.textBoxSend.Size = new System.Drawing.Size(432, 61);
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
			this.label8.Location = new System.Drawing.Point(175, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Data to send:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cBAutoSend
			// 
			this.cBAutoSend.Location = new System.Drawing.Point(469, 20);
			this.cBAutoSend.Name = "cBAutoSend";
			this.cBAutoSend.Size = new System.Drawing.Size(72, 24);
			this.cBAutoSend.TabIndex = 5;
			this.cBAutoSend.Text = "AutoSend";
			this.cBAutoSend.UseVisualStyleBackColor = true;
			this.cBAutoSend.CheckedChanged += new System.EventHandler(this.CBAutoSendCheckedChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(547, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 23);
			this.label9.TabIndex = 6;
			this.label9.Text = "Interval(ms)";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxInterval
			// 
			this.textBoxInterval.Location = new System.Drawing.Point(632, 22);
			this.textBoxInterval.Name = "textBoxInterval";
			this.textBoxInterval.Size = new System.Drawing.Size(48, 21);
			this.textBoxInterval.TabIndex = 7;
			this.textBoxInterval.Text = "500";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxLoopBack);
			this.groupBox2.Controls.Add(this.checkBoxEnableRule);
			this.groupBox2.Location = new System.Drawing.Point(13, 250);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(161, 94);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Rule Config";
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
			// checkBoxAutoClear
			// 
			this.checkBoxAutoClear.Checked = true;
			this.checkBoxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAutoClear.Location = new System.Drawing.Point(540, 14);
			this.checkBoxAutoClear.Name = "checkBoxAutoClear";
			this.checkBoxAutoClear.Size = new System.Drawing.Size(83, 24);
			this.checkBoxAutoClear.TabIndex = 4;
			this.checkBoxAutoClear.Text = "AutoClear";
			this.checkBoxAutoClear.UseVisualStyleBackColor = true;
			this.checkBoxAutoClear.CheckedChanged += new System.EventHandler(this.CheckBoxAutoClearCheckedChanged);
			// 
			// checkBoxShowdata
			// 
			this.checkBoxShowdata.Checked = true;
			this.checkBoxShowdata.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShowdata.Location = new System.Drawing.Point(286, 15);
			this.checkBoxShowdata.Name = "checkBoxShowdata";
			this.checkBoxShowdata.Size = new System.Drawing.Size(92, 24);
			this.checkBoxShowdata.TabIndex = 3;
			this.checkBoxShowdata.Text = "Enable log";
			this.checkBoxShowdata.UseVisualStyleBackColor = true;
			this.checkBoxShowdata.CheckedChanged += new System.EventHandler(this.CheckBoxShowdataCheckedChanged);
			// 
			// checkBoxSendHex
			// 
			this.checkBoxSendHex.Location = new System.Drawing.Point(269, 20);
			this.checkBoxSendHex.Name = "checkBoxSendHex";
			this.checkBoxSendHex.Size = new System.Drawing.Size(48, 24);
			this.checkBoxSendHex.TabIndex = 1;
			this.checkBoxSendHex.Text = "Hex";
			this.checkBoxSendHex.UseVisualStyleBackColor = true;
			this.checkBoxSendHex.CheckedChanged += new System.EventHandler(this.CheckBoxSendHexCheckedChanged);
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(613, 47);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(68, 61);
			this.buttonSend.TabIndex = 0;
			this.buttonSend.Text = "Client  Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(640, 14);
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
			this.groupBox3.Controls.Add(this.checkBoxSendHex);
			this.groupBox3.Controls.Add(this.buttonSend);
			this.groupBox3.Controls.Add(this.textBoxClentIP);
			this.groupBox3.Controls.Add(this.textBoxInterval);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.cBAutoSend);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.textBoxSend);
			this.groupBox3.Location = new System.Drawing.Point(13, 350);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(695, 118);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Client";
			// 
			// comboBoxTCP2
			// 
			this.comboBoxTCP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTCP2.FormattingEnabled = true;
			this.comboBoxTCP2.Items.AddRange(new object[] {
									"TCP"});
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
			// CommForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 480);
			this.Controls.Add(this.checkBoxAutoClear);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.checkBoxShowdata);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxLogdata);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CommForm";
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
		private System.Windows.Forms.ComboBox comboBoxDevices;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxMac;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTimeout;
		private System.Windows.Forms.TextBox textBoxServerIP;
		private System.Windows.Forms.ComboBox comboBoxTCP2;
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
		private System.Windows.Forms.TextBox textBoxServerPort;
		private System.Windows.Forms.CheckBox checkBoxShowdata;
		private System.Windows.Forms.CheckBox checkBoxSendHex;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.GroupBox groupBox2;
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
