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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
			string MyConString = "SERVER=localhost;" + "DATABASE=ekzamen;" + "UID=root;" + "PASSWORD=555666;";
			MySqlConnection connection = new MySqlConnection(MyConString);
			MySqlCommand command = connection.CreateCommand();
			MySqlDataReader Reader;
			command.CommandText = "select * from gender";
			connection.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				string thisrow = "";
				for (int i = 0; i < Reader.FieldCount; i++)
					thisrow += Reader.GetValue(i).ToString();
				comboBox0.Items.Add(thisrow);
			}
			connection.Close();
			command.CommandText = "select * from country";
			connection.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				string thisrow = "";
				thisrow += Reader.GetValue(1).ToString();
				comboBox1.Items.Add(thisrow);
			}
			connection.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MdiParent.CancelButton.PerformClick();
		}

		private void button0_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fname = openFileDialog.FileName;
				var img = new Bitmap(fname);
				pictureBox_image.Image = img;
				textBox6.Text = fname.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string MyConString = "SERVER=localhost;" + "DATABASE=ekzamen;" + "UID=root;" + "PASSWORD=555666;";
				MySqlConnection connection = new MySqlConnection(MyConString);
				MySqlCommand command = connection.CreateCommand();
				MySqlDataReader Reader;
				command.CommandText = "insert into ekzamen.user(Email,Password,FirstName,Lastname,RoleID) values('" + textBox0.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','R');";
				connection.Open();
				Reader = command.ExecuteReader();
				while (Reader.Read())
				{
				}
				connection.Close();
				Form5 MDIChild = new Form5(); //переход с одной формы на другую 
				MDIChild.MdiParent = this.MdiParent; MDIChild.Show(); Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
