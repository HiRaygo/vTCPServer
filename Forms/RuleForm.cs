/*
 * Created by SharpDevelop
 * User: XiaoSanYa
 * Date: 2016/1/24
 * Time: 12:06
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using vTCPServer.Common;

namespace vTCPServer.Forms
{
	/// <summary>
	/// Description of RuleForm.
	/// </summary>
	public partial class RuleForm : Form
	{
		private static List<RuleMsg> rulelist = null;
		private bool isModfying = false;
		
		public RuleForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			rulelist = RuleHelper.GetRules();
			
		}
		
		void RuleFormLoad(object sender, EventArgs e)
		{
			UpdateListView();
		}
		
		/// <summary>
		/// Update the ListView item
		/// </summary>
		private void UpdateListView()
		{
			if(rulelist == null)
				return;
			this.listView1.Clear();
			
			ColumnHeader  ch= new ColumnHeader(); 
			ch.Text = "Rule List";   //header title			 
			ch.Width = 175;    		//header width			 
			ch.TextAlign = HorizontalAlignment.Left;		 
			this.listView1.Columns.Add(ch);
			
			ImageList imgList = new ImageList();			
			imgList.ImageSize = new Size(1, 20);// sidth and heigh		
			listView1.SmallImageList = imgList; 
			
			this.listView1.BeginUpdate();

			foreach(RuleMsg rule in rulelist)
			{
	            this.listView1.Items.Add(rule.name);
			}
			this.listView1.EndUpdate(); 
		}
		
		void ToolStripButtonAddClick(object sender, EventArgs e)
		{
			isModfying = true;
			if(string.IsNullOrEmpty(textBoxName.Text))
			{
				MessageBox.Show("Name cannot be blank.");
				return;
			}
			if(string.IsNullOrEmpty(textBoxRecvData.Text))
			{
				MessageBox.Show("MatchData cannot be blank.");
				return;
			}
			if(string.IsNullOrEmpty(textBoxRespData.Text))
			{
				MessageBox.Show("RespData cannot be blank.");
				return;
			}
						
			//Update rulelist
			RuleMsg rule = new RuleMsg();
			rule.name = textBoxName.Text;
			rule.isAddCRC16 = checkBoxAddCRC.Checked;
			rule.isEnable = checkBoxEnable.Checked;
			rule.isHex = checkBoxHEX.Checked;
			rule.isMatchOnce = checkBoxMatchOnce.Checked;
			rule.isMatchPart = checkBoxMatchPart.Checked;
			rule.isContinueNext = checkBoxContinueNext.Checked;
			rule.rString = textBoxRecvData.Text;
			rule.mString = textBoxRespData.Text;
			int.TryParse(textBoxDelay.Text, out rule.iDelay);
			rulelist.Add(rule);
			
			//Add item
			this.listView1.BeginUpdate();
            this.listView1.Items.Add(textBoxName.Text);
            int index = listView1.Items.Count;
            isModfying = true;
            listView1.Items[index-1].Selected = true;
			this.listView1.EndUpdate();
		}
		
		void ToolStripButtonDeleteClick(object sender, EventArgs e)
		{
			int index = 0;
			foreach(ListViewItem lvi in listView1.SelectedItems)
			{
				index = lvi.Index;
				//update rulelist
				rulelist.RemoveAt(index);
				//update listview
				isModfying = true;
				listView1.Items.RemoveAt(index);				
			}
			
			if(index > 0)
			{
				int i = (index >= listView1.Items.Count) ? index-1 : index;
				isModfying = true;
				listView1.Items[i].Selected = true;
			}
		}
		
		void ToolStripButtonUpClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[0].Index != 0)
			{
				listView1.BeginUpdate();
				foreach (ListViewItem lvi in listView1.SelectedItems)
				{
					int index = lvi.Index;
					//Update rulelist
					RuleMsg rule = rulelist[index-1];
					rulelist[index -1] = rulelist[index];
					rulelist[index] = rule;
					//Update rulelist
					ListViewItem item = lvi;
					isModfying = true;
					listView1.Items.RemoveAt(index);
					listView1.Items.Insert(index - 1, item);
					isModfying = true;
					listView1.Items[index-1].Selected = true;					
				}
				listView1.EndUpdate();
			}
			listView1.Focus();
		}
		
		void ToolStripButtonDownClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems[listView1.SelectedItems.Count - 1].Index < (listView1.Items.Count-1))
			{
				listView1.BeginUpdate();
				foreach (ListViewItem lvi in listView1.SelectedItems)
				{
					ListViewItem item = lvi;
					int index = lvi.Index;					
					//Update rulelist
					RuleMsg rule = rulelist[index +1];
					rulelist[index +1] = rulelist[index];
					rulelist[index] = rule;
					//update listview
					isModfying = true;
					listView1.Items.RemoveAt(index);
					listView1.Items.Insert(index +1, item);
					isModfying = true;
					listView1.Items[index+1].Selected = true;
				}
				listView1.EndUpdate();
			}
			listView1.Focus();
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			ListViewItem item = listView1.SelectedItems[0];
			if(item != null)
			{
				int index = item.Index;
				//Update rulelist
				RuleMsg rule = new RuleMsg();
				rule.name = textBoxName.Text;
				rule.isAddCRC16 = checkBoxAddCRC.Checked;
				rule.isEnable = checkBoxEnable.Checked;
				rule.isHex = checkBoxHEX.Checked;
				rule.isMatchOnce = checkBoxMatchOnce.Checked;
				rule.isMatchPart = checkBoxMatchPart.Checked;
				rule.isContinueNext = checkBoxContinueNext.Checked;
				rule.rString = textBoxRecvData.Text;
				rule.mString = textBoxRespData.Text;
				int.TryParse(textBoxDelay.Text, out rule.iDelay);
				rulelist[index] = rule;
				this.listView1.Items[index].Text = textBoxName.Text;
			}
			
			RuleHelper.SetRules(rulelist);
		}
		
		void ListView1ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			int index = e.ItemIndex;
			if(e.IsSelected)
			{
				RuleMsg rule = rulelist[index];
				textBoxDelay.Text = rule.iDelay.ToString();
				textBoxName.Text = rule.name;
				textBoxRecvData.Text = rule.rString;
				textBoxRespData.Text = rule.mString;
				checkBoxAddCRC.Checked = rule.isAddCRC16;
				checkBoxEnable.Checked = rule.isEnable;
				checkBoxHEX.Checked = rule.isHex;
				checkBoxMatchOnce.Checked = rule.isMatchOnce;
				checkBoxMatchPart.Checked = rule.isMatchPart;
				checkBoxContinueNext.Checked = rule.isContinueNext;
			}
			else
			{
				if(isModfying)
				{
					isModfying = false;
					return;
				}
				//Update rulelist
				RuleMsg rule = new RuleMsg();
				rule.name = textBoxName.Text;
				rule.isAddCRC16 = checkBoxAddCRC.Checked;
				rule.isEnable = checkBoxEnable.Checked;
				rule.isHex = checkBoxHEX.Checked;
				rule.isMatchOnce = checkBoxMatchOnce.Checked;
				rule.isMatchPart = checkBoxMatchPart.Checked;
				rule.isContinueNext = checkBoxContinueNext.Checked;
				rule.rString = textBoxRecvData.Text;
				rule.mString = textBoxRespData.Text;
				int.TryParse(textBoxDelay.Text, out rule.iDelay);
				rulelist[index] = rule;
				this.listView1.Items[index].Text = textBoxName.Text;
			}
		}
		
		void ToolStripButtonImportClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "XML Document(*.xml)|*.xml";
			ofd.Multiselect = false;
			ofd.ValidateNames = true;
			if(ofd.ShowDialog() == DialogResult.OK)
            {
				try{
					RuleHelper.ImportRulesFromXml(ofd.FileName);
					rulelist = RuleHelper.GetRules();
					UpdateListView();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
		}
		
		void ToolStripButtonExportClick(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "XML Document(*.xml)|*.xml";
			sfd.ValidateNames = true;
			if(sfd.ShowDialog() == DialogResult.OK)
            {
				try{
					RuleHelper.ExportRulesToXml(sfd.FileName);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
            }
		}
	}
}
