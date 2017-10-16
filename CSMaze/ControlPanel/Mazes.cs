using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze. ControlPanel
{
	class Mazes: Panel
	{
		public Mazes(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Mazes";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			ComboBox cbMazes = new ComboBox();
			cbMazes.Text = "filename";
			cbMazes.Width = 150;
			cbMazes.Height = 20;
			cbMazes.Location = new Point(x, y);
			Controls.Add(cbMazes);
			x = x + 150 + buffer;
		}
	}
}
