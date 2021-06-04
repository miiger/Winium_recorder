namespace GetID_Project
{
	partial class Recorder
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.id_radioButton = new System.Windows.Forms.RadioButton();
			this.name_radioButton = new System.Windows.Forms.RadioButton();
			this.start_button = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.path_button = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(224, 140);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(360, 101);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.path_button);
			this.panel1.Controls.Add(this.id_radioButton);
			this.panel1.Controls.Add(this.name_radioButton);
			this.panel1.Controls.Add(this.start_button);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 450);
			this.panel1.TabIndex = 2;
			// 
			// id_radioButton
			// 
			this.id_radioButton.AutoSize = true;
			this.id_radioButton.Location = new System.Drawing.Point(108, 53);
			this.id_radioButton.Name = "id_radioButton";
			this.id_radioButton.Size = new System.Drawing.Size(100, 17);
			this.id_radioButton.TabIndex = 5;
			this.id_radioButton.Text = "Параметр \"ID\"";
			this.id_radioButton.UseVisualStyleBackColor = true;
			// 
			// name_radioButton
			// 
			this.name_radioButton.AutoSize = true;
			this.name_radioButton.Checked = true;
			this.name_radioButton.Location = new System.Drawing.Point(108, 29);
			this.name_radioButton.Name = "name_radioButton";
			this.name_radioButton.Size = new System.Drawing.Size(105, 17);
			this.name_radioButton.TabIndex = 4;
			this.name_radioButton.TabStop = true;
			this.name_radioButton.Text = "Парметр \"Имя\"";
			this.name_radioButton.UseVisualStyleBackColor = true;
			// 
			// start_button
			// 
			this.start_button.Location = new System.Drawing.Point(356, 350);
			this.start_button.Name = "start_button";
			this.start_button.Size = new System.Drawing.Size(75, 23);
			this.start_button.TabIndex = 3;
			this.start_button.Text = "Start";
			this.start_button.UseVisualStyleBackColor = true;
			this.start_button.Click += new System.EventHandler(this.button1_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.ShowAlways = true;
			// 
			// path_button
			// 
			this.path_button.Location = new System.Drawing.Point(301, 29);
			this.path_button.Name = "path_button";
			this.path_button.Size = new System.Drawing.Size(195, 23);
			this.path_button.TabIndex = 6;
			this.path_button.Text = "Выбрать путь для скрипта";
			this.path_button.UseVisualStyleBackColor = true;
			this.path_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.path_button_MouseUp);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Recorder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Recorder";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button start_button;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.RadioButton id_radioButton;
		private System.Windows.Forms.RadioButton name_radioButton;
		private System.Windows.Forms.Button path_button;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

