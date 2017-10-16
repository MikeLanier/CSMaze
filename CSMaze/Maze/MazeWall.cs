using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSMaze
{
	class MazeWall
	{
		private int xOrigin = 0;
		private int yOrigin = 0;
		private bool horizontal = true;
		private bool open = false;
		private bool door = false;
		private Color closedColor = Color.Black;

		//	public void ClosedColor(Color _closedColor) { closedColor = _closedColor; }

		public void Open(bool _open)
		{
			open = _open;
		}
		public bool Open()
		{
			return open;
		}

		public void setDoor()
		{
			door = true;
		}
		public bool Door()
		{
			return door;
		}

		public MazeWall(int _xOrigin, int _yOrigin, bool _horizontal)
		{
			xOrigin = _xOrigin;
			yOrigin = _yOrigin;
			horizontal = _horizontal;
		}

		public int ID()
		{
			return GlobalData.ID(xOrigin, yOrigin, horizontal);
		}

		public void draw(Graphics gc, int xOffset, int yOffset, int cellSize)
		{
			int x = (xOffset + xOrigin * cellSize);
			int y = (yOffset + yOrigin * cellSize);

			Pen pen = null;
			//gc.setLineDashes(0);
			//gc.setLineWidth(1);

			if (open)
				if (door)
				{
					pen = new Pen(Brushes.Red);
				}
				else
				{
					pen = new Pen(Color.White);
				}
			else
			{
				pen = new Pen(Color.Black);
			}

			if (horizontal)
			{
				Point p1 = new Point(x, y);
				Point p2 = new Point(x + cellSize, y);
				gc.DrawLine(pen, p1, p2);
			}
			else
			{
				Point p1 = new Point(x, y);
				Point p2 = new Point(x, y + cellSize);
				gc.DrawLine(pen, p1, p2);
			}
		}
	}
}
