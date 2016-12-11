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
	public partial class FormMain : Form
	{
		public int[] history = new int[10]; //История
		public int ihistory = 0; //Индекс для истории

		public FormMain()
		{
			InitializeComponent();
			MaximizeBox = false; //состояние кнопки разворачивания окна на полный экран
			StartPosition = FormStartPosition.CenterScreen; //запуск окна в центре экрана
			Form1 MDIChild = new Form1(); //запуск дочерней формы
			MDIChild.MdiParent = this; MDIChild.Show();
		}

		private void button_home_Click(object sender, EventArgs e)
		{
			Array.Clear(history,0,10); ihistory = 0; //Сброс истории
			var OldMDIChild = ActiveMdiChild;
			Form1 MDIChild = new Form1(); //переход с одной формы на другую 
			MDIChild.MdiParent = this; MDIChild.Show(); OldMDIChild.Close();
		}

		private void FormMain_MdiChildActivate(object sender, EventArgs e)
		{
			var newChildName = ActiveMdiChild.Name.ToString();
			if(newChildName.Length == 5)
				newChildName = newChildName.Substring(4, 1);
			else
				newChildName = newChildName.Substring(4, 2);
			label_timer.Text = newChildName;
			history[ihistory] = Int32.Parse(newChildName);
			ihistory++;
			label_top.Text = null;
			foreach (int i in history)
			{
				label_top.Text += (i+",");
			}
		}
	}
}
