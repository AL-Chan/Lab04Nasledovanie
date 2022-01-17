using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab4Variant6.Sladosti;

namespace Lab4Variant6
{
    public partial class Form1 : Form
    {
        readonly List<Sladosti> sladostiList = new List<Sladosti>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void RefillButton_Click(object sender, EventArgs e) // кнопка Заполнить автомат
        {
            Random rnd = new Random();
            this.sladostiList.Clear();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // выбираем тип
                {
                    case 0:
                        this.sladostiList.Add(Chocolates.GenerateRandomly());
                        break;
                    case 1:
                        this.sladostiList.Add(BakeryGoods.GenerateRandomly());
                        break;
                    case 2:
                        this.sladostiList.Add(Fruits.GenerateRandomly());
                        break;
                }
            }
            ShowInfo();
        }

        private void GrabButton_Click(object sender, EventArgs e) // кнопка Взять еду
        {
            if (this.sladostiList.Count == 0)
            {
                InfoLog.Text = "Тут ничего";
                return;
            }
            var sladosti = this.sladostiList[0];
            this.sladostiList.RemoveAt(0);
            InfoLog.Text = sladosti.MoreInfo();
            ShowInfo();
        }
        private void ShowInfo()
        {
            //счетчики для поля информации
            int ChocolatesCount = 0;
            int BakeryGoodsCount = 0;
            int FruitsCount = 0;

            foreach (var sladost in this.sladostiList)
            {
                if (sladost is Chocolates) 
                {
                    ChocolatesCount += 1;
                }
                else if (sladost is BakeryGoods)
                {
                    BakeryGoodsCount += 1;
                }
                else if (sladost is Fruits)
                {
                    FruitsCount += 1;
                }
            }

            MenuText.Text = "\nШоколадки\tВыпечка\t\tФрукты";
            MenuText.Text += "\n";
            MenuText.Text += String.Format("{0}\t\t{1}\t\t {2}", ChocolatesCount, BakeryGoodsCount, FruitsCount);
        }
    }
}