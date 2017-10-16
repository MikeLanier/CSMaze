using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelDisplay : Panel
	{
		public ControlPanelDisplay(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Display";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			CheckBox cbDisplay2D = new CheckBox();
			cbDisplay2D.Text = "2D";
			cbDisplay2D.Width = 60;
			cbDisplay2D.Height = 20;
			cbDisplay2D.Location = new Point(x, y);
			Controls.Add(cbDisplay2D);
			x = x + 60 + buffer;

			CheckBox cbDisplay3D = new CheckBox();
			cbDisplay3D.Text = "3D";
			cbDisplay3D.Width = 60;
			cbDisplay3D.Height = 20;
			cbDisplay3D.Location = new Point(x, y);
			Controls.Add(cbDisplay3D);
		}
	}
}

