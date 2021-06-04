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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.objectTextBox = new System.Windows.Forms.TextBox();
			this.coordinatsRadiobutton = new System.Windows.Forms.RadioButton();
			this.stopbutton = new System.Windows.Forms.Button();
			this.nameRadiobutton = new System.Windows.Forms.RadioButton();
			this.idRadiobutton = new System.Windows.Forms.RadioButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.objectTextBox);
			this.panel1.Controls.Add(this.coordinatsRadiobutton);
			this.panel1.Controls.Add(this.stopbutton);
			this.panel1.Controls.Add(this.nameRadiobutton);
			this.panel1.Controls.Add(this.idRadiobutton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(387, 156);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// objectTextBox
			// 
			this.objectTextBox.Location = new System.Drawing.Point(132, 59);
			this.objectTextBox.Name = "objectTextBox";
			this.objectTextBox.Size = new System.Drawing.Size(161, 20);
			this.objectTextBox.TabIndex = 4;
			// 
			// coordinatsRadiobutton
			// 
			this.coordinatsRadiobutton.AutoSize = true;
			this.coordinatsRadiobutton.Location = new System.Drawing.Point(13, 59);
			this.coordinatsRadiobutton.Name = "coordinatsRadiobutton";
			this.coordinatsRadiobutton.Size = new System.Drawing.Size(87, 17);
			this.coordinatsRadiobutton.TabIndex = 3;
			this.coordinatsRadiobutton.Text = "Координаты";
			this.coordinatsRadiobutton.UseVisualStyleBackColor = true;
			// 
			// stopbutton
			// 
			this.stopbutton.Location = new System.Drawing.Point(180, 13);
			this.stopbutton.Name = "stopbutton";
			this.stopbutton.Size = new System.Drawing.Size(75, 23);
			this.stopbutton.TabIndex = 2;
			this.stopbutton.Text = "Стоп";
			this.stopbutton.UseVisualStyleBackColor = true;
			this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
			// 
			// nameRadiobutton
			// 
			this.nameRadiobutton.AutoSize = true;
			this.nameRadiobutton.Location = new System.Drawing.Point(13, 35);
			this.nameRadiobutton.Name = "nameRadiobutton";
			this.nameRadiobutton.Size = new System.Drawing.Size(112, 17);
			this.nameRadiobutton.TabIndex = 1;
			this.nameRadiobutton.Text = "Записывать Имя";
			this.nameRadiobutton.UseVisualStyleBackColor = true;
			// 
			// idRadiobutton
			// 
			this.idRadiobutton.AutoSize = true;
			this.idRadiobutton.Checked = true;
			this.idRadiobutton.Location = new System.Drawing.Point(13, 13);
			this.idRadiobutton.Name = "idRadiobutton";
			this.idRadiobutton.Size = new System.Drawing.Size(101, 17);
			this.idRadiobutton.TabIndex = 0;
			this.idRadiobutton.TabStop = true;
			this.idRadiobutton.Text = "Записывать ID";
			this.idRadiobutton.UseVisualStyleBackColor = true;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 156);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Menu";
			this.Text = "Menu";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button stopbutton;
		private System.Windows.Forms.RadioButton nameRadiobutton;
		private System.Windows.Forms.RadioButton idRadiobutton;
		private System.Windows.Forms.TextBox objectTextBox;
		private System.Windows.Forms.RadioButton coordinatsRadiobutton;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}