using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelSolve : Panel
	{
		public ControlPanelSolve(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Button btnSolve = new Button();
			btnSolve.Text = "Solve";
			btnSolve.Width = 60;
			btnSolve.Height = 20;
			btnSolve.Location = new Point(x, y);
			Controls.Add(btnSolve);
		}
	}
}
