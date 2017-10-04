using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CSMaze
{
	class DisplayPanel : Panel
	{
		private Dictionary<int, MazeWall> walls = new Dictionary<int, MazeWall>();

		public DisplayPanel()
		{
			for(int x=0; x<=10; x++)
				for(int y=0; y<=10; y++)
				{
					if (x != 10)
					{
						MazeWall wall = new MazeWall(x, y, true);
						walls.Add(wall.ID(), wall);
					}
					if (y != 10)
					{
						MazeWall wall = new MazeWall(x, y, false);
						walls.Add(wall.ID(), wall);
					}
				}
		}

		public void Update(Graphics g)
		{
			foreach (MazeWall wall in walls.Values)
			{
				wall.draw(g, 350, 50, MazeGlobal.cellSize);
			}
		}
	}
}
