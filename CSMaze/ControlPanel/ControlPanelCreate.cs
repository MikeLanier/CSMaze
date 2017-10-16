using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelCreate : Panel
	{
		public ControlPanelCreate(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Button btnCreate = new Button();
			btnCreate.Text = "Create";
			btnCreate.Width = 60;
			btnCreate.Height = 20;
			btnCreate.Location = new Point(x, y);
			Controls.Add(btnCreate);
			x = x + 60 + buffer;

			Button btnAnimateCreate = new Button();
			btnAnimateCreate.Text = "Animate Create";
			btnAnimateCreate.Width = 60;
			btnAnimateCreate.Height = 20;
			btnAnimateCreate.Location = new Point(x, y);
			Controls.Add(btnAnimateCreate);
		}
	}
}
