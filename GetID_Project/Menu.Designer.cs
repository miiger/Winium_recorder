namespace GetID_Project
{
	partial class Menu
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
			if (disposing && (components != null))
			{
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.parametr_button = new System.Windows.Forms.Button();
			this.coordinats_button = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.parametr_button);
			this.panel1.Controls.Add(this.coordinats_button);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(165, 64);
			this.panel1.TabIndex = 0;
			// 
			// parametr_button
			// 
			this.parametr_button.Location = new System.Drawing.Point(31, 32);
			this.parametr_button.Name = "parametr_button";
			this.parametr_button.Size = new System.Drawing.Size(97, 23);
			this.parametr_button.TabIndex = 1;
			this.parametr_button.Text = "Параметр";
			this.parametr_button.UseVisualStyleBackColor = true;
			this.parametr_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.parametr_button_MouseUp);
			// 
			// coordinats_button
			// 
			this.coordinats_button.Enabled = false;
			this.coordinats_button.Location = new System.Drawing.Point(31, 3);
			this.coordinats_button.Name = "coordinats_button";
			this.coordinats_button.Size = new System.Drawing.Size(97, 23);
			this.coordinats_button.TabIndex = 0;
			this.coordinats_button.Text = "Координаты";
			this.coordinats_button.UseVisualStyleBackColor = true;
			this.coordinats_button.Click += new System.EventHandler(this.coordinats_button_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(165, 64);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Menu";
			this.Text = "Menu";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button parametr_button;
		private System.Windows.Forms.Button coordinats_button;
	}
}