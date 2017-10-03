using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMaze
{
	public class MazeControlPanelTextBox: System.Windows.Controls.TextBox
	{
		public MazeControlPanelTextBox(double width, double height)
		{
			Width = width;
			Height = height;
			BorderBrush = System.Windows.Media.Brushes.Black;
			Margin = new System.Windows.Thickness(5, 5, 5, 5);
		}

		public MazeControlPanelTextBox(int value, double width, double height)
		{
			Width = width;
			Height = height;
			Text = value.ToString();
			BorderBrush = System.Windows.Media.Brushes.Black;
			Margin = new System.Windows.Thickness(5, 5, 5, 5);
		}
	}
}
