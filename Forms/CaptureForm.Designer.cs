/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:05
 * 
 */
namespace vTCPServer.Forms
{
	partial class CaptureForm
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
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.buttonStartCapture = new System.Windows.Forms.Button();
			this.checkBoxShowdata = new System.Windows.Forms.CheckBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.checkBoxIP = new System.Windows.Forms.CheckBox();
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.checkBoxPort = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.comboBoxDevices = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(216, 43);
			this.textBoxPort.MaxLength = 6;
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(45, 21);
			this.textBoxPort.TabIndex = 14;
			this.textBoxPort.Text = "65432";
			// 
			// buttonStartCapture
			// 
			this.buttonStartCapture.Location = new System.Drawing.Point(280, 42);
			this.buttonStartCapture.Name = "buttonStartCapture";
			this.buttonStartCapture.Size = new System.Drawing.Size(69, 23);
			this.buttonStartCapture.TabIndex = 0;
			this.buttonStartCapture.Text = "Capture";
			this.buttonStartCapture.UseVisualStyleBackColor = true;
			this.buttonStartCapture.Click += new System.EventHandler(this.ButtonStartCaptureClick);
			// 
			// checkBoxShowdata
			// 
			this.checkBoxShowdata.Checked = true;
			this.checkBoxShowdata.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShowdata.Location = new System.Drawing.Point(483, 42);
			this.checkBoxShowdata.Name = "checkBoxShowdata";
			this.checkBoxShowdata.Size = new System.Drawing.Size(49, 24);
			this.checkBoxShowdata.TabIndex = 3;
			this.checkBoxShowdata.Text = "Log";
			this.checkBoxShowdata.UseVisualStyleBackColor = true;
			this.checkBoxShowdata.CheckedChanged += new System.EventHandler(this.CheckBoxShowdataCheckedChanged);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(613, 42);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(68, 23);
			this.buttonClear.TabIndex = 10;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// checkBoxIP
			// 
			this.checkBoxIP.Location = new System.Drawing.Point(5, 41);
			this.checkBoxIP.Name = "checkBoxIP";
			this.checkBoxIP.Size = new System.Drawing.Size(42, 24);
			this.checkBoxIP.TabIndex = 15;
			this.checkBoxIP.Text = "IP:";
			this.checkBoxIP.UseVisualStyleBackColor = true;
			this.checkBoxIP.CheckedChanged += new System.EventHandler(this.CheckBoxIPCheckedChanged);
			// 
			// textBoxIP
			// 
			this.textBoxIP.Location = new System.Drawing.Point(48, 43);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(100, 21);
			this.textBoxIP.TabIndex = 16;
			this.textBoxIP.Text = "192.168.0.1";
			// 
			// checkBoxPort
			// 
			this.checkBoxPort.Location = new System.Drawing.Point(161, 41);
			this.checkBoxPort.Name = "checkBoxPort";
			this.checkBoxPort.Size = new System.Drawing.Size(55, 24);
			this.checkBoxPort.TabIndex = 17;
			this.checkBoxPort.Text = "Port:";
			this.checkBoxPort.UseVisualStyleBackColor = true;
			this.checkBoxPort.CheckedChanged += new System.EventHandler(this.CheckBoxPortCheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.comboBoxDevices);
			this.groupBox1.Controls.Add(this.buttonClear);
			this.groupBox1.Controls.Add(this.checkBoxShowdata);
			this.groupBox1.Controls.Add(this.textBoxIP);
			this.groupBox1.Controls.Add(this.checkBoxPort);
			this.groupBox1.Controls.Add(this.checkBoxIP);
			this.groupBox1.Controls.Add(this.buttonStartCapture);
			this.groupBox1.Controls.Add(this.textBoxPort);
			this.groupBox1.Location = new System.Drawing.Point(12, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 74);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(538, 42);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(69, 23);
			this.buttonSave.TabIndex = 19;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// comboBoxDevices
			// 
			this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDevices.FormattingEnabled = true;
			this.comboBoxDevices.Location = new System.Drawing.Point(6, 17);
			this.comboBoxDevices.Name = "comboBoxDevices";
			this.comboBoxDevices.Size = new System.Drawing.Size(675, 20);
			this.comboBoxDevices.TabIndex = 18;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 83);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(696, 385);
			this.listView1.TabIndex = 19;
			this.listView1.TabStop = false;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 30;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "time";
			this.columnHeader2.Width = 85;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "from";
			this.columnHeader3.Width = 125;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "to";
			this.columnHeader4.Width = 125;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "length";
			this.columnHeader5.Width = 50;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "data";
			this.columnHeader6.Width = 270;
			// 
			// CaptureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 480);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CaptureForm";
			this.Text = "SocketForm";
			this.Load += new System.EventHandler(this.CaptureFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ComboBox comboBoxDevices;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxPort;
		private System.Windows.Forms.TextBox textBoxIP;
		private System.Windows.Forms.CheckBox checkBoxIP;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.CheckBox checkBoxShowdata;
		private System.Windows.Forms.Button buttonStartCapture;
		
	}
}
