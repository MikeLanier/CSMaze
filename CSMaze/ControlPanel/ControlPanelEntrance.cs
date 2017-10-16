using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelEntrance : Panel
	{
		public ControlPanelEntrance(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Label lblLabel = new Label();
			lblLabel.Text = "Entrance";
			lblLabel.Width = 60;
			lblLabel.Height = 20;
			lblLabel.Location = new Point(x, y);
			Controls.Add(lblLabel);
			x = x + 60 + buffer;

			ComboBox cbEntranceX = new ComboBox();
			cbEntranceX.Text = "512";
			cbEntranceX.Width = 60;
			cbEntranceX.Height = 20;
			cbEntranceX.Location = new Point(x, y);
			Controls.Add(cbEntranceX);
			x = x + 60 + buffer;

			Label lblLabel2 = new Label();
			lblLabel2.Text = "x";
			lblLabel2.Width = 20;
			lblLabel2.Height = 20;
			lblLabel2.Location = new Point(x, y);
			Controls.Add(lblLabel2);
			x = x + 20 + buffer;

			ComboBox cbEntranceY = new ComboBox();
			cbEntranceY.Text = "512";
			cbEntranceY.Width = 60;
			cbEntranceY.Height = 20;
			cbEntranceY.Location = new Point(x, y);
			Controls.Add(cbEntranceY);
			x = x + 60 + buffer;

			Button btnSelectEntrance = new Button();
			btnSelectEntrance.Text = "?";
			btnSelectEntrance.Width = 20;
			btnSelectEntrance.Height = 20;
			btnSelectEntrance.Location = new Point(x, y);
			Controls.Add(btnSelectEntrance);
		}
	}
}



