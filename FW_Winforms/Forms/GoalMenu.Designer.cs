namespace FW_Winforms
{
	partial class GoalMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rHight = new System.Windows.Forms.RadioButton();
			this.rMedium = new System.Windows.Forms.RadioButton();
			this.rLow = new System.Windows.Forms.RadioButton();
			this.tName = new System.Windows.Forms.TextBox();
			this.tDescription = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lTags = new System.Windows.Forms.ListBox();
			this.bAdd = new System.Windows.Forms.Button();
			this.bDel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tPath = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.bShow = new System.Windows.Forms.Button();
			this.bReady = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.dtExecutionTime = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rHight);
			this.groupBox1.Controls.Add(this.rMedium);
			this.groupBox1.Controls.Add(this.rLow);
			this.groupBox1.Location = new System.Drawing.Point(14, 115);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(320, 74);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Приоритет";
			// 
			// rHight
			// 
			this.rHight.AutoSize = true;
			this.rHight.Location = new System.Drawing.Point(229, 42);
			this.rHight.Name = "rHight";
			this.rHight.Size = new System.Drawing.Size(84, 20);
			this.rHight.TabIndex = 0;
			this.rHight.TabStop = true;
			this.rHight.Text = "Высокий";
			this.rHight.UseVisualStyleBackColor = true;
			// 
			// rMedium
			// 
			this.rMedium.AutoSize = true;
			this.rMedium.Checked = true;
			this.rMedium.Location = new System.Drawing.Point(114, 42);
			this.rMedium.Name = "rMedium";
			this.rMedium.Size = new System.Drawing.Size(85, 20);
			this.rMedium.TabIndex = 0;
			this.rMedium.TabStop = true;
			this.rMedium.Text = "Средний";
			this.rMedium.UseVisualStyleBackColor = true;
			// 
			// rLow
			// 
			this.rLow.AutoSize = true;
			this.rLow.Location = new System.Drawing.Point(7, 42);
			this.rLow.Name = "rLow";
			this.rLow.Size = new System.Drawing.Size(77, 20);
			this.rLow.TabIndex = 0;
			this.rLow.TabStop = true;
			this.rLow.Text = "Низкий";
			this.rLow.UseVisualStyleBackColor = true;
			// 
			// tName
			// 
			this.tName.Location = new System.Drawing.Point(61, 22);
			this.tName.Name = "tName";
			this.tName.Size = new System.Drawing.Size(273, 22);
			this.tName.TabIndex = 2;
			// 
			// tDescription
			// 
			this.tDescription.Location = new System.Drawing.Point(12, 229);
			this.tDescription.Multiline = true;
			this.tDescription.Name = "tDescription";
			this.tDescription.Size = new System.Drawing.Size(322, 58);
			this.tDescription.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Имя:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 210);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Описание:";
			// 
			// lTags
			// 
			this.lTags.FormattingEnabled = true;
			this.lTags.ItemHeight = 16;
			this.lTags.Location = new System.Drawing.Point(12, 319);
			this.lTags.Name = "lTags";
			this.lTags.Size = new System.Drawing.Size(234, 52);
			this.lTags.TabIndex = 9;
			// 
			// bAdd
			// 
			this.bAdd.Location = new System.Drawing.Point(252, 319);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(82, 23);
			this.bAdd.TabIndex = 10;
			this.bAdd.Text = "Добавить";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bDel
			// 
			this.bDel.Location = new System.Drawing.Point(252, 348);
			this.bDel.Name = "bDel";
			this.bDel.Size = new System.Drawing.Size(82, 23);
			this.bDel.TabIndex = 10;
			this.bDel.Text = "Удалить";
			this.bDel.UseVisualStyleBackColor = true;
			this.bDel.Click += new System.EventHandler(this.bDel_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 300);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Теги:";
			// 
			// tPath
			// 
			this.tPath.Location = new System.Drawing.Point(12, 402);
			this.tPath.Name = "tPath";
			this.tPath.Size = new System.Drawing.Size(234, 22);
			this.tPath.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 383);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(154, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "Прикрепленный файл:";
			// 
			// bShow
			// 
			this.bShow.Location = new System.Drawing.Point(252, 402);
			this.bShow.Name = "bShow";
			this.bShow.Size = new System.Drawing.Size(82, 23);
			this.bShow.TabIndex = 10;
			this.bShow.Text = "Указать";
			this.bShow.UseVisualStyleBackColor = true;
			this.bShow.Click += new System.EventHandler(this.button3_Click);
			// 
			// bReady
			// 
			this.bReady.Location = new System.Drawing.Point(182, 448);
			this.bReady.Name = "bReady";
			this.bReady.Size = new System.Drawing.Size(152, 35);
			this.bReady.TabIndex = 10;
			this.bReady.Text = "Готово";
			this.bReady.UseVisualStyleBackColor = true;
			this.bReady.Click += new System.EventHandler(this.bReady_Click);
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(12, 448);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(154, 35);
			this.bCancel.TabIndex = 10;
			this.bCancel.Text = "Отменить";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// dtExecutionTime
			// 
			this.dtExecutionTime.Location = new System.Drawing.Point(92, 73);
			this.dtExecutionTime.Name = "dtExecutionTime";
			this.dtExecutionTime.Size = new System.Drawing.Size(242, 22);
			this.dtExecutionTime.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Дедлайн:";
			// 
			// GoalMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 499);
			this.Controls.Add(this.dtExecutionTime);
			this.Controls.Add(this.tPath);
			this.Controls.Add(this.bDel);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bReady);
			this.Controls.Add(this.bShow);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.lTags);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tDescription);
			this.Controls.Add(this.tName);
			this.Controls.Add(this.groupBox1);
			this.Name = "GoalMenu";
			this.Text = "NewGoal";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoalMenu_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rHight;
		private System.Windows.Forms.RadioButton rMedium;
		private System.Windows.Forms.RadioButton rLow;
		private System.Windows.Forms.TextBox tName;
		private System.Windows.Forms.TextBox tDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox lTags;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bDel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tPath;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button bShow;
		private System.Windows.Forms.Button bReady;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.DateTimePicker dtExecutionTime;
		private System.Windows.Forms.Label label2;
	}
}