using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelCreateRoom : Panel
	{
		public ControlPanelCreateRoom(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height * 4;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Create Room";
			lblLabel.Width = 90;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);

			y = y + 25 + buffer;
			x = x + 15 + buffer;

			Label lblLabel1 = new Label();
			lblLabel1.Text = "Origin";
			lblLabel1.Width = 35;
			lblLabel1.Height = 20;
			lblLabel1.Location = new Point(x, y);
			Controls.Add(lblLabel1);
			x = x + 35 + buffer;

			Label lblLabel2 = new Label();
			lblLabel2.Text = "X";
			lblLabel2.Width = 15;
			lblLabel2.Height = 20;
			lblLabel2.Location = new Point(x, y);
			Controls.Add(lblLabel2);
			x = x + 15 + buffer;

			TextBox tbRoomOriginX = new TextBox();
			tbRoomOriginX.Text = "512";
			tbRoomOriginX.Width = 40;
			tbRoomOriginX.Height = 20;
			tbRoomOriginX.Location = new Point(x, y);
			Controls.Add(tbRoomOriginX);
			x = x + 40 + buffer;

			Label lblLabel3 = new Label();
			lblLabel3.Text = "Y";
			lblLabel3.Width = 15;
			lblLabel3.Height = 20;
			lblLabel3.Location = new Point(x, y);
			Controls.Add(lblLabel3);
			x = x + 15 + buffer;

			TextBox tbRoomOriginY = new TextBox();
			tbRoomOriginY.Text = "512";
			tbRoomOriginY.Width = 40;
			tbRoomOriginY.Height = 20;
			tbRoomOriginY.Location = new Point(x, y);
			Controls.Add(tbRoomOriginY);

			y = y + 25 + buffer;
			x = 15 + buffer;

			Label lblLabel4 = new Label();
			lblLabel4.Text = "Size";
			lblLabel4.Width = 35;
			lblLabel4.Height = 20;
			lblLabel4.Location = new Point(x, y);
			Controls.Add(lblLabel4);
			x = x + 35 + buffer;

			Label lblLabel5 = new Label();
			lblLabel5.Text = "W";
			lblLabel5.Width = 15;
			lblLabel5.Height = 20;
			lblLabel5.Location = new Point(x, y);
			Controls.Add(lblLabel5);
			x = x + 15 + buffer;

			TextBox tbRoomSizeX = new TextBox();
			tbRoomSizeX.Text = "512";
			tbRoomSizeX.Width = 40;
			tbRoomSizeX.Height = 20;
			tbRoomSizeX.Location = new Point(x, y);
			Controls.Add(tbRoomSizeX);
			x = x + 40 + buffer;

			Label lblLabel6 = new Label();
			lblLabel6.Text = "H";
			lblLabel6.Width = 15;
			lblLabel6.Height = 20;
			lblLabel6.Location = new Point(x, y);
			Controls.Add(lblLabel6);
			x = x + 15 + buffer;

			TextBox tbRoomSizeY = new TextBox();
			tbRoomSizeY.Text = "512";
			tbRoomSizeY.Width = 40;
			tbRoomSizeY.Height = 20;
			tbRoomSizeY.Location = new Point(x, y);
			Controls.Add(tbRoomSizeY);
		}
	}
}
