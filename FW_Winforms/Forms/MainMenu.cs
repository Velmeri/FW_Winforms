using FW_Winforms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FW_Winforms
{

	public partial class MainMenu : Form
	{
		private void Add(Goal goal)
		{
			goals.Add(goal);

			ListViewItem item = new ListViewItem(new[] { goal.Name,
				goal.ExecutionTime.ToString(),
				goal.Priority.ToString(),
				string.Join(",", goal.Tags),
				goal.Description,
				goal.AttachedFile
			});

			lGoals.Items.Add(item);
		}

		private void Edit(Goal goal)
		{
			ListViewItem item = new ListViewItem(new[] { goal.Name,
				goal.ExecutionTime.ToString(),
				goal.Priority.ToString(),
				string.Join(",", goal.Tags),
				goal.Description,
				goal.AttachedFile
			});

		}

		List<Goal> goals = new List<Goal>();

		string[] searchStrs = new string[]
		{
			"Имя",
			"Теги",
			"Описание"
		};

		List<int> Connection = new List<int>();

		public MainMenu()
		{
			InitializeComponent();
			foreach (string str in searchStrs) {
				cSearch.Items.Add(str);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (GoalMenu goal = new GoalMenu()) {
				if(goal.ShowDialog() == DialogResult.OK) {
					this.Add(goal.Data);
				}
			}
		}

		private void lGoals_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right) {
				ListViewItem item = lGoals.HitTest(e.Location).Item;
				if (item != null) {
					cmsGoal.Show(Cursor.Position); 
				}
			}
		}

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int selectedIndex = lGoals.Items.IndexOf(lGoals.SelectedItems[0]);
			using (GoalMenu goalMenu = new GoalMenu(goals[Connection[selectedIndex]])) {
				if(goalMenu.ShowDialog() == DialogResult.OK) {
					goals[Connection[selectedIndex]] = goalMenu.Data;

				}
			}
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lGoals.SelectedItems.Count > 0) {
				int selectedIndex = lGoals.Items.IndexOf(lGoals.SelectedItems[0]);
				if (selectedIndex >= 0) {
					goals.RemoveAt(Connection[selectedIndex]);
				}
				for (int i = 0; i < lGoals.SelectedItems.Count; i++) {
					lGoals.Items.Remove(lGoals.SelectedItems[i]);
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string keyword = tSearch.Text.Trim();
			List<string> filteredItems = new List<string>();
			
			switch (cSearch.SelectedIndex) {
				case 0: {
						for(int i = 0; i < )
						break;
					}
				case 1: {

						break;
					}
				case 2: {

						break;
					}
			}
		}
	}
}
