using System.Windows.Forms;

namespace CSMaze.ControlPanel
{
	class ControlPanel: Panel
	{
		public ControlPanel()
		{
			Width = GlobalData.controlPanelWidth;
			Height = GlobalData.controlPanelHeight;

			int xOffset = 10;
			int yOffset = 10;

			int x = xOffset;
			int y = yOffset;

			int buffer = 5;

			int width = GlobalData.controlPanelWidth;
			int height = 25;

			Controls.Add(new LoadMazes(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new SaveMazes(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Mazes(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new MazeSize(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new CellSize (x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Algorithms(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new StartCell(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Entrance(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Exit(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Create(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Solve(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Print(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new Display(x, y, width, height, buffer));
			y = y + height + buffer;

			Controls.Add(new CreateRoom(x, y, width, height, buffer));
			y = y + height + buffer;

		}
	}
}
