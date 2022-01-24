using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Variant6
{
    public class Sladosti //родительский класс
    {
        protected static Random rnd = new Random();
        public int Ves; //вес продукта выдачи
        public virtual String MoreInfo()
        {
            return ("Сладость (вес " + Ves + "грамм)");
        }
    }
    //шоколадки
    public enum ChocolateTip { black, milky, white };
    public enum NachinkaTip { oreh, nuga, frukt };
    public class Chocolates : Sladosti
    {
        public NachinkaTip vkus; // начинка шоколада
        public int NumPlitki; //колво плиток
        public ChocolateTip tip; //три типа шоколада
        public static Chocolates GenerateRandomly()
        {
            return new Chocolates
            {
                Ves = rnd.Next(8, 24) * 5, // вес от 40 до 120 грамм
                vkus = (NachinkaTip)rnd.Next(3),
                NumPlitki = rnd.Next(3, 8), // плитки от 3 до 8
                tip = (ChocolateTip)rnd.Next(3)
            };
        }

        private String OpisanieTipa()
        {
            switch (this.tip) //тип шоколада
            {
                case ChocolateTip.black:
                    return "Тёмный";
                case ChocolateTip.milky:
                    return "Молочный";
                case ChocolateTip.white:
                    return "Белый";
                default:
                    return "";
            }
        }
        private String OpisanieNachinki()
        {
            switch (this.vkus) //начинка шоколада
            {
                case NachinkaTip.oreh:
                    return "с орехами";
                case NachinkaTip.nuga:
                    return "с нугой";
                case NachinkaTip.frukt:
                    return "с фруктовой начинкой";
                default:
                    return "";
            }
        }
        public override String MoreInfo()
        {
            return ("\n" + OpisanieTipa() + " шоколад " + OpisanieNachinki() +
                "\nВес: " + Ves + " грамм" + "\nКоличество плиток: " + NumPlitki);
        }
    }

    //выпечка
    public enum BakeryGoodsTip { cupcake, donut, waffle, pirozhok, blinchik };
    public class BakeryGoods : Sladosti
    {
        public BakeryGoodsTip tip; //тип выпечки
        public int FoodEnergy; //ккал
        public bool Yagoda; //наличие ягоды
        public static BakeryGoods GenerateRandomly()
        {
            return new BakeryGoods
            {
                Ves = rnd.Next(10, 42) * 5, // от 50 до 210 грамм
                tip = (BakeryGoodsTip)rnd.Next(5),
                FoodEnergy = rnd.Next(30, 50) * 10, // от 300 до 500 ккал
                Yagoda = rnd.Next(2) == 0, // наличие ягоды
            };
        }
        private String OpisanieTipa()
        {
            switch (this.tip) //тип выпечки
            {
                case BakeryGoodsTip.cupcake:
                    return "Кексик";
                case BakeryGoodsTip.donut:
                    return "Пончик";
                case BakeryGoodsTip.waffle:
                    return "Вафли";
                case BakeryGoodsTip.pirozhok:
                    return "Пирожок";
                case BakeryGoodsTip.blinchik:
                    return "Блинчик";
                default:
                    return "";
            }
        }
        private String EstbYagoda()
        {
            switch (this.Yagoda) //наличие ягоды внутри или сверху
            {
                case true:
                    return " с ягодкой";
                default:
                    return "";
            }
        }
        public override String MoreInfo()
        {
            return ("\n" + OpisanieTipa() + EstbYagoda() + "\nВес: " + Ves + " грамм" +
                "\nЭнергетическая ценность: " + FoodEnergy + " ккал");
        }
    }

    //фрукты
    public enum FruitTip { pear, apple, plum, apricot, pomegrenate, kiwifruit, banana, pitaya };
    public class Fruits : Sladosti
    {
        public FruitTip tip; //вид фрукта
        public int Spelost; //спелость %
        public static Fruits GenerateRandomly()
        {
            return new Fruits
            {
                Ves = rnd.Next(12, 65) * 10, // от 120 до 650 грамм
                tip = (FruitTip)rnd.Next(9), // выбор среди девяти предложенных фруктов
                Spelost = rnd.Next() % 101, // спелость от 0 до 100
            };
        }
        private String OpisanieTipa()
        {
            switch (this.tip) //тип фрукта
            {
                case FruitTip.pear:
                    return "Груша";
                case FruitTip.apple:
                    return "Яблоко";
                case FruitTip.plum:
                    return "Слива";
                case FruitTip.apricot:
                    return "Абрикос";
                case FruitTip.pomegrenate:
                    return "Гранат";
                case FruitTip.kiwifruit:
                    return "Киви";
                case FruitTip.banana:
                    return "Банан";
                case FruitTip.pitaya:
                    return "Драконий фрукт";
                default:
                    return "";
            }
        }
        public override String MoreInfo()
        {
            return ("\nФрукт " + OpisanieTipa() + "\nВес: " + Ves + " грамм" +
                "\nСпелость фрукта в данный момент: " + Spelost + "%");
        }
    }
}