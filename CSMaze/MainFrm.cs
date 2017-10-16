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

			GlobalData.controlPanel = new CSMaze.ControlPanel.ControlPanel();
			Controls.Add(GlobalData.controlPanel);

			GlobalData.displayPanel = new CSMaze.DisplayPanel.DisplayPanel();
			Controls.Add(GlobalData.displayPanel);

			this.DoubleBuffered = true;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;

			GlobalData.displayPanel.Update(g);
		}
	}
}
