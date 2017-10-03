using System;

namespace CSMaze
{
	public class MazeControlPanelButton: System.Windows.Controls.Button
	{
		public MazeControlPanelButton(String label, double width, double height)
		{
			Content = label;
			Width = width;
			Height = height;
			BorderBrush = System.Windows.Media.Brushes.Black;
			Margin = new System.Windows.Thickness(5, 5, 5, 5);
		}
	}
}
