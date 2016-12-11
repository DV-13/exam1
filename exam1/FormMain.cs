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
		public int[] history = new int[50]; //История
		public int ihistory = 0; //Индекс для истории
		DateTime Event;

		public FormMain()
		{
			InitializeComponent();
			MaximizeBox = false; //состояние кнопки разворачивания окна на полный экран
			StartPosition = FormStartPosition.CenterScreen; //запуск окна в центре экрана
			Form1 MDIChild = new Form1(); //запуск дочерней формы
			MDIChild.MdiParent = this; MDIChild.Show();
			DateTime.TryParse("18.07.2017", out Event);
			label_timer.Text = ((Event - DateTime.Now).Days + " дней " + (Event - DateTime.Now).Hours + " часов и " + (Event - DateTime.Now).Minutes + " минут до старта марафона!");
		}

		private void button_home_Click(object sender, EventArgs e)
		{
			var OldMDIChild = ActiveMdiChild;
			Form1 MDIChild = new Form1(); //переход с одной формы на другую 
			MDIChild.MdiParent = this; MDIChild.Show(); OldMDIChild.Close();
		}

		private void FormMain_MdiChildActivate(object sender, EventArgs e)
		{
			var newChildName = ActiveMdiChild.Name.ToString();

			if (newChildName.Length == 5)
				newChildName = newChildName.Substring(4, 1);
			else
				newChildName = newChildName.Substring(4, 2);

			if (newChildName == "1")          //Прятание элементов заголовка.
			{
				Array.Clear(history, 0, 10); ihistory = 0; //Сброс истории
				button_back.Visible = false;
				button_home.Visible = false;
				label_top.Visible = false;
			}
			else
			{
				button_back.Visible = true;
				button_home.Visible = true;
				label_top.Visible = true;
			}

			//label_timer.Text = newChildName; //debug
			history[ihistory] = Int32.Parse(newChildName);
			ihistory++;
			//label_top.Text = null;           //debug
			//foreach (int i in history)
			//{
			//	label_top.Text += (i+",");
			//}
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			ihistory--;
			history[ihistory] = 0;
			ihistory--;
			var OldMDIChild = ActiveMdiChild;
			switch (history[ihistory])
			{
				case 1:
					{
						Form1 MDIChild = new Form1();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 2:
					{
						Form2 MDIChild = new Form2();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 3:
					{
						Form3 MDIChild = new Form3();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 4:
					{
						Form4 MDIChild = new Form4();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 5:
					{
						Form5 MDIChild = new Form5();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 6:
					{
						Form6 MDIChild = new Form6();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 7:
					{
						Form7 MDIChild = new Form7();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 8:
					{
						Form8 MDIChild = new Form8();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 9:
					{
						Form9 MDIChild = new Form9();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				case 10:
					{
						Form10 MDIChild = new Form10();
						MDIChild.MdiParent = this; MDIChild.Show();
						break;
					}
				//case 11:
				//	{
				//		Form11 MDIChild = new Form11();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 12:
				//	{
				//		Form12 MDIChild = new Form12();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 13:
				//	{
				//		Form13 MDIChild = new Form13();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 14:
				//	{
				//		Form14 MDIChild = new Form14();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 15:
				//	{
				//		Form15 MDIChild = new Form15();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 16:
				//	{
				//		Form16 MDIChild = new Form16();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 17:
				//	{
				//		Form17 MDIChild = new Form17();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 18:
				//	{
				//		Form18 MDIChild = new Form18();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 19:
				//	{
				//		Form19 MDIChild = new Form19();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 20:
				//	{
				//		Form20 MDIChild = new Form20();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 21:
				//	{
				//		Form21 MDIChild = new Form21();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 22:
				//	{
				//		Form22 MDIChild = new Form22();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 23:
				//	{
				//		Form23 MDIChild = new Form23();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 24:
				//	{
				//		Form24 MDIChild = new Form24();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 25:
				//	{
				//		Form25 MDIChild = new Form25();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 26:
				//	{
				//		Form26 MDIChild = new Form26();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 27:
				//	{
				//		Form27 MDIChild = new Form27();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 28:
				//	{
				//		Form28 MDIChild = new Form28();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 29:
				//	{
				//		Form29 MDIChild = new Form29();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 30:
				//	{
				//		Form30 MDIChild = new Form30();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 31:
				//	{
				//		Form31 MDIChild = new Form31();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 32:
				//	{
				//		Form32 MDIChild = new Form32();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 33:
				//	{
				//		Form33 MDIChild = new Form33();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 34:
				//	{
				//		Form34 MDIChild = new Form34();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 35:
				//	{
				//		Form35 MDIChild = new Form35();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 36:
				//	{
				//		Form36 MDIChild = new Form36();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 37:
				//	{
				//		Form37 MDIChild = new Form37();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 38:
				//	{
				//		Form38 MDIChild = new Form38();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 39:
				//	{
				//		Form39 MDIChild = new Form39();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				//case 40:
				//	{
				//		Form40 MDIChild = new Form40();
				//		MDIChild.MdiParent = this; MDIChild.Show();
				//		break;
				//	}
				default:
				{
					Form1 MDIChild = new Form1();
					MDIChild.MdiParent = this; MDIChild.Show();
					break;
				}
			}
			OldMDIChild.Close();
		}

		private void timer_countdown_Tick(object sender, EventArgs e)
		{
			label_timer.Text = ((Event - DateTime.Now).Days + " дней " + (Event - DateTime.Now).Hours + " часов и " + (Event - DateTime.Now).Minutes + " минут до старта марафона!");
		}
	}
}
