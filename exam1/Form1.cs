﻿using System;
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

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 MDIChild = new Form2();
			// Set the Parent Form of the Child window.
			MDIChild.MdiParent = this.MdiParent;
			// Display the new form.
			MDIChild.Show();
			Close();
		}
	}
}
