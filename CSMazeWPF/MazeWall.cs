using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CSMaze
{
	public class MazeWall
	{
		public Polygon polygon = new Polygon();

		public Polygon graphic() { return polygon;  }

		public MazeWall(int x, int y, int size, bool horizonal)
		{
			polygon.Stroke = System.Windows.Media.Brushes.Black;
			polygon.Fill = System.Windows.Media.Brushes.LightSeaGreen;
			polygon.StrokeThickness = 1;
			polygon.HorizontalAlignment = HorizontalAlignment.Left;
			polygon.VerticalAlignment = VerticalAlignment.Top;

			Point p1 = new Point();
			Point p2 = new Point();
			Point p3 = new Point();
			Point p4 = new Point();

			if(horizonal)
			{
				p1.X = x;		p1.Y = y;
				p2.X = x+size;	p2.Y = y;
				p3.X = x+size;	p3.Y = y + 1;
				p4.X = x;		p4.Y = y + 1;
			}
			else
			{
				p1.X = x;		p1.Y = y;
				p2.X = x + 1;	p2.Y = y;
				p3.X = x + 1;	p3.Y = y + size;
				p4.X = x;		p4.Y = y + size;
			}

			System.Console.WriteLine(p1.X.ToString() + ", " + p1.Y.ToString());
			System.Console.WriteLine(p2.X.ToString() + ", " + p2.Y.ToString());
			System.Console.WriteLine(p3.X.ToString() + ", " + p3.Y.ToString());
			System.Console.WriteLine(p4.X.ToString() + ", " + p4.Y.ToString());

			PointCollection myPointCollection = new PointCollection();
			myPointCollection.Add(p1);
			myPointCollection.Add(p2);
			myPointCollection.Add(p3);
			myPointCollection.Add(p4);
			polygon.Points = myPointCollection;
		}
	}
}
