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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FW_Winforms
{
	public partial class TegsMenu : Form
	{
		public string Data
		{
			get { return tTegNeme.Text; }
		}

		public TegsMenu()
		{
			InitializeComponent();
			tTegNeme.GotFocus += tTegName_GotFocus;
			this.ControlBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
		}

		public void tTegName_GotFocus(object sender, EventArgs e)
		{
			if (tTegNeme.ForeColor == Global.erroeColor) {
				tTegNeme.Text = "";
				tTegNeme.ForeColor = Global.standartColor;
			}
		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			if (Regex.IsMatch(tTegNeme.Text, @"^(?!\s)(?=.*[\p{L}\p{N}])")) {
				this.DialogResult = DialogResult.OK;
				this.Close();
			} else {
				tTegNeme.ForeColor = Global.erroeColor;
				tTegNeme.Text = "Неверное значение";
			}
		}
	}
}
