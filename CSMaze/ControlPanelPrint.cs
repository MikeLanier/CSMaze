using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelPrint : Panel
	{
		public ControlPanelPrint(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Button btnPrint = new Button();
			btnPrint.Text = "Print";
			btnPrint.Width = 60;
			btnPrint.Height = 20;
			btnPrint.Location = new Point(x, y);
			Controls.Add(btnPrint);
		}
	}
}

