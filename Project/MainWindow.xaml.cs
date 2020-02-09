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
            Drink SmirnoffIce = new Drink("SmirnoffIce", 5.30, DrinkType.BottledBeer, new DateTime(2020 - 01 - 29));
            Drink CoorsLightBottle = new Drink("CoorsLightBottle", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 03 - 26));
            Drink Corona = new Drink("Corona", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 05 - 21));
            Drink Miller = new Drink("Miller", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 06 - 05));
            Drink BudweiserBottle = new Drink("BudweiserBottle", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 05 - 25));
            Drink RockshoreLagerBottle= new Drink("RockshoreLagerBottle", 4.80, DrinkType.BottledBeer, new DateTime(2020 - 04 - 03));
            Drink RockshoreCiderBottle = new Drink("RockshoreCiderBottle", 5.00, DrinkType.BottledBeer, new DateTime(2020 - 04 - 27));
            Drink GingerBeer = new Drink("GingerBeer", 6.50, DrinkType.BottledBeer, new DateTime(2020 - 04 - 27));
            Drink Douraq = new Drink("Douraq", 6.50, DrinkType.BottledBeer, new DateTime(2020 - 06 - 01));
            Drink BulmersLongneck = new Drink("BulmersLongneck", 4.70, DrinkType.BottledBeer, new DateTime(2020 - 06 - 15));
            Drink BulmersPintBottle = new Drink("BulmersPintBottle", 5.40, DrinkType.BottledBeer, new DateTime(2020 - 03 - 06));
            Drink KopparbergBottle = new Drink("KopparbergBottle", 6.00, DrinkType.BottledBeer, new DateTime(2020 - 05 - 10));
            Drink Coke = new Drink("Coke", 2.80, DrinkType.Draught, new DateTime(2020 - 06 - 12));
            Drink DietCoke = new Drink("DietCoke", 2.80, DrinkType.Minerals, new DateTime(2020 - 06 - 12));
            Drink CokeZero = new Drink("CokeZero", 2.80, DrinkType.Minerals, new DateTime(2020 - 07 - 05));
            Drink SevenUp = new Drink("SevenUp", 2.80, DrinkType.Minerals, new DateTime(2020 - 10 - 18));
            Drink SevenUpFree = new Drink("SevenUpFree", 2.80, DrinkType.Minerals, new DateTime(2020 - 11 - 12));
            Drink BallygowanSparkling = new Drink("BallygowanSparkling", 2.90, DrinkType.Minerals, new DateTime(2021 - 03 - 18));
            Drink BallygowanStill = new Drink("BallygowanStill", 2.80, DrinkType.Minerals, new DateTime(2021 - 04 - 13));
            Drink TonicWater = new Drink("TonicWater", 2.00, DrinkType.Babies, new DateTime(2020 - 02 - 21));
            Drink SlimlineTonicWater = new Drink("SlimlineTonicWater", 2.00, DrinkType.Babies, new DateTime(2020 - 06 - 11));
            Drink SodaWater = new Drink("SodaWater", 2.00, DrinkType.Babies, new DateTime(2020 - 09 - 28));
            Drink Lemonade = new Drink("Lemonade", 2.00, DrinkType.Babies, new DateTime(2020 - 12 - 14));
            Drink Dash = new Drink("Dash", 0.80, DrinkType.Minerals, new DateTime(2021 - 01 - 29));
            Drink BitterLemon = new Drink("BitterLemon", 2.00, DrinkType.Babies, new DateTime(2020 - 03 - 19));
            Drink GingerAle = new Drink("GingerAle", 2.00, DrinkType.Babies, new DateTime(2020 - 06 - 03));
            Drink OrangeJuice = new Drink("OrangeJuice", 2.00, DrinkType.Juices, new DateTime(2020 - 06 - 27));
            Drink AppleJuice = new Drink("AppleJuice", 2.00, DrinkType.Juices, new DateTime(2021 - 03 - 06));
            Drink PineappleJuice = new Drink("PineappleJuice", 2.00, DrinkType.Juices, new DateTime(2021 - 03 - 24));
            Drink TomatoJuice = new Drink("TomatoJuice", 2.00, DrinkType.Juices, new DateTime(2021 - 04 - 03));
            Drink FevertreeTonic = new Drink("FevertreeTonic", 2.00, DrinkType.Minerals, new DateTime(2021 - 04 - 23));
            Drink FevertreeTonicElderflower = new Drink("FevertreeTonicElderflower", 2.00, DrinkType.Minerals, new DateTime(2021 - 05 - 25));
            Drink SmirnoffVodka = new Drink("SmirnoffVodka", 4.30, DrinkType.Vodkas, new DateTime(2020 - 04 - 19));
            Drink Hennessy = new Drink("Hennessy", 5.00, DrinkType.Liqueurs, new DateTime(2020 - 04 - 19));
            Drink Jameson = new Drink("Jameson", 4.30, DrinkType.Whiskeys, new DateTime(2020 - 04 - 28));
            Drink Powers = new Drink("Powers", 4.30, DrinkType.Whiskeys, new DateTime(2020 - 05 - 26));
            Drink Bushmills = new Drink("Bushmills", 4.30, DrinkType.Whiskeys, new DateTime(2020 - 07 - 11));
            Drink CorkDryGin = new Drink("CorkDryGin", 4.30, DrinkType.Gins, new DateTime(2020 - 05 - 07));
            Drink GordonsGin = new Drink("GordonsGin", 4.30, DrinkType.Gins, new DateTime(2020 - 06 - 08));
            Drink BombayGin = new Drink("BombayGin", 5.00, DrinkType.Gins, new DateTime(2020 - 06 - 09));
            Drink TanquerayGin = new Drink("TanquerayGin", 7.00, DrinkType.Gins, new DateTime(2020 - 06 - 22));
            Drink MethodAndMadnessGin = new Drink("MethodAndMadnessGin", 5.50, DrinkType.Gins, new DateTime(2020 - 07 - 31));
            Drink GordonsPinkGin = new Drink("GordonsPinkGin", 4.50, DrinkType.Gins, new DateTime(2021 - 03 - 24));
            Drink AbsoluteVodka = new Drink("AbsoluteVodka", 4.50, DrinkType.Vodkas, new DateTime(2021 - 04 - 16));
            Drink MickeyFinns = new Drink("MickeyFinns", 4.80, DrinkType.Shots, new DateTime(2021 - 05 - 11));
            Drink Aftershock = new Drink("Aftershock", 5.00, DrinkType.Shots, new DateTime(2021 - 05 - 25));
            Drink Sambuca = new Drink("Sambuca", 5.00, DrinkType.Shots, new DateTime(2021 - 10 - 18));
            Drink Tequila = new Drink("Tequila", 5.00, DrinkType.Shots, new DateTime(2020 - 03 - 31));
            Drink GoldSlanger = new Drink("GoldSlanger", 5.00, DrinkType.Shots, new DateTime(2020 - 06 - 08));
            Drink TequilaRose = new Drink("TequilaRose", 5.00, DrinkType.Shots, new DateTime(2021 - 02 - 01));
            Drink Jagermeister = new Drink("Jagermeister", 5.00, DrinkType.Shots, new DateTime(2021 - 02 - 11));
            Drink RedBull = new Drink("RedBull", 4.30, DrinkType.Minerals, new DateTime(2021 - 03 - 03));
            Drink MixedShots = new Drink("MixedShots", 5.00, DrinkType.Shots, new DateTime(2021 - 07 - 14));
            Drink GlassOfWine = new Drink("Glass Of Wine", 6.00, DrinkType.Wine, new DateTime(2021 - 08 - 20));
            #endregion objects

        }
    }
}
