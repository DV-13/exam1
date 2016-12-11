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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button0_Click(object sender, EventArgs e)
		{
			Form3 MDIChild = new Form3(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form4 MDIChild = new Form4(); //переход с одной формы на другую 
			MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
		}
	}
}
