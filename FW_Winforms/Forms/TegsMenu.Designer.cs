namespace FW_Winforms
{
	partial class TegsMenu
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
			this.bAdd = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.tTegNeme = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bAdd
			// 
			this.bAdd.Location = new System.Drawing.Point(93, 40);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(75, 23);
			this.bAdd.TabIndex = 0;
			this.bAdd.Text = "Добавть";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bCancel
			// 
			this.bCancel.Location = new System.Drawing.Point(12, 40);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 23);
			this.bCancel.TabIndex = 0;
			this.bCancel.Text = "Отмена";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// tTegNeme
			// 
			this.tTegNeme.Location = new System.Drawing.Point(12, 12);
			this.tTegNeme.Name = "tTegNeme";
			this.tTegNeme.Size = new System.Drawing.Size(156, 22);
			this.tTegNeme.TabIndex = 1;
			// 
			// Tegs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(185, 75);
			this.Controls.Add(this.tTegNeme);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bAdd);
			this.Name = "Tegs";
			this.Text = "Tegs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.TextBox tTegNeme;
	}
}