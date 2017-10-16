using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CSMaze.DisplayPanel
{
	class DisplayPanel : Panel
	{
		private Dictionary<int, Maze.Wall> walls = new Dictionary<int, Maze.Wall>();

		public DisplayPanel()
		{
			for(int x=0; x<=10; x++)
				for(int y=0; y<=10; y++)
				{
					if (x != 10)
					{
						Maze.Wall wall = new Maze.Wall(x, y, true);
						walls.Add(wall.ID(), wall);
					}
					if (y != 10)
					{
						Maze.Wall wall = new Maze.Wall(x, y, false);
						walls.Add(wall.ID(), wall);
					}
				}
		}

		public void Update(Graphics g)
		{
			foreach (Maze.Wall wall in walls.Values)
			{
				wall.draw(g, 350, 50, GlobalData.cellSize);
			}
		}
	}
}
