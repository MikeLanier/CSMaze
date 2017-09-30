using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSMaze
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			StackPanel spVertical = new StackPanel();
			if (spVertical != null)
			{
				spVertical.HorizontalAlignment = HorizontalAlignment.Left;
				spVertical.VerticalAlignment = VerticalAlignment.Top;

				mainGrid.Children.Add(spVertical);

				StackPanel spLoadControl = new StackPanel();
				if (spLoadControl != null)
				{
					spLoadControl.Orientation = Orientation.Horizontal;
					spVertical.Children.Add(spLoadControl);

					MazeControlPanelButton btnLoad = new MazeControlPanelButton("Load", 60, 20);
					btnLoad.Click += new RoutedEventHandler(onLoadButtonClick);
					spLoadControl.Children.Add(btnLoad);

					MazeControlPanelTextBox tbLoadFilename = new MazeControlPanelTextBox(150, 20);
					spLoadControl.Children.Add(tbLoadFilename);

					MazeControlPanelButton btnFileLoadDialog = new MazeControlPanelButton("?", 20, 20);
					spLoadControl.Children.Add(btnFileLoadDialog);
				}

				StackPanel spSaveControl = new StackPanel();
				if (spSaveControl != null)
				{
					spSaveControl.Orientation = Orientation.Horizontal;
					spVertical.Children.Add(spSaveControl);

					MazeControlPanelButton btnSave = new MazeControlPanelButton("Save", 60, 20);
					spSaveControl.Children.Add(btnSave);

					MazeControlPanelTextBox tbSaveFilename = new MazeControlPanelTextBox(150, 20);
					spSaveControl.Children.Add(tbSaveFilename);

					MazeControlPanelButton btnFileSaveDialog = new MazeControlPanelButton("?", 20, 20);
					spSaveControl.Children.Add(btnFileSaveDialog);
				}

				StackPanel spMazesControl = new StackPanel();
				if (spMazesControl != null)
				{
					spMazesControl.Orientation = Orientation.Horizontal;
					spVertical.Children.Add(spMazesControl);

					spMazesControl.Children.Add(new MazeControlPanelTextBlock("Mazes", 60, 20));

					MazeControlPanelTextBox tbSaveFilename = new MazeControlPanelTextBox(150, 20);
					spMazesControl.Children.Add(tbSaveFilename);
				}
			}
		}

		void onLoadButtonClick(object sender, RoutedEventArgs e)
		{

		}
	}
}
