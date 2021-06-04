using System;
using System.Windows.Forms;
using System.IO;

namespace GetID_Project
{
	public partial class Menu : Form
	{

		private Radiobutton_State Parametr_State; 
		private bool Menu_Pressed = false;
        private int Start_LocationX;
        private int Start_LocationY;
		private int Previous_LocationX;
		private int Previous_LocationY;
		private string parametr;

		public bool Is_Menu_Pressed()
		{
            return Menu_Pressed;
		}

        public void Set_Menu_Pressed_False()
        {
            this.Menu_Pressed = false;
        }

        public Menu()
		{
			InitializeComponent();
		}

        public Menu(int x, int y, int Prev_X, int Prev_Y, Radiobutton_State State)
               : this()
        {
            // here store the value for x & y into instance variables
            TopMost = true;
            this.Start_LocationX = x;
            this.Start_LocationY = y;
			this.Parametr_State = State;
			this.Previous_LocationX = Prev_X;
			this.Previous_LocationY = Prev_Y;
            Load += new EventHandler(Menu_Load);

			if (Recorder.Get_Paremetr != "")
			{
				coordinats_button.Enabled = true;
			}

			

		}

        private void Menu_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(Start_LocationX, Start_LocationY);
        }

        private void coordinats_button_Click(object sender, EventArgs e)
		{
			Menu_Pressed = true;
			File.AppendAllText(Recorder.Get_Path, "action.move_by_offset(");
			File.AppendAllText(Recorder.Get_Path, Convert.ToString(Previous_LocationY - Start_LocationY));
			File.AppendAllText(Recorder.Get_Path, ", "); 
			File.AppendAllText(Recorder.Get_Path, Convert.ToString(Previous_LocationX - Start_LocationX));
			File.AppendAllText(Recorder.Get_Path, ").click().perform()");
			File.AppendAllText(Recorder.Get_Path, "\n");
			this.Close();
		}

		private void parametr_button_MouseUp(object sender, MouseEventArgs e)
		{
            
			if (Parametr_State == Radiobutton_State.Name_Radiobutton_Pressed)
			{
				Menu_Pressed = true;
				File.AppendAllText(Recorder.Get_Path, "driver.find_element_by_name(\"");
				File.AppendAllText(Recorder.Get_Path, Recorder.Get_Paremetr);
				File.AppendAllText(Recorder.Get_Path, "\").click()");
				File.AppendAllText(Recorder.Get_Path, "\n");
				this.Close();
			}

			if (Parametr_State == Radiobutton_State.Id_Radiobutton_Pressed)
			{
				Menu_Pressed = true;
				File.AppendAllText(Recorder.Get_Path, "driver.find_element_by_Id(\"");
				File.AppendAllText(Recorder.Get_Path, Recorder.Get_Paremetr);
				File.AppendAllText(Recorder.Get_Path, "\").click()");
				File.AppendAllText(Recorder.Get_Path, "\n");
				this.Close();
			}
		}
    }
}
