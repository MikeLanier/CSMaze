using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelCellSize : Panel
	{
		public ControlPanelCellSize(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Cell Size";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			TextBox tbMazeSizeX = new TextBox();
			tbMazeSizeX.Text = GlobalData.cellSize.ToString();
			tbMazeSizeX.Width = 60;
			tbMazeSizeX.Height = 20;
			tbMazeSizeX.Location = new Point(x, y);
			Controls.Add(tbMazeSizeX);
		}
	}
}
