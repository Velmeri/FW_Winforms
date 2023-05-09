using FW_Winforms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FW_Winforms
{
	public partial class GoalMenu : Form
	{
		public Goal Data { get; set; }

		public GoalMenu()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			tName.GotFocus += tName_GotFocus;
			this.KeyPreview = true;
		}

		public GoalMenu(Goal goal)
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			tName.GotFocus += tName_GotFocus;
			this.KeyPreview = true;

			tName.Text = goal.Name;
			tDescription.Text = goal.Description;
			switch (goal.Priority) {
				case PRIORITY.LOW: {
						rLow.Checked = true;
						break;
					}
				case PRIORITY.MEDIUM: {
						rMedium.Checked = true;
						break;
					}
				case PRIORITY.HIGH: {
						rHight.Checked = true;
						break;
					}
			}
			foreach (string tag in goal.Tags) {
				lTags.Items.Add(tag);
			}
			tPath.Text = goal.AttachedFile;
			dtExecutionTime.Value = goal.ExecutionTime;
		}

		public void tName_GotFocus(object sender, EventArgs e)
		{
			if(tName.ForeColor == Global.erroeColor) {
				tName.ForeColor = Global.standartColor;
				tName.Text = "";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "c:\\";
			openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				string filePath = openFileDialog.FileName;
				tPath.Text = filePath;
			}
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			using (TegsMenu tagMenu = new TegsMenu()) {
				if(tagMenu.ShowDialog() == DialogResult.OK) {
					foreach(string tag in lTags.Items)
						if(tag == tagMenu.Data) {
							MessageBox.Show(
								"Вы не можете добавить два одинаковых тега!", 
								"ОЙ", 
								MessageBoxButtons.OK, 
								MessageBoxIcon.Error);

							return;
					}
					lTags.Items.Add(tagMenu.Data);
				}
			}
		}

		private void bDel_Click(object sender, EventArgs e)
		{
			if(lTags.SelectedIndex != -1)
			lTags.Items.RemoveAt(lTags.SelectedIndex);
		}

		private void bReady_Click(object sender, EventArgs e)
		{
			if(Regex.IsMatch(tName.Text, @"^(?!\s)(?=.*[\p{L}\p{N}])") && tName.ForeColor != Global.erroeColor) {
				string[] tags = new string[lTags.Items.Count];
				foreach (string str in lTags.Items) tags[0] = str;

				Data = new Goal(
					tName.Text,
					dtExecutionTime.Value,
					rLow.Checked ? PRIORITY.LOW : rMedium.Checked ? PRIORITY.MEDIUM : PRIORITY.HIGH,
					tags,
					tDescription.Text,
					tPath.Text
					);

				this.DialogResult = DialogResult.OK;
				this.Close();

			} else {
				tName.ForeColor = Global.erroeColor;
				tName.Text = "Введите имя цели!";
			}
		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void GoalMenu_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter && !tDescription.Focused) {
				this.bReady_Click(sender, null);
			} else if (e.KeyCode == Keys.Escape) {
				this.bCancel_Click(sender, null);
			}
		}
	}
}
