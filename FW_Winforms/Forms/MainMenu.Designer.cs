namespace FW_Winforms
{
	partial class MainMenu
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lGoals = new System.Windows.Forms.ListView();
			this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cDes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.cSort = new System.Windows.Forms.ComboBox();
			this.cmsGoal = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьПрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cRange = new System.Windows.Forms.ComboBox();
			this.cSearch = new System.Windows.Forms.ComboBox();
			this.tSearch = new System.Windows.Forms.TextBox();
			this.cmsGoal.SuspendLayout();
			this.SuspendLayout();
			// 
			// lGoals
			// 
			this.lGoals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cDes,
            this.cTags,
            this.cTime,
            this.cPriority,
            this.cFile});
			this.lGoals.HideSelection = false;
			this.lGoals.Location = new System.Drawing.Point(12, 74);
			this.lGoals.Name = "lGoals";
			this.lGoals.Size = new System.Drawing.Size(907, 397);
			this.lGoals.TabIndex = 0;
			this.lGoals.UseCompatibleStateImageBehavior = false;
			this.lGoals.View = System.Windows.Forms.View.Details;
			this.lGoals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lGoals_MouseClick);
			// 
			// cName
			// 
			this.cName.Text = "Название";
			// 
			// cDes
			// 
			this.cDes.Text = "Описание";
			this.cDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cTags
			// 
			this.cTags.Text = "Теги";
			this.cTags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cTime
			// 
			this.cTime.Text = "Дед-лайн";
			this.cTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cPriority
			// 
			this.cPriority.Text = "Приоритет";
			this.cPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cFile
			// 
			this.cFile.Text = "Прикрепленный файл";
			this.cFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cSort
			// 
			this.cSort.FormattingEnabled = true;
			this.cSort.Location = new System.Drawing.Point(798, 44);
			this.cSort.Name = "cSort";
			this.cSort.Size = new System.Drawing.Size(121, 24);
			this.cSort.TabIndex = 2;
			// 
			// cmsGoal
			// 
			this.cmsGoal.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsGoal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.открытьПрToolStripMenuItem});
			this.cmsGoal.Name = "cmsGoal";
			this.cmsGoal.Size = new System.Drawing.Size(294, 76);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
			this.открытьToolStripMenuItem.Text = "Открыть задачу";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// открытьПрToolStripMenuItem
			// 
			this.открытьПрToolStripMenuItem.Name = "открытьПрToolStripMenuItem";
			this.открытьПрToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
			this.открытьПрToolStripMenuItem.Text = "Открыть прикрепленный файл";
			// 
			// cRange
			// 
			this.cRange.FormattingEnabled = true;
			this.cRange.Location = new System.Drawing.Point(671, 44);
			this.cRange.Name = "cRange";
			this.cRange.Size = new System.Drawing.Size(121, 24);
			this.cRange.TabIndex = 4;
			// 
			// cSearch
			// 
			this.cSearch.FormattingEnabled = true;
			this.cSearch.Location = new System.Drawing.Point(472, 44);
			this.cSearch.Name = "cSearch";
			this.cSearch.Size = new System.Drawing.Size(121, 24);
			this.cSearch.TabIndex = 5;
			// 
			// tSearch
			// 
			this.tSearch.Location = new System.Drawing.Point(169, 46);
			this.tSearch.Name = "tSearch";
			this.tSearch.Size = new System.Drawing.Size(297, 22);
			this.tSearch.TabIndex = 6;
			this.tSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 512);
			this.Controls.Add(this.tSearch);
			this.Controls.Add(this.cSearch);
			this.Controls.Add(this.cRange);
			this.Controls.Add(this.cSort);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lGoals);
			this.Name = "MainMenu";
			this.Text = "Form1";
			this.cmsGoal.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lGoals;
		private System.Windows.Forms.ColumnHeader cName;
		private System.Windows.Forms.ColumnHeader cDes;
		private System.Windows.Forms.ColumnHeader cTags;
		private System.Windows.Forms.ColumnHeader cTime;
		private System.Windows.Forms.ColumnHeader cPriority;
		private System.Windows.Forms.ColumnHeader cFile;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cSort;
		private System.Windows.Forms.ContextMenuStrip cmsGoal;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьПрToolStripMenuItem;
		private System.Windows.Forms.ComboBox cRange;
		private System.Windows.Forms.ComboBox cSearch;
		private System.Windows.Forms.TextBox tSearch;
	}
}

