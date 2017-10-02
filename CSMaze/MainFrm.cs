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
		ControlPanel controlPanel = null;

		public MainFrm()
		{
			System.Console.WriteLine("MainFrm");
			InitializeComponent();

			controlPanel = new CSMaze.ControlPanel();
			Controls.Add(controlPanel);

		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
		}
	}
}
