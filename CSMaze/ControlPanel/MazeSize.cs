using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze. ControlPanel
{
	class MazeSize : Panel
	{
		public MazeSize(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Size";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			TextBox tbMazeSizeX = new TextBox();
			tbMazeSizeX.Text = GlobalData.mazeSizeX.ToString();
			tbMazeSizeX.Width = 60;
			tbMazeSizeX.Height = 20;
			tbMazeSizeX.Location = new Point(x, y);
			Controls.Add(tbMazeSizeX);
			x = x + 60 + buffer;

			Label lblLabel2 = new Label();
			lblLabel2.Text = "x";
			lblLabel2.Width = 20;
			lblLabel2.Height = 20;
			lblLabel2.Location = new Point(x, y);
			Controls.Add(lblLabel2);
			x = x + 20 + buffer;

			TextBox tbMazeSizeY = new TextBox();
			tbMazeSizeY.Text = GlobalData.mazeSizeY.ToString(); ;
			tbMazeSizeY.Width = 60;
			tbMazeSizeY.Height = 20;
			tbMazeSizeY.Location = new Point(x, y);
			Controls.Add(tbMazeSizeY);
		}
	}
}

