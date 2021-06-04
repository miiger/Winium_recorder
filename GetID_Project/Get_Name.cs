using System.Drawing;
using System.Windows.Automation;
using System.Windows.Forms;

namespace GetName
{
	class Get_Name
	{
		public static string Get_Name_FromCursor()
		{
			string Name_String = "";
			// Convert mouse position from System.Drawing.Point to System.Windows.Point.
			Point position = Control.MousePosition;
			System.Windows.Point point = new System.Windows.Point(position.X, position.Y);
			AutomationElement element = AutomationElement.FromPoint(point);
			object Name_No_Default = element.GetCurrentPropertyValue(AutomationElement.NameProperty, true);
			if (Name_No_Default == AutomationElement.NotSupported)
			{
				// TODO Handle the case where you do not wish to proceed using the default value.
			}
			else
			{
				Name_String = Name_No_Default as string;
			}
			return Name_String;
		}
	}
}