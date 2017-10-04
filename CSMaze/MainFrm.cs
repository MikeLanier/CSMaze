using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMaze
{
	public partial class MainFrm : Form
	{
		public MainFrm()
		{
			System.Console.WriteLine("MainFrm");
			InitializeComponent();

			MazeGlobal.controlPanel = new CSMaze.ControlPanel();
			Controls.Add(MazeGlobal.controlPanel);

			MazeGlobal.displayPanel = new CSMaze.DisplayPanel();
			Controls.Add(MazeGlobal.displayPanel);

		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;

			MazeGlobal.displayPanel.Update(g);
		}
	}
}
