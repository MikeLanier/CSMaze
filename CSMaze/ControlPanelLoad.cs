using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanelLoad: Panel
	{
		public ControlPanelLoad(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Button btnLoad = new Button();
			btnLoad.Text = "Load";
			btnLoad.Width = 60;
			btnLoad.Height = 20;
			btnLoad.Location = new Point(x, y);
			Controls.Add(btnLoad);
			x = x + 60 + buffer;

			TextBox tbLoadFilename = new TextBox();
			tbLoadFilename.Text = "filename";
			tbLoadFilename.Width = 150;
			tbLoadFilename.Height = 20;
			tbLoadFilename.Location = new Point(x, y);
			Controls.Add(tbLoadFilename);
			x = x + 150 + buffer;

			Button btnLoadFileDialog = new Button();
			btnLoadFileDialog.Text = "?";
			btnLoadFileDialog.Width = 20;
			btnLoadFileDialog.Height = 20;
			btnLoadFileDialog.Location = new Point(x, y);
			Controls.Add(btnLoadFileDialog);
		}
	}
}
