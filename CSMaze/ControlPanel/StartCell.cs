using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze. ControlPanel
{
	class StartCell : Panel
	{
		public StartCell(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Start Cell";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			TextBox tbStartCellX = new TextBox();
			tbStartCellX.Text = "512";
			tbStartCellX.Width = 60;
			tbStartCellX.Height = 20;
			tbStartCellX.Location = new Point(x, y);
			Controls.Add(tbStartCellX);
			x = x + 60 + buffer;

			Label lblLabel2 = new Label();
			lblLabel2.Text = "x";
			lblLabel2.Width = 20;
			lblLabel2.Height = 20;
			lblLabel2.Location = new Point(x, y);
			Controls.Add(lblLabel2);
			x = x + 20 + buffer;

			TextBox tbStartCellY = new TextBox();
			tbStartCellY.Text = "512";
			tbStartCellY.Width = 60;
			tbStartCellY.Height = 20;
			tbStartCellY.Location = new Point(x, y);
			Controls.Add(tbStartCellY);
			x = x + 60 + buffer;

			Button btnSelectStartCell = new Button();
			btnSelectStartCell.Text = "?";
			btnSelectStartCell.Width = 20;
			btnSelectStartCell.Height = 20;
			btnSelectStartCell.Location = new Point(x, y);
			Controls.Add(btnSelectStartCell);
		}
	}
}


