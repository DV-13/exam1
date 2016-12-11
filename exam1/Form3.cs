using MySql.Data.MySqlClient;
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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MdiParent.CancelButton.PerformClick();
		}

		private void button0_Click(object sender, EventArgs e)
		{
		try
		{
			string MyConString = "SERVER=localhost;" + "DATABASE=ekzamen;" + "UID=root;" + "PASSWORD=555666;";
			MySqlConnection connection = new MySqlConnection(MyConString);
			MySqlCommand command = connection.CreateCommand();
			MySqlDataReader Reader;
			command.CommandText = "select * from ekzamen.user where Email = '" + textBox0.Text + "' and Password = '" + textBox1.Text + "'";
			connection.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				Program.reg = Reader.GetValue(4).ToString();
			}
			connection.Close();
			switch (Program.reg)
			{
					case "R":
					{
							Form9 MDIChild = new Form9(); //переход с одной формы на другую 
							MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
							break;
					}
					//case "A":
					//	{
					//		Form19 MDIChild = new Form19(); //переход с одной формы на другую 
					//		MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
					//		break;
					//	}
					//case "C":
					//	{
					//		Form20 MDIChild = new Form20(); //переход с одной формы на другую 
					//		MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
					//		break;
					//	}
					//case "U"://Зритель.
					//	{
					//		Form9 MDIChild = new Form9(); //переход с одной формы на другую 
					//		MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
					//		break;
					//	}
					default:
					{
							MessageBox.Show("Error");
							break;
					}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		}
	}
}
