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
        List<Drink> Wine = new List<Drink>();
        List<Drink> Teas_And_Coffees = new List<Drink>();
        List<Drink> Bottled_Beer = new List<Drink>();
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
            Drink SmirnoffIce = new Drink("SmirnoffIce", 5.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink CoorsLightBottle = new Drink("CoorsLightBottle", 4.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Corona = new Drink("Corona", 4.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Miller = new Drink("Miller", 4.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink BudweiserBottle = new Drink("BudweiserBottle", 4.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink RockshoreLagerBottle= new Drink("RockshoreLagerBottle", 4.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink RockshoreCiderBottle = new Drink("RockshoreCiderBottle", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink GingerBeer = new Drink("GingerBeer", 6.50, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Douraq = new Drink("Douraq", 6.50, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink BulmersLongneck = new Drink("BulmersLongneck", 4.70, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink BulmersPintBottle = new Drink("BulmersPintBottle", 5.40, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink KopparbergBottle = new Drink("KopparbergBottle", 6.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Coke = new Drink("Coke", 2.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink DietCoke = new Drink("DietCoke", 2.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink CokeZero = new Drink("CokeZero", 2.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink SevenUp = new Drink("SevenUp", 2.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink SevenUpFree = new Drink("SevenUpFree", 2.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink BallygowanSparkling = new Drink("BallygowanSparkling", 2.90, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink BallygowanStill = new Drink("BallygowanStill", 2.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink TonicWater = new Drink("TonicWater", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink SlimlineTonicWater = new Drink("SlimlineTonicWater", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink SodaWater = new Drink("SodaWater", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Lemonade = new Drink("Lemonade", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Dash = new Drink("Dash", 0.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink BitterLemon = new Drink("BitterLemon", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink GingerAle = new Drink("GingerAle", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink OrangeJuice = new Drink("OrangeJuice", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink AppleJuice = new Drink("AppleJuice", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink PineappleJuice = new Drink("PineappleJuice", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink TomatoJuice = new Drink("TomatoJuice", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink FevertreeTonic = new Drink("FevertreeTonic", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink FevertreeTonicElderflower = new Drink("FevertreeTonicElderflower", 2.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink SmirnoffVodka = new Drink("SmirnoffVodka", 4.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Hennessy = new Drink("Hennessy", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Jameson = new Drink("Jameson", 4.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Powers = new Drink("Powers", 4.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Bushmills = new Drink("Bushmills", 4.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink CorkDryGin = new Drink("CorkDryGin", 4.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink GordonsGin = new Drink("GordonsGin", 4.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink BombayGin = new Drink("BombayGin", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink TanquerayGin = new Drink("TanquerayGin", 7.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink MethodAndMadnessGin = new Drink("MethodAndMadnessGin", 5.50, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink GordonsPinkGin = new Drink("GordonsPinkGin", 4.50, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink AbsoluteVodka = new Drink("AbsoluteVodka", 4.50, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink MickeyFinns = new Drink("MickeyFinns", 4.80, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Aftershock = new Drink("Aftershock", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Sambuca = new Drink("Sambuca", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Tequila = new Drink("Tequila", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink GoldSlanger = new Drink("GoldSlanger", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink TequilaRose = new Drink("TequilaRose", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink Jagermeister = new Drink("Jagermeister", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink RedBull = new Drink("RedBull", 4.30, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            Drink MixedShots = new Drink("MixedShots", 5.00, DrinkType.Draught, new DateTime(2020 - 01 - 29));
            #endregion objects

        }
    }
}
