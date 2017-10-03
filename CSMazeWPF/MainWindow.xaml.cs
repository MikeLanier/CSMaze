using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace CSMaze
{
	public partial class MainWindow : Window
	{
		Polygon myPolygon = null;
		public MainWindow()
		{
			InitializeComponent();

			int size = 50;
			int xOffset = 50;
			int yOffset = 50;

			MazeWall wallh;
			MazeWall wallv;

			for (int x = 0; x <= 10; x++)
			{
				for (int y = 0; y <= 10; y++)
				{
					if (x < 10)
					{
						wallh = new CSMaze.MazeWall(x * size + xOffset, y * size + yOffset, size, true);
						displayPanel.Children.Add(wallh.graphic());
					}
					if (y < 10)
					{
						wallv = new CSMaze.MazeWall(x * size + xOffset, y * size + yOffset, size, false);
						displayPanel.Children.Add(wallv.graphic());
					}
				}
			}
		}
	}
}
