/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 2 / 2 / 2020
 * Description : Code for CA project (bar till system)
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Drink> Default = new List<Drink>();
        List<Drink> Draught = new List<Drink>();
        List<Drink> Minerals = new List<Drink>();
        List<Drink> Juices = new List<Drink>();
        List<Drink> Babies = new List<Drink>();
        List<Drink> Wine = new List<Drink>();
        List<Drink> Teas_And_Coffees = new List<Drink>();
        List<Drink> Bottled_Beer = new List<Drink>();
        List<Drink> Gins = new List<Drink>();
        List<Drink> Whiskeys = new List<Drink>();
        List<Drink> Vodkas = new List<Drink>();
        List<Drink> Liqueurs = new List<Drink>();
        List<Drink> Shots = new List<Drink>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Drink Guinness = new Drink("Guinness", 4.60, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            #region objects
            Drink Heineken = new Drink("Heineken", 4.70, DrinkType.Draught, new DateTime(2020 - 06 - 22));
            Drink Carlsberg = new Drink("Carlsberg", 4.70, DrinkType.Draught, new DateTime(2020 - 08 - 28));
            Drink Budweiser = new Drink("Budweiser", 4.70, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Carling = new Drink("Carling", 3.80, DrinkType.Draught, new DateTime(2020 - 08 - 09));
            Drink Smithwicks = new Drink("Smithwicks", 4.60, DrinkType.Draught, new DateTime(2020 - 09 - 01));
            Drink CoorsLight = new Drink("Coors Light", 4.70, DrinkType.Draught, new DateTime(2020 - 11 - 01));
            Drink Bulmers = new Drink("Bulmers", 5.20, DrinkType.Draught, new DateTime(2021 - 02 - 17));
            Drink OrchardThieves = new Drink("Orchard Thieves", 5.20, DrinkType.Draught, new DateTime(2021 - 02 - 20));
            Drink RockshoreLager = new Drink("Rockshore Lager", 4.70, DrinkType.Draught, new DateTime(2021 - 04 - 29));
            Drink RockshoreCider = new Drink("Rockshore Cider", 5.00, DrinkType.Draught, new DateTime(2021 - 06 - 28));
            Drink Sullivans = new Drink("Sullivans", 4.60, DrinkType.Draught, new DateTime(2021 - 07 - 05));
            Drink WKD = new Drink("WKD", 5.30, DrinkType.BottledBeer, new DateTime(2021 - 07 - 23));
            Drink SmirnoffIce = new Drink("Smirnoff Ice", 5.30, DrinkType.BottledBeer, new DateTime(2020 - 01 - 29));
            Drink CoorsLightBottle = new Drink("Coors Light Bottle", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 03 - 26));
            Drink Corona = new Drink("Corona", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 05 - 21));
            Drink Miller = new Drink("Miller", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 06 - 05));
            Drink BudweiserBottle = new Drink("Budweiser Bottle", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 05 - 25));
            Drink RockshoreLagerBottle= new Drink("RockshoreLager Bottle", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 04 - 03));
            Drink RockshoreCiderBottle = new Drink("RockshoreCider Bottle", 5.00, DrinkType.BottledBeer, new DateTime(2020 - 04 - 27));
            Drink GingerBeer = new Drink("Ginger Beer", 6.50, DrinkType.BottledBeer, new DateTime(2020 - 04 - 27));
            Drink Douraq = new Drink("Douraq", 6.50, DrinkType.BottledBeer, new DateTime(2020 - 06 - 01));
            Drink BulmersLongneck = new Drink("Bulmers Longneck", 4.70, DrinkType.BottledBeer, new DateTime(2020 - 06 - 15));
            Drink BulmersPintBottle = new Drink("Bulmers Pint Bottle", 5.40, DrinkType.BottledBeer, new DateTime(2020 - 03 - 06));
            Drink KopparbergBottleStrawberryAndLime = new Drink("Kopparberg Bottle (strawberry + lime)", 6.00, DrinkType.BottledBeer, new DateTime(2020 - 05 - 10));
            Drink Coke = new Drink("Coke", 2.80, DrinkType.Draught, new DateTime(2020 - 06 - 12));
            Drink DietCoke = new Drink("Diet Coke", 2.80, DrinkType.Minerals, new DateTime(2020 - 06 - 12));
            Drink CokeZero = new Drink("Coke Zero", 2.80, DrinkType.Minerals, new DateTime(2020 - 07 - 05));
            Drink SevenUp = new Drink("Seven Up", 2.80, DrinkType.Minerals, new DateTime(2020 - 10 - 18));
            Drink SevenUpFree = new Drink("SevenUp Free", 2.80, DrinkType.Minerals, new DateTime(2020 - 11 - 12));
            Drink BallygowanSparkling = new Drink("Ballygowan Sparkling", 2.90, DrinkType.Minerals, new DateTime(2021 - 03 - 18));
            Drink BallygowanStill = new Drink("BallygowanStill", 2.80, DrinkType.Minerals, new DateTime(2021 - 04 - 13));
            Drink TonicWater = new Drink("TonicWater", 2.00, DrinkType.Babies, new DateTime(2020 - 02 - 21));
            Drink SlimlineTonicWater = new Drink("Slimline Tonic Water", 2.00, DrinkType.Babies, new DateTime(2020 - 06 - 11));
            Drink SodaWater = new Drink("Soda Water", 2.00, DrinkType.Babies, new DateTime(2020 - 09 - 28));
            Drink Lemonade = new Drink("Lemonade", 2.00, DrinkType.Babies, new DateTime(2020 - 12 - 14));
            Drink Dash = new Drink("Dash", 0.80, DrinkType.Minerals, new DateTime(2021 - 01 - 29));
            Drink BitterLemon = new Drink("Bitter Lemon", 2.00, DrinkType.Babies, new DateTime(2020 - 03 - 19));
            Drink GingerAle = new Drink("Ginger Ale", 2.00, DrinkType.Babies, new DateTime(2020 - 06 - 03));
            Drink OrangeJuice = new Drink("Orange Juice", 2.00, DrinkType.Juices, new DateTime(2020 - 06 - 27));
            Drink AppleJuice = new Drink("Apple Juice", 2.00, DrinkType.Juices, new DateTime(2021 - 03 - 06));
            Drink PineappleJuice = new Drink("Pineapple Juice", 2.00, DrinkType.Juices, new DateTime(2021 - 03 - 24));
            Drink TomatoJuice = new Drink("Tomato Juice", 2.00, DrinkType.Juices, new DateTime(2021 - 04 - 03));
            Drink FevertreeTonic = new Drink("Fevertree Tonic", 2.00, DrinkType.Minerals, new DateTime(2021 - 04 - 23));
            Drink FevertreeTonicElderflower = new Drink("Fevertree Tonic Elderflower", 2.00, DrinkType.Minerals, new DateTime(2021 - 05 - 25));
            Drink SmirnoffVodka = new Drink("Smirnoff Vodka", 4.30, DrinkType.Vodkas, new DateTime(2020 - 04 - 19));
            Drink Hennessy = new Drink("Hennessy", 5.00, DrinkType.Liqueurs, new DateTime(2020 - 04 - 19));
            Drink Jameson = new Drink("Jameson", 4.30, DrinkType.Whiskeys, new DateTime(2020 - 04 - 28));
            Drink Powers = new Drink("Powers", 4.30, DrinkType.Whiskeys, new DateTime(2020 - 05 - 26));
            Drink Bushmills = new Drink("Bushmills", 4.30, DrinkType.Whiskeys, new DateTime(2020 - 07 - 11));
            Drink CorkDryGin = new Drink("Cork Dry Gin", 4.30, DrinkType.Gins, new DateTime(2020 - 05 - 07));
            Drink GordonsGin = new Drink("Gordon's Gin", 4.30, DrinkType.Gins, new DateTime(2020 - 06 - 08));
            Drink BombayGin = new Drink("Bombay Gin", 5.00, DrinkType.Gins, new DateTime(2020 - 06 - 09));
            Drink TanquerayGin = new Drink("Tanqueray Gin", 7.00, DrinkType.Gins, new DateTime(2020 - 06 - 22));
            Drink MethodAndMadnessGin = new Drink("Method And Madness Gin", 5.50, DrinkType.Gins, new DateTime(2020 - 07 - 31));
            Drink GordonsPinkGin = new Drink("Gordon's Pink Gin", 4.50, DrinkType.Gins, new DateTime(2021 - 03 - 24));
            Drink AbsoluteVodka = new Drink("Absolute Vodka", 4.50, DrinkType.Vodkas, new DateTime(2021 - 04 - 16));
            Drink MickeyFinns = new Drink("Mickey Finns", 4.80, DrinkType.Shots, new DateTime(2021 - 05 - 11));
            Drink Aftershock = new Drink("Aftershock", 5.00, DrinkType.Shots, new DateTime(2021 - 05 - 25));
            Drink Sambuca = new Drink("Sambuca", 5.00, DrinkType.Shots, new DateTime(2021 - 10 - 18));
            Drink Tequila = new Drink("Tequila", 5.00, DrinkType.Shots, new DateTime(2020 - 03 - 31));
            Drink GoldSlanger = new Drink("Gold Slanger", 5.00, DrinkType.Shots, new DateTime(2020 - 06 - 08));
            Drink TequilaRose = new Drink("TequilaRose", 5.00, DrinkType.Shots, new DateTime(2021 - 02 - 01));
            Drink Jagermeister = new Drink("Jagermeister", 5.00, DrinkType.Shots, new DateTime(2021 - 02 - 11));
            Drink RedBull = new Drink("RedBull", 4.30, DrinkType.Minerals, new DateTime(2021 - 03 - 03));
            Drink MixedShots = new Drink("Mixed Shots", 5.00, DrinkType.Shots, new DateTime(2021 - 07 - 14));
            Drink GlassOfWine = new Drink("Glass Of Wine", 6.00, DrinkType.Wine, new DateTime(2021 - 08 - 20));
            Drink Americano = new Drink("Americano", 3.00, DrinkType.TeasAndCoffees, new DateTime(2021 - 08 - 20));
            Drink Cappucino = new Drink("Cappucino", 3.00, DrinkType.TeasAndCoffees, new DateTime(2021 - 08 - 20));
            Drink Tea = new Drink("Tea", 2.00, DrinkType.TeasAndCoffees, new DateTime(2021 - 08 - 20));
            #endregion objects

            #region addToDefaultList
            //
            Default.Add(Guinness);
            Default.Add(Smithwicks);
            Default.Add(Heineken);
            Default.Add(GlassOfWine);
            Default.Add(CoorsLight);
            Default.Add(SmirnoffVodka);
            Default.Add(Dash);
            Default.Add(Corona);
            Default.Add(Miller);
            Default.Add(GordonsGin);
            Default.Add(Coke);
            Default.Add(TonicWater);
            Default.Add(Hennessy);
            Default.Add(Jameson);
            #endregion addToDefaultList

            #region addToDraughtList
            //
            Draught.Add(Guinness);
            Draught.Add(Smithwicks);
            Draught.Add(Heineken);
            Draught.Add(CoorsLight);
            Draught.Add(Budweiser);
            Draught.Add(OrchardThieves);
            Draught.Add(Bulmers);
            Draught.Add(Carling);
            Draught.Add(Carlsberg);
            Draught.Add(RockshoreCider);
            Draught.Add(RockshoreLager);
            Draught.Add(Sullivans);
            #endregion addToDraughtList

            #region addToMineralsList
            //
            Minerals.Add(Coke);
            Minerals.Add(DietCoke);
            Minerals.Add(CokeZero);
            Minerals.Add(SevenUp);
            Minerals.Add(SevenUpFree);
            Minerals.Add(RedBull);
            Minerals.Add(FevertreeTonic);
            Minerals.Add(FevertreeTonicElderflower);
            Minerals.Add(BallygowanStill);
            Minerals.Add(BallygowanSparkling);
            #endregion addToMineralsList

            #region addToJuicesList
            //
            Juices.Add(OrangeJuice);
            Juices.Add(AppleJuice);
            Juices.Add(PineappleJuice);
            Juices.Add(TomatoJuice);
            #endregion addToJuicesList

            #region addToBabiesList
            //
            Babies.Add(TonicWater);
            Babies.Add(SlimlineTonicWater);
            Babies.Add(GingerAle);
            Babies.Add(Lemonade);
            Babies.Add(BitterLemon);
            Babies.Add(SodaWater);
            #endregion addToBabiesList

            #region addToWineList
            //
            Wine.Add(GlassOfWine);
            #endregion addToWineList

            #region addToTeasAndCoffeesList
            //
            Teas_And_Coffees.Add(Tea);
            Teas_And_Coffees.Add(Cappucino);
            Teas_And_Coffees.Add(Americano);

            #endregion addToTeasAndCoffeesList

            #region addToBottledBeerList
            //
            Bottled_Beer.Add(Corona);
            Bottled_Beer.Add(Miller);
            Bottled_Beer.Add(WKD);
            Bottled_Beer.Add(SmirnoffIce);
            Bottled_Beer.Add(BulmersLongneck);
            Bottled_Beer.Add(BulmersPintBottle);
            Bottled_Beer.Add(Douraq);
            Bottled_Beer.Add(GingerBeer);
            Bottled_Beer.Add(CoorsLightBottle);
            Bottled_Beer.Add(BudweiserBottle);
            Bottled_Beer.Add(RockshoreCiderBottle);
            Bottled_Beer.Add(RockshoreLagerBottle);
            Bottled_Beer.Add(KopparbergBottleStrawberryAndLime);
            #endregion addToBottledBeerList

            #region addToGinsList
            //
            Gins.Add(GordonsGin);
            Gins.Add(GordonsPinkGin);
            Gins.Add(TanquerayGin);
            Gins.Add(CorkDryGin);
            Gins.Add(MethodAndMadnessGin);
            Gins.Add(BombayGin);
            #endregion addToGinsList

            #region addToWhiskeysList
            //
            Whiskeys.Add(Bushmills);
            Whiskeys.Add(Jameson);
            Whiskeys.Add(Powers);
            #endregion addToWhiskeysList

            #region addToVodkasList
            //
            Vodkas.Add(SmirnoffVodka);
            Vodkas.Add(AbsoluteVodka);
            #endregion addToVodkasList

            #region addToShotsList
            //
            Shots.Add(GoldSlanger);
            Shots.Add(Jagermeister);
            Shots.Add(Tequila);
            Shots.Add(TequilaRose);
            Shots.Add(Sambuca);
            Shots.Add(MickeyFinns);
            Shots.Add(Aftershock);
            Shots.Add(MixedShots);
            #endregion addToShotsList
        }
    }
}
