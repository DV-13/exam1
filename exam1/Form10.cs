using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam1
{
	public partial class Form10 : Form
	{
		public Form10()
		{
			InitializeComponent();
		}

		private void button0_Click(object sender, EventArgs e)
		{
			Form11 MDIChild = new Form11(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form14 MDIChild = new Form14(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form13 MDIChild = new Form13(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}
	}
}
