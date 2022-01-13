using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Variant6
{

    //шоколадки
    public enum NachinkaTip {oreh, nuga, slivki, zhele, frukt, moloko};
    public enum ChocolateTip {black, milky, white, pink};
    public class Chocolates
    {
        public NachinkaTip vkus = NachinkaTip.nuga; //начинка шоколада
        public int NumPlitki = 16; //колво плиток (16-20)
        public ChocolateTip tip = ChocolateTip.black; //три типа шоколада
    }

    //выпечка
    public enum BakeryGoodsTip {cookie, cupcake, donut, waffle, pirozhok, pryanik, blinchik};
    public class BakeryGoods
    {
        public BakeryGoodsTip tip = BakeryGoodsTip.waffle; //тип выпечки
        public int FoodEnergy = 339; //ккал
        public bool Yagoda = false; //наличие ягоды
    }

    //фрукты
    public enum FruitTip {pear, apple, plum, apricot, pomegrenate, kiwifruit, grape, banana, pineapple, pitaya};
    public class Fruits
    {
        public FruitTip tip = FruitTip.kiwifruit;//вид фрукта
        public int Spelost = 0;//спелость %
        public int Kostochki = 0;//количество косточек
    }
}