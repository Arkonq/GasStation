using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace GasStation
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		static string gasType;
		static int gasPrice;
		Prices prices = new Prices
		{
			Ai80 = 150,
			Ai92 = 160,
			Ai95 = 170,
			Ai98 = 180,
			Chocolate = 200,
			Water = 100,
			Cigarettes = 450,
			Chips = 350,
			Food = 200,
			Juice = 200
		};

		public MainWindow()
		{
			InitializeComponent();

		}

		private void ai80RBChecked(object sender, RoutedEventArgs e)
		{
			litresCnt.Visibility = Visibility.Visible;
			gasType = ai80RB.Content.ToString();
			gasPrice = prices.Ai80;
		}

		private void ai92RBChecked(object sender, RoutedEventArgs e)
		{
			litresCnt.Visibility = Visibility.Visible;
			gasType = ai92RB.Content.ToString();
			gasPrice = prices.Ai92;
		}

		private void ai95RBChecked(object sender, RoutedEventArgs e)
		{
			litresCnt.Visibility = Visibility.Visible;
			gasType = ai95RB.Content.ToString();
			gasPrice = prices.Ai95;
		}

		private void ai98RBChecked(object sender, RoutedEventArgs e)
		{
			litresCnt.Visibility = Visibility.Visible;
			gasType = ai98RB.Content.ToString();
			gasPrice = prices.Ai98;
		}

		private void chocolateChecked(object sender, RoutedEventArgs e)
		{
			chocolateCnt.Visibility = Visibility.Visible;
		}

		private void waterChecked(object sender, RoutedEventArgs e)
		{
			waterCnt.Visibility = Visibility.Visible;
		}

		private void cigarettesChecked(object sender, RoutedEventArgs e)
		{
			cigarettesCnt.Visibility = Visibility.Visible;
		}

		private void chipsChecked(object sender, RoutedEventArgs e)
		{
			chipsCnt.Visibility = Visibility.Visible;
		}

		private void foodChecked(object sender, RoutedEventArgs e)
		{
			foodCnt.Visibility = Visibility.Visible;
		}

		private void juiceChecked(object sender, RoutedEventArgs e)
		{
			juiceCnt.Visibility = Visibility.Visible;
		}

		private void buyClicked(object sender, RoutedEventArgs e)
		{
			Bill bill = new Bill
			{
				GasType = gasType,
				LitresCnt = Int32.Parse(litresCnt.textNum.Text),
				ChocolateCnt = Int32.Parse(chocolateCnt.textNum.Text),
				WaterCnt =		Int32.Parse(waterCnt.textNum.Text),
				CigaretteCnt =	Int32.Parse(cigarettesCnt.textNum.Text),
				ChipsCnt =		Int32.Parse(chipsCnt.textNum.Text),
				FoodCnt =		Int32.Parse(foodCnt.textNum.Text),
				JuiceCnt =		Int32.Parse(juiceCnt.textNum.Text),
				TotalPrice = 
				(gasPrice * Int32.Parse(litresCnt.textNum.Text)) + 
				(prices.Chocolate * Int32.Parse(chocolateCnt.textNum.Text)) +
				(prices.Water * Int32.Parse(waterCnt.textNum.Text)) +
				(prices.Cigarettes * Int32.Parse(cigarettesCnt.textNum.Text)) +
				(prices.Chips * Int32.Parse(chipsCnt.textNum.Text)) +
				(prices.Food * Int32.Parse(foodCnt.textNum.Text)) +
				(prices.Juice * Int32.Parse(juiceCnt.textNum.Text))
			};
			MessageBox.Show(bill.ToString());
		}
	}
}
