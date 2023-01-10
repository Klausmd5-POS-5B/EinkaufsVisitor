using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ElementLib;

namespace EinkaufswagenVisitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
        }

        private void PanButtons_Click(object sender, RoutedEventArgs e)
        {
            var snd = (e.Source as Button);
            Console.WriteLine(snd.Content);

            Console.WriteLine(snd.Content.ToString().GetMeth().ResultString);

        }

        private void BtnAddClicked(object sender, RoutedEventArgs e)
        {
            var content = panCategories.Children.Cast<RadioButton>().First(x => x.IsChecked == true).Content.ToString();

            var name = txtName.Text;
            var price = txtPricePerUnit.Text;
            var units = sldUnits.Value;
            var weight = sldWeight.Value;

            var trg = Target.Children.Cast<RadioButton>().First(x => x.IsChecked == true).Content.ToString();

            var elem = content.GetElem();
            elem.PricePerUnit = Convert.ToDouble(price);
            elem.Weight = (int)weight;
            elem.NrUnits = (int)units;
            if (name != "xxx" && name.Length > 0)
            {
                elem.Name = name;
            }

            if (trg == "Einkaufswagen")
            {
                lstCart.Items.Add(elem);
            }
            else
            {
                lstBag.Items.Add(elem);
            }
        }
    }
}