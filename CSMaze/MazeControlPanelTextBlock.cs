
namespace CSMaze
{
	public class MazeControlPanelTextBlock: System.Windows.Controls.TextBlock
	{
		public MazeControlPanelTextBlock(string title, double width, double height)
		{
			Text = title;
			Width = width;
			Height = height;
			Margin = new System.Windows.Thickness(5, 5, 5, 5);
		}
	}
}
