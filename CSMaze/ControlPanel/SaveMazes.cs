using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze. ControlPanel
{
	class SaveMazes: Panel
	{
		public SaveMazes(int xOrigin, int yOrigin, int width, int height, int buffer)
		{
			Width = width;
			Height = height;
			Location = new Point(xOrigin, yOrigin);

			int y = 0;
			int x = 0;

			Button btnSave = new Button();
			btnSave.Text = "Save";
			btnSave.Width = 60;
			btnSave.Height = 20;
			btnSave.Location = new Point(x, y);
			Controls.Add(btnSave);
			x = x + 60 + buffer;

			TextBox tbSaveFilename = new TextBox();
			tbSaveFilename.Text = "filename";
			tbSaveFilename.Width = 150;
			tbSaveFilename.Height = 20;
			tbSaveFilename.Location = new Point(x, y);
			Controls.Add(tbSaveFilename);
			x = x + 150 + buffer;

			Button btnSaveFileDialog = new Button();
			btnSaveFileDialog.Text = "?";
			btnSaveFileDialog.Width = 20;
			btnSaveFileDialog.Height = 20;
			btnSaveFileDialog.Location = new Point(x, y);
			Controls.Add(btnSaveFileDialog);
		}
	}
}
