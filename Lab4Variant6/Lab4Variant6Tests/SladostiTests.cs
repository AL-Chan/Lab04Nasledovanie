using Microsoft.VisualStudio.TestTools.UnitTesting;
//шоколад 3*3, сдоба 5, фрукты 8 
namespace Lab4Variant6.Tests
{
    //выдача шоколада (black, milky, white )
    //                  oreh, nuga, frukt
    [TestClass()]
    public class SladostiTests
    {
        [TestMethod()]
        public void MoreInfoTest()
        {
            Chocolates sladost = new Chocolates();

            //МОЛОЧНЫЙ ШОКОЛАД
            sladost.Ves = 55;
            sladost.tip = ChocolateTip.milky; 
            sladost.vkus = NachinkaTip.nuga;// нуга
            sladost.NumPlitki = 4; //колво плиток
            Assert.AreEqual("\nМолочный шоколад с нугой\nВес: 55 грамм\nКоличество плиток: 4", sladost.MoreInfo());

            sladost.tip = ChocolateTip.milky;
            sladost.vkus = NachinkaTip.oreh;// орехи
            sladost.NumPlitki = 5; //колво плиток
            Assert.AreEqual("\nМолочный шоколад с орехами\nВес: 55 грамм\nКоличество плиток: 5", sladost.MoreInfo());

            sladost.tip = ChocolateTip.milky; 
            sladost.vkus = NachinkaTip.frukt;// фруктовая начинка
            sladost.NumPlitki = 4; //колво плиток
            Assert.AreEqual("\nМолочный шоколад с фруктовой начинкой\nВес: 55 грамм\nКоличество плиток: 4", sladost.MoreInfo());

            //ТЁМНЫЙ ШОКОЛАД
            sladost.Ves = 40;
            sladost.tip = ChocolateTip.black; 
            sladost.vkus = NachinkaTip.frukt;// фрукты
            sladost.NumPlitki = 3; //колво плиток
            Assert.AreEqual("\nТёмный шоколад с фруктовой начинкой\nВес: 40 грамм\nКоличество плиток: 3", sladost.MoreInfo());

            sladost.Ves = 70;
            sladost.tip = ChocolateTip.black; 
            sladost.vkus = NachinkaTip.nuga;// нуга
            sladost.NumPlitki = 5; //колво плиток
            Assert.AreEqual("\nТёмный шоколад с нугой\nВес: 70 грамм\nКоличество плиток: 5", sladost.MoreInfo());

            sladost.Ves = 85;
            sladost.tip = ChocolateTip.black; 
            sladost.vkus = NachinkaTip.oreh;// орехи
            sladost.NumPlitki = 8; //колво плиток
            Assert.AreEqual("\nТёмный шоколад с орехами\nВес: 85 грамм\nКоличество плиток: 8", sladost.MoreInfo());

            //БЕЛЫЙ ШОКОЛАД
            sladost.Ves = 60;
            sladost.tip = ChocolateTip.white;
            sladost.vkus = NachinkaTip.nuga;// нуга
            sladost.NumPlitki = 4; //колво плиток
            Assert.AreEqual("\nБелый шоколад с нугой\nВес: 60 грамм\nКоличество плиток: 4", sladost.MoreInfo());

            sladost.tip = ChocolateTip.white; 
            sladost.vkus = NachinkaTip.frukt;// фрукты
            sladost.NumPlitki = 5; //колво плиток
            Assert.AreEqual("\nБелый шоколад с фруктовой начинкой\nВес: 60 грамм\nКоличество плиток: 5", sladost.MoreInfo());

            sladost.Ves = 65;
            sladost.tip = ChocolateTip.white; 
            sladost.vkus = NachinkaTip.oreh;// орехи
            sladost.NumPlitki = 5; //колво плиток
            Assert.AreEqual("\nБелый шоколад с орехами\nВес: 65 грамм\nКоличество плиток: 5", sladost.MoreInfo());
        }
    }
    //выдача выпечки (cupcake, donut, waffle, pirozhok, blinchik)
    [TestClass()]
    public class BakeryGoodsTests
    {
        [TestMethod()]
        public void MoreInfoTest()
        {
            BakeryGoods sladost = new BakeryGoods();

            sladost.Ves = 95;
            sladost.tip = BakeryGoodsTip.cupcake; //КЕКСИК
            sladost.FoodEnergy = 320; //ккал
            sladost.Yagoda = true;
            Assert.AreEqual("\nКексик с ягодкой\nВес: 95 грамм\nЭнергетическая ценность: 320 ккал", sladost.MoreInfo());

            sladost.tip = BakeryGoodsTip.donut; //ПОНЧИК
            sladost.FoodEnergy = 280; //ккал
            sladost.Yagoda = false;
            Assert.AreEqual("\nПончик\nВес: 95 грамм\nЭнергетическая ценность: 280 ккал", sladost.MoreInfo());

            sladost.tip = BakeryGoodsTip.waffle; //ВАФЛИ
            sladost.FoodEnergy = 220; //ккал
            sladost.Yagoda = false;
            Assert.AreEqual("\nВафли\nВес: 95 грамм\nЭнергетическая ценность: 220 ккал", sladost.MoreInfo());

            sladost.tip = BakeryGoodsTip.pirozhok; //ПИРОЖОК
            sladost.FoodEnergy = 300; //ккал
            sladost.Yagoda = false;
            Assert.AreEqual("\nПирожок\nВес: 95 грамм\nЭнергетическая ценность: 300 ккал", sladost.MoreInfo());

            sladost.tip = BakeryGoodsTip.blinchik; //БЛИНЧИК
            sladost.FoodEnergy = 290; //ккал
            sladost.Yagoda = true;
            Assert.AreEqual("\nБлинчик с ягодкой\nВес: 95 грамм\nЭнергетическая ценность: 290 ккал", sladost.MoreInfo());
        }
    }
    // выдача фруктов (pear, apple, plum, apricot, pomegrenate, kiwifruit, banana, pitaya)
    [TestClass()]
    public class FruitsTests
    {
        [TestMethod()]
        public void MoreInfoTest()
        {
            Fruits sladost = new Fruits();

            sladost.Ves = 240;

            sladost.tip = FruitTip.apple; //ЯБЛОКО
            sladost.Spelost = 80; //спелость %
            Assert.AreEqual("\nФрукт Яблоко\nВес: 240 грамм\nСпелость фрукта в данный момент: 80%", sladost.MoreInfo());

            sladost.tip = FruitTip.pear; //ГРУША
            sladost.Spelost = 56; 
            Assert.AreEqual("\nФрукт Груша\nВес: 240 грамм\nСпелость фрукта в данный момент: 56%", sladost.MoreInfo());

            sladost.Ves = 190;
            sladost.tip = FruitTip.plum; //СЛИВА
            sladost.Spelost = 96; 
            Assert.AreEqual("\nФрукт Слива\nВес: 190 грамм\nСпелость фрукта в данный момент: 96%", sladost.MoreInfo());

            sladost.Ves = 220;
            sladost.tip = FruitTip.apricot; //АБРИКОС
            sladost.Spelost = 50; 
            Assert.AreEqual("\nФрукт Абрикос\nВес: 220 грамм\nСпелость фрукта в данный момент: 50%", sladost.MoreInfo());

            sladost.Ves = 560;
            sladost.tip = FruitTip.pomegrenate; //ГРАНАТ
            sladost.Spelost = 31; 
            Assert.AreEqual("\nФрукт Гранат\nВес: 560 грамм\nСпелость фрукта в данный момент: 31%", sladost.MoreInfo());

            sladost.Ves = 150;
            sladost.tip = FruitTip.kiwifruit; //КИВИ
            sladost.Spelost = 72; 
            Assert.AreEqual("\nФрукт Киви\nВес: 150 грамм\nСпелость фрукта в данный момент: 72%", sladost.MoreInfo());

            sladost.Ves = 290;
            sladost.tip = FruitTip.banana; //БАНАН
            sladost.Spelost = 92; 
            Assert.AreEqual("\nФрукт Банан\nВес: 290 грамм\nСпелость фрукта в данный момент: 92%", sladost.MoreInfo());

            sladost.Ves = 420;
            sladost.tip = FruitTip.pitaya; //ПИТАЙЯ
            sladost.Spelost = 16; 
            Assert.AreEqual("\nФрукт Драконий фрукт\nВес: 420 грамм\nСпелость фрукта в данный момент: 16%", sladost.MoreInfo());
        }
    }
}