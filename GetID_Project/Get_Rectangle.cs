using System.Drawing;
using System.Windows.Automation;
using System.Windows.Forms;


namespace GetRectangle
{
	class Get_Rectangle
	{
		public static System.Windows.Rect Get_Rectangle_FromCursor()
		{
			string AutoRectangle_String = "";// TODO
			// Convert mouse position from System.Drawing.Point to System.Windows.Point.
			Point position = Control.MousePosition;
			System.Windows.Point point = new System.Windows.Point(position.X, position.Y);
			AutomationElement element = AutomationElement.FromPoint(point);
			object Auto_Rectangle_NoDefault = element.GetCurrentPropertyValue(AutomationElement.BoundingRectangleProperty, true);
			if (Auto_Rectangle_NoDefault == AutomationElement.NotSupported)
			{
				// TODO Handle the case where you do not wish to proceed using the default value.
			}
			else
			{
				//TODO
			}
			
			return (System.Windows.Rect)Auto_Rectangle_NoDefault;
		}
	}
}
