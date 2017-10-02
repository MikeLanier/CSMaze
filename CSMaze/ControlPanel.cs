using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	class ControlPanel: Panel
	{
		public ControlPanel()
		{
			Width = 300;
			Height = 1300;

			int xOffset = 10;
			int yOffset = 10;

			int x = xOffset;
			int y = yOffset;

			int buffer = 5;

			int width = 300;
			int height = 25;

			Controls.Add(new ControlPanelLoad(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new ControlPanelSave(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new ControlPanelMazes(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new ControlPanelAlgorithms(x, y, width, height, buffer));
			y = y + height + buffer;

		}
	}
}
