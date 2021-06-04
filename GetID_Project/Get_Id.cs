using System.Drawing;
using System.Windows.Automation;
using System.Windows.Forms;

namespace GetID
{
	class Get_Id
	{
		public static string Get_Id_FromCursor()
		{
			string AutoId_String = "";
			// Convert mouse position from System.Drawing.Point to System.Windows.Point.
			Point position = Control.MousePosition;
			System.Windows.Point point = new System.Windows.Point(position.X, position.Y);
			AutomationElement element = AutomationElement.FromPoint(point);
			object Auto_Id_NoDefault = element.GetCurrentPropertyValue(AutomationElement.AutomationIdProperty, true);
			if (Auto_Id_NoDefault == AutomationElement.NotSupported)
			{
				// TODO Handle the case where you do not wish to proceed using the default value.
			}
			else
			{
				AutoId_String = Auto_Id_NoDefault as string;
			}
			return AutoId_String;
		}
	}
}
