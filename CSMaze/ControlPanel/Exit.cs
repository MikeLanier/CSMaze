using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze. ControlPanel
{
	class Exit : Panel
	{
		public Exit(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Exit";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			ComboBox cbExitX = new ComboBox();
			cbExitX.Text = "512";
			cbExitX.Width = 60;
			cbExitX.Height = 20;
			cbExitX.Location = new Point(x, y);
			Controls.Add(cbExitX);
			x = x + 60 + buffer;

			Label lblLabel2 = new Label();
			lblLabel2.Text = "x";
			lblLabel2.Width = 20;
			lblLabel2.Height = 20;
			lblLabel2.Location = new Point(x, y);
			Controls.Add(lblLabel2);
			x = x + 20 + buffer;

			ComboBox cbExitY = new ComboBox();
			cbExitY.Text = "512";
			cbExitY.Width = 60;
			cbExitY.Height = 20;
			cbExitY.Location = new Point(x, y);
			Controls.Add(cbExitY);
			x = x + 60 + buffer;

			Button btnSelectExit = new Button();
			btnSelectExit.Text = "?";
			btnSelectExit.Width = 20;
			btnSelectExit.Height = 20;
			btnSelectExit.Location = new Point(x, y);
			Controls.Add(btnSelectExit);
		}
	}
}
