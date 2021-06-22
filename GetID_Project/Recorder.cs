using System;
using System.Windows.Forms;

namespace GetID_Project
{
	public partial class Recorder : Form
	{
		private static string Path = @"C:\\Test.txt";

		public static string Get_Path
		{
			get { return Path; }
			set { }
		}


		private void Install_Mode()
		{
	
		}


		public Recorder()
		{
			InitializeComponent();
		}

		void MouseHook_MouseMove(object sender, MouseEventArgs e)
		{
			//listBox1.Items.Add(e.Location);
			//listBox1.SelectedIndex = listBox1.Items.Count - 1;

			//TODO
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//textBox1.Text = GetElementFromCursor();
			//textBox1.Text = GetElement.GetElementFromCursor();

			//TODO
		}

		//calling the recording window
		private void button1_Click(object sender, EventArgs e)
		{
			Menu menu = new Menu();
			this.WindowState = FormWindowState.Minimized;
			menu.Show();
		}

		//recording the save path
		private void path_button_MouseUp(object sender, MouseEventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Path = openFileDialog1.FileName;
				//TODO Доступ к файлам, создать файл
			}
		}
	}

}


