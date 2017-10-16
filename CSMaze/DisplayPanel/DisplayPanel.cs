using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CSMaze.DisplayPanel
{
	class DisplayPanel : Panel
	{

		public void resetMazeGrid()
		{
			int width = (GlobalData.mazeSizeX + 2) * GlobalData.cellSize+ 1;
			int height = (GlobalData.mazeSizeY + 2) * GlobalData.cellSize + 1;

			width += 600;
			height += 300;

			this.Width = width; // + xOffset);
			this.Height = height; // + yOffset);

			//GraphicsContext gc = this.getGraphicsContext2D();
			//gc.setFill(javafx.scene.paint.Color.WHITE);
			//gc.fillRect(xOffset, yOffset, width, height);
		}

		void buildMazeGrid()
		{
			resetMazeGrid();

			for (int x = 1; x <= GlobalData.mazeSizeX; x++)
			{
				for (int y = 1; y <= GlobalData.mazeSizeY; y++)
				{
					createCell(x, y);
				}
			}
		}

		private Maze.Cell createCell(int x, int y)
		{
			Maze.Wall west = null;
			GlobalData.walls.TryGetValue(GlobalData.ID(x, y, false), out west);
			if (west == null)
			{
				west = new Maze.Wall(x, y, false);
				GlobalData.walls.Add(west.ID(), west);
			}

			Maze.Wall north = null;
			GlobalData.walls.TryGetValue(GlobalData.ID(x, y, true), out north);
			if (north == null)
			{
				north = new Maze.Wall(x, y, true);
				GlobalData.walls.Add(north.ID(), north);
			}

			Maze.Wall east = null;
			GlobalData.walls.TryGetValue(GlobalData.ID(x + 1, y, false), out east);
			if (east == null)
			{
				east = new Maze.Wall(x + 1, y, false);
				GlobalData.walls.Add(east.ID(), east);
			}

			Maze.Wall south = null;
			GlobalData.walls.TryGetValue(GlobalData.ID(x, y + 1, true), out south);
			if (south == null)
			{
				south = new Maze.Wall(x, y + 1, true);
				GlobalData.walls.Add(south.ID(), south);
			}

			Maze.Cell mazeCell = new Maze.Cell(x, y, west, north, east, south);
			GlobalData.cells.Add(mazeCell.ID(), mazeCell);

			return mazeCell;
		}

		public DisplayPanel()
		{
			for(int x=0; x<=10; x++)
				for(int y=0; y<=10; y++)
				{
					createCell(x, y);
				}
		}

		public void Update(Graphics g)
		{
			foreach (Maze.Cell cell in GlobalData.cells.Values)
			{
				cell.draw(g, 350, 50, GlobalData.cellSize);
			}
			foreach (Maze.Wall wall in GlobalData.walls.Values)
			{
				wall.draw(g, 350, 50, GlobalData.cellSize);
			}
		}
	}
}
