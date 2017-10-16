using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMaze
{
	class GlobalData
	{
		public static int mazeSizeX = 10;
		public static int mazeSizeY = 10;
		public static int cellSize = 25;

		public static int controlPanelWidth = 300;
		public static int controlPanelHeight = 1500;

		public static ControlPanel controlPanel = null;
		public static DisplayPanel displayPanel = null;

		public GlobalData()
		{

		}

		public static int ID(int xOrigin, int yOrigin, bool horizontal)
		{
			int h = (horizontal) ? 0x40000000 : 0;

			return (xOrigin & 0x7fff) |
					(yOrigin & 0x7fff) << 15 |
					h;
		}
	}
}
