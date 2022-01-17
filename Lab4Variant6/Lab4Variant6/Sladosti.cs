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

        //шоколадки
        public enum NachinkaTip { oreh, nuga, slivki, frukt };
        public enum ChocolateTip { black, milky, white };
        public class Chocolates : Sladosti
        {
            public NachinkaTip vkus = NachinkaTip.nuga; // начинка шоколада
            public int NumPlitki = 4; //колво плиток
            public ChocolateTip tip = ChocolateTip.black; //три типа шоколада
            public static Chocolates GenerateRandomly()
            {
                return new Chocolates
                {
                    Ves = rnd.Next(3, 12) * 10, // вес от 30 до 120 грамм
                    vkus = (NachinkaTip)rnd.Next(4),
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
                    case NachinkaTip.slivki:
                        return "со сливками";
                    case NachinkaTip.frukt:
                        return "с фруктовой начинкой";
                    default:
                        return "";
                }
            }
            public override String MoreInfo()
            {
                return (OpisanieTipa() + "шоколад" + OpisanieNachinki() + " ,вес " + Ves + "грамм" +
                    ", количество плиток: " + NumPlitki);
            }
        }
        
        //выпечка
        public enum BakeryGoodsTip { cupcake, donut, waffle, pirozhok, blinchik };
        public class BakeryGoods : Sladosti
        {
            public BakeryGoodsTip tip = BakeryGoodsTip.waffle; //тип выпечки
            public int FoodEnergy = 339; //ккал
            public bool Yagoda = false; //наличие ягоды
            public static BakeryGoods GenerateRandomly()
            {
                return new BakeryGoods
                {
                    Ves = rnd.Next(5, 21) * 10, // от 50 до 210 грамм
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
                        return " c ягодкой";
                    default:
                        return "";
                }
            }
            public override String MoreInfo()
            {
                return (OpisanieTipa() + EstbYagoda() + " ,вес " + Ves + "грамм" +
                    ", количество ккал: " + FoodEnergy);
            }
        }
        
        //фрукты
        public enum FruitTip { pear, apple, plum, apricot, pomegrenate, kiwifruit, grape, banana, pitaya };
        public class Fruits : Sladosti
        {
            public FruitTip tip = FruitTip.kiwifruit; //вид фрукта
            public int Spelost = 0; //спелость %
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
                    case FruitTip.grape:
                        return "Виноград";
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
                return ("Фрукт " + OpisanieTipa() + " ,вес " + Ves + "грамм" +
                    ", спелость фрукта прямо сейчас: " + Spelost);
            }
        }
    }
}
