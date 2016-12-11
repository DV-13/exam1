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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button0_Click(object sender, EventArgs e)
		{
			Form2 MDIChild = new Form2(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form6 MDIChild = new Form6(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form10 MDIChild = new Form10(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}
	}
}
