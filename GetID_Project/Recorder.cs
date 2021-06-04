using System;
using System.Windows.Forms;
using Hooks;
using GetID;
using GetName;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;

namespace GetID_Project
{
	public partial class Recorder : Form
	{


		private bool Pressed_Start_Button = false;
		private static string Parametr = "";
		private static string Path = @"C:\\Test.txt";
		bool Drag_N_Drop = false;
		private int Current_Down_LocationX;
		private int Current_Down_LocationY;
		private int Current_Up_LocationX;
		private int Current_Up_LocationY;
		private int Previous_Up_LocationX;
		private int Previous_Up_LocationY;
		Radiobutton_State State_Pararmetr = new Radiobutton_State();

		
		public static string Get_Paremetr
		{
			get { return Parametr; }
			set { }
		}

		public static string Get_Path
		{
			get { return Path; }
			set { }
		}

		private void Install_Mode()
		{
			if (id_radioButton.Checked)
			{
				State_Pararmetr = Radiobutton_State.Id_Radiobutton_Pressed;
			}
			else
			{
				State_Pararmetr = Radiobutton_State.Name_Radiobutton_Pressed;
			} 
		}


		public Recorder()
		{
			InitializeComponent();
			this.FormClosed += new FormClosedEventHandler(Recorder_FormClosed);
			MouseHook.MouseDown += new MouseEventHandler(MouseHook_MouseDown);
			MouseHook.MouseMove += new MouseEventHandler(MouseHook_MouseMove);
			MouseHook.MouseUp += new MouseEventHandler(MouseHook_MouseUp);
			MouseHook.LocalHook = false;
			MouseHook.InstallHook();
		}

		void MouseHook_MouseMove(object sender, MouseEventArgs e)
		{
			//listBox1.Items.Add(e.Location);
			//listBox1.SelectedIndex = listBox1.Items.Count - 1;

			//TODO

			toolTip1.Show(Convert.ToString(e.Location), panel1, e.Location.X, e.Location.Y, 5000);
		}

		void MouseHook_MouseUp(object sender, MouseEventArgs e)
		{
			Previous_Up_LocationX = Current_Up_LocationX;
			Previous_Up_LocationY = Current_Up_LocationY;
			Current_Up_LocationX = e.Location.X;
			Current_Up_LocationY = e.Location.Y;

			if (Current_Up_LocationX != Current_Down_LocationX && Current_Up_LocationY != Current_Down_LocationY)
			{
				Drag_N_Drop = true;
			}
			else
			{
				Drag_N_Drop = false;
			}

			Form Is_Oppened_Menu = Application.OpenForms["Menu"];
			Install_Mode();
	
			if (e.Button == MouseButtons.Left && Pressed_Start_Button && Is_Oppened_Menu == null && !Drag_N_Drop)
			{
				Menu menu = new Menu(e.Location.X+5, e.Location.Y+5,Previous_Up_LocationX, Previous_Up_LocationY, State_Pararmetr);

				

				if (Is_Oppened_Menu != null && menu.Is_Menu_Pressed())
				{
					Is_Oppened_Menu.Close();
					menu.Set_Menu_Pressed_False();
				}

				if (id_radioButton.Checked)
				{
					Parametr = Get_Id.Get_Id_FromCursor();
				}
				if (name_radioButton.Checked)
				{
					Parametr = Get_Name.Get_Name_FromCursor();
				}

				menu.Show();
				
			}
			if (e.Button == MouseButtons.Right)
			{
				File.AppendAllText(Path, "action.context_click().perform()\n");
			}
			if (Drag_N_Drop)
			{
				//TODO
			}
		}

		void MouseHook_MouseDown(object sender, MouseEventArgs e)
		{
			Current_Down_LocationX = e.Location.X;
			Current_Down_LocationY = e.Location.Y;

		}

		private void Recorder_FormClosed(object sender, FormClosedEventArgs e)
		{
			MouseHook.UnInstallHook(); // Обязательно !!!
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//textBox1.Text = GetElementFromCursor();
			//textBox1.Text = GetElement.GetElementFromCursor();

			//TODO
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			Pressed_Start_Button = true;
		}

		private void path_button_MouseUp(object sender, MouseEventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Path = openFileDialog1.FileName;
				//TODO Доступ к файлам, создать файл
			}
		}
	}

	public enum Radiobutton_State
	{
		Id_Radiobutton_Pressed = 1,
		Name_Radiobutton_Pressed = 2
	}
}


