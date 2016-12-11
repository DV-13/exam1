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
		public FormMain()
		{
			InitializeComponent();
			MaximizeBox = false; //состояние кнопки разворачивания окна на полный экран
			StartPosition = FormStartPosition.CenterScreen; //запуск окна в центре экрана
			Form1 MDIChild = new Form1(); //запуск дочерней формы
			MDIChild.MdiParent = this; MDIChild.Show();
		}
	}
}
