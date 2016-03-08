/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:06
 * 
 */
namespace vTCPServer.Forms
{
	partial class RuleForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleForm));
			this.listView1 = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxContinueNext = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxDelay = new System.Windows.Forms.TextBox();
			this.checkBoxAddCRC = new System.Windows.Forms.CheckBox();
			this.textBoxRespData = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxHEX = new System.Windows.Forms.CheckBox();
			this.checkBoxMatchOnce = new System.Windows.Forms.CheckBox();
			this.checkBoxMatchPart = new System.Windows.Forms.CheckBox();
			this.textBoxRecvData = new System.Windows.Forms.TextBox();
			this.checkBoxEnable = new System.Windows.Forms.CheckBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonUp = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDown = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonApply = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.LabelWrap = false;
			this.listView1.Location = new System.Drawing.Point(12, 36);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Scrollable = false;
			this.listView1.Size = new System.Drawing.Size(183, 432);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView1ItemSelectionChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Recv data:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(54, 20);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(325, 21);
			this.textBoxName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(14, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxContinueNext);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBoxDelay);
			this.groupBox1.Controls.Add(this.checkBoxAddCRC);
			this.groupBox1.Controls.Add(this.textBoxRespData);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.checkBoxHEX);
			this.groupBox1.Controls.Add(this.checkBoxMatchOnce);
			this.groupBox1.Controls.Add(this.checkBoxMatchPart);
			this.groupBox1.Controls.Add(this.textBoxRecvData);
			this.groupBox1.Controls.Add(this.checkBoxEnable);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(215, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(493, 439);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// checkBoxContinueNext
			// 
			this.checkBoxContinueNext.Location = new System.Drawing.Point(278, 52);
			this.checkBoxContinueNext.Name = "checkBoxContinueNext";
			this.checkBoxContinueNext.Size = new System.Drawing.Size(103, 24);
			this.checkBoxContinueNext.TabIndex = 15;
			this.checkBoxContinueNext.Text = "ContinueNext";
			this.checkBoxContinueNext.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(371, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Delay:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(459, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "ms";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxDelay
			// 
			this.textBoxDelay.Location = new System.Drawing.Point(415, 256);
			this.textBoxDelay.Name = "textBoxDelay";
			this.textBoxDelay.Size = new System.Drawing.Size(40, 21);
			this.textBoxDelay.TabIndex = 12;
			this.textBoxDelay.Text = "100";
			// 
			// checkBoxAddCRC
			// 
			this.checkBoxAddCRC.Location = new System.Drawing.Point(104, 255);
			this.checkBoxAddCRC.Name = "checkBoxAddCRC";
			this.checkBoxAddCRC.Size = new System.Drawing.Size(72, 24);
			this.checkBoxAddCRC.TabIndex = 11;
			this.checkBoxAddCRC.Text = "AddCRC16";
			this.checkBoxAddCRC.UseVisualStyleBackColor = true;
			// 
			// textBoxRespData
			// 
			this.textBoxRespData.Location = new System.Drawing.Point(14, 284);
			this.textBoxRespData.Multiline = true;
			this.textBoxRespData.Name = "textBoxRespData";
			this.textBoxRespData.Size = new System.Drawing.Size(464, 144);
			this.textBoxRespData.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(14, 255);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Resp data:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxHEX
			// 
			this.checkBoxHEX.Location = new System.Drawing.Point(405, 51);
			this.checkBoxHEX.Name = "checkBoxHEX";
			this.checkBoxHEX.Size = new System.Drawing.Size(45, 24);
			this.checkBoxHEX.TabIndex = 8;
			this.checkBoxHEX.Text = "HEX";
			this.checkBoxHEX.UseVisualStyleBackColor = true;
			// 
			// checkBoxMatchOnce
			// 
			this.checkBoxMatchOnce.Location = new System.Drawing.Point(191, 52);
			this.checkBoxMatchOnce.Name = "checkBoxMatchOnce";
			this.checkBoxMatchOnce.Size = new System.Drawing.Size(81, 24);
			this.checkBoxMatchOnce.TabIndex = 7;
			this.checkBoxMatchOnce.Text = "MatchOnce";
			this.checkBoxMatchOnce.UseVisualStyleBackColor = true;
			// 
			// checkBoxMatchPart
			// 
			this.checkBoxMatchPart.Location = new System.Drawing.Point(104, 52);
			this.checkBoxMatchPart.Name = "checkBoxMatchPart";
			this.checkBoxMatchPart.Size = new System.Drawing.Size(81, 24);
			this.checkBoxMatchPart.TabIndex = 6;
			this.checkBoxMatchPart.Text = "MatchPart";
			this.checkBoxMatchPart.UseVisualStyleBackColor = true;
			// 
			// textBoxRecvData
			// 
			this.textBoxRecvData.Location = new System.Drawing.Point(14, 78);
			this.textBoxRecvData.Multiline = true;
			this.textBoxRecvData.Name = "textBoxRecvData";
			this.textBoxRecvData.Size = new System.Drawing.Size(464, 171);
			this.textBoxRecvData.TabIndex = 5;
			// 
			// checkBoxEnable
			// 
			this.checkBoxEnable.Checked = true;
			this.checkBoxEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxEnable.Location = new System.Drawing.Point(405, 20);
			this.checkBoxEnable.Name = "checkBoxEnable";
			this.checkBoxEnable.Size = new System.Drawing.Size(60, 24);
			this.checkBoxEnable.TabIndex = 4;
			this.checkBoxEnable.Text = "Enable";
			this.checkBoxEnable.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonImport,
									this.toolStripButtonExport,
									this.toolStripSeparator1,
									this.toolStripButtonAdd,
									this.toolStripButtonDelete,
									this.toolStripButton1,
									this.toolStripButtonUp,
									this.toolStripButtonDown,
									this.toolStripButton2,
									this.toolStripButtonApply});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(720, 25);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonImport
			// 
			this.toolStripButtonImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImport.Image")));
			this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonImport.Name = "toolStripButtonImport";
			this.toolStripButtonImport.Size = new System.Drawing.Size(68, 22);
			this.toolStripButtonImport.Text = "Import";
			this.toolStripButtonImport.Click += new System.EventHandler(this.ToolStripButtonImportClick);
			// 
			// toolStripButtonExport
			// 
			this.toolStripButtonExport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExport.Image")));
			this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExport.Name = "toolStripButtonExport";
			this.toolStripButtonExport.Size = new System.Drawing.Size(66, 22);
			this.toolStripButtonExport.Text = "Export";
			this.toolStripButtonExport.Click += new System.EventHandler(this.ToolStripButtonExportClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonAdd
			// 
			this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
			this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAdd.Name = "toolStripButtonAdd";
			this.toolStripButtonAdd.Size = new System.Drawing.Size(52, 22);
			this.toolStripButtonAdd.Text = "Add";
			this.toolStripButtonAdd.Click += new System.EventHandler(this.ToolStripButtonAddClick);
			// 
			// toolStripButtonDelete
			// 
			this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
			this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDelete.Name = "toolStripButtonDelete";
			this.toolStripButtonDelete.Size = new System.Drawing.Size(65, 22);
			this.toolStripButtonDelete.Text = "Delete";
			this.toolStripButtonDelete.Click += new System.EventHandler(this.ToolStripButtonDeleteClick);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonUp
			// 
			this.toolStripButtonUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUp.Image")));
			this.toolStripButtonUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonUp.Name = "toolStripButtonUp";
			this.toolStripButtonUp.Size = new System.Drawing.Size(45, 22);
			this.toolStripButtonUp.Text = "Up";
			this.toolStripButtonUp.Click += new System.EventHandler(this.ToolStripButtonUpClick);
			// 
			// toolStripButtonDown
			// 
			this.toolStripButtonDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDown.Image")));
			this.toolStripButtonDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDown.Name = "toolStripButtonDown";
			this.toolStripButtonDown.Size = new System.Drawing.Size(61, 22);
			this.toolStripButtonDown.Text = "Down";
			this.toolStripButtonDown.Click += new System.EventHandler(this.ToolStripButtonDownClick);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonApply
			// 
			this.toolStripButtonApply.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonApply.Image")));
			this.toolStripButtonApply.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonApply.Name = "toolStripButtonApply";
			this.toolStripButtonApply.Size = new System.Drawing.Size(61, 22);
			this.toolStripButtonApply.Text = "Apply";
			this.toolStripButtonApply.Click += new System.EventHandler(this.ToolStripButtonSaveClick);
			// 
			// RuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 480);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RuleForm";
			this.Text = "RuleForm";
			this.Load += new System.EventHandler(this.RuleFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox checkBoxContinueNext;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBoxAddCRC;
		private System.Windows.Forms.TextBox textBoxDelay;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxRespData;
		private System.Windows.Forms.CheckBox checkBoxMatchOnce;
		private System.Windows.Forms.CheckBox checkBoxHEX;
		private System.Windows.Forms.CheckBox checkBoxMatchPart;
		private System.Windows.Forms.ToolStripButton toolStripButtonApply;
		private System.Windows.Forms.ToolStripSeparator toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButtonDown;
		private System.Windows.Forms.ToolStripButton toolStripButtonUp;
		private System.Windows.Forms.ToolStripSeparator toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
		private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonExport;
		private System.Windows.Forms.ToolStripButton toolStripButtonImport;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TextBox textBoxRecvData;
		private System.Windows.Forms.CheckBox checkBoxEnable;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
	}
}
