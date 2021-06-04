using System;
using System.Windows.Forms;
using System.IO;
using Hooks;
using GetID;
using GetName;

namespace GetID_Project
{
	public partial class Menu : Form
	{

		private static string Path = @"C:\\Test.txt";
		bool Drag_N_Drop = false;
		private int _current_Down_LocationX;
		private int _current_Down_LocationY;
		private int _current_Up_LocationX;
		private int _current_Up_LocationY;
		private bool _isStopPressed = false;
		private int _previous_Up_LocationX;
		private int _previous_Up_LocationY;
		private string _object = "";
		private bool _isObject = false;
		

        public Menu()
		{
			InitializeComponent();
			TopMost = true;
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
			_previous_Up_LocationX = _current_Up_LocationX;
			_previous_Up_LocationY = _current_Up_LocationY;
			_current_Up_LocationX = e.Location.X;
			_current_Up_LocationY = e.Location.Y;

			if (_current_Up_LocationX != _current_Down_LocationX && _current_Up_LocationY != _current_Down_LocationY)
			{
				Drag_N_Drop = true;
			}
			else
			{
				Drag_N_Drop = false;
			}

			Form Is_Oppened_Menu = Application.OpenForms["Menu"];
			

			if (e.Button == MouseButtons.Left && !Drag_N_Drop && nameRadiobutton.Checked && !_isStopPressed
				&& (this.Left > e.Location.X || this.Right < e.Location.X)
				&& (this.Top > e.Location.Y || this.Bottom < e.Location.Y))
			{
				string nameObject = Get_Name.Get_Name_FromCursor();
				File.AppendAllText(Recorder.Get_Path, "driver.find_element_by_name(\"");
				File.AppendAllText(Recorder.Get_Path, nameObject);
				File.AppendAllText(Recorder.Get_Path, "\").click()");
				File.AppendAllText(Recorder.Get_Path, "\n");

				if (nameObject != "")
				{
					_object = nameObject;
					_isObject = true;

				}
			}

			if (e.Button == MouseButtons.Left && !Drag_N_Drop && idRadiobutton.Checked && !_isStopPressed
				&& (this.Left > e.Location.X || this.Right < e.Location.X)
				&& (this.Top > e.Location.Y || this.Bottom < e.Location.Y))
			{
				string idObject = Get_Id.Get_Id_FromCursor();
				File.AppendAllText(Recorder.Get_Path, "driver.find_element_by_name(\"");
				File.AppendAllText(Recorder.Get_Path, idObject);
				File.AppendAllText(Recorder.Get_Path, "\").click()");
				File.AppendAllText(Recorder.Get_Path, "\n");

				if (idObject != "")
				{
					_object = Get_Id.Get_Id_FromCursor();
					_isObject = true;
				}
			}

			if (e.Button == MouseButtons.Left && !Drag_N_Drop && coordinatsRadiobutton.Checked && !_isStopPressed
				&& (this.Left > e.Location.X || this.Right < e.Location.X)
				&& (this.Top > e.Location.Y || this.Bottom < e.Location.Y && _isObject))
			{
				File.AppendAllText(Recorder.Get_Path, "action.move_by_offset(");
				File.AppendAllText(Recorder.Get_Path, Convert.ToString(_previous_Up_LocationY - _current_Up_LocationY));
				File.AppendAllText(Recorder.Get_Path, ", ");
				File.AppendAllText(Recorder.Get_Path, Convert.ToString(_previous_Up_LocationX - _current_Up_LocationX));
				File.AppendAllText(Recorder.Get_Path, ").click().perform()");
				File.AppendAllText(Recorder.Get_Path, "\n");
			}

			if (e.Button == MouseButtons.Right)
			{
				File.AppendAllText(Path, "action.context_click().perform()\n");
			}
			if (Drag_N_Drop)
			{
				//TODOO
			}
		}

		void MouseHook_MouseDown(object sender, MouseEventArgs e)
		{
			_current_Down_LocationX = e.Location.X;
			_current_Down_LocationY = e.Location.Y;

		}

		private void Recorder_FormClosed(object sender, FormClosedEventArgs e)
		{
			MouseHook.UnInstallHook(); // Обязательно !!!
		}


        private void Menu_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(1400, 70);
        }

		private void parametr_button_MouseUp(object sender, MouseEventArgs e)
		{
            
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void stopbutton_Click(object sender, EventArgs e)
		{
			_isStopPressed= true;
			this.Hide();
			

		}
	}
}
