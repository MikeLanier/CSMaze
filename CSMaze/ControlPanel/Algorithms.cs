using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze. ControlPanel
{
	class Algorithms: Panel
	{
		public Algorithms(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Algorithms";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			ComboBox cbAlgorithms = new ComboBox();
			cbAlgorithms.Text = "algorithm";
			cbAlgorithms.Width = 150;
			cbAlgorithms.Height = 20;
			cbAlgorithms.Location = new Point(x, y);
			Controls.Add(cbAlgorithms);
			x = x + 150 + buffer;
		}
	}
}
