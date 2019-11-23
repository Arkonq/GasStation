using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
	/// Логика взаимодействия для ControlQuantity.xaml
	/// </summary>
	public partial class ControlQuantity : UserControl
	{
		public ControlQuantity()
		{
			InitializeComponent();
			textNum.Text = _numValue.ToString();
		}


		private void TextBoxPreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !IsTextAllowed(e.Text);
		}

		private static readonly Regex _regex = new Regex("[^0-9.-]+");

		private bool IsTextAllowed(string text)
		{
			return !_regex.IsMatch(text);
		}

		private int _numValue = 0;

		public int NumValue {
			get { return _numValue; }
			set {
				_numValue = value;
				textNum.Text = value.ToString();
			}
		}

		private void cmdUpClicked(object sender, RoutedEventArgs e)
		{
			NumValue++;
		}

		private void cmdDownClicked(object sender, RoutedEventArgs e)
		{
			if(NumValue == 0) { return; }
			NumValue--;
		}

		private void textNumTextChanged(object sender, TextChangedEventArgs e)
		{
			if (textNum == null)
			{
				return;
			}

			if (!int.TryParse(textNum.Text, out _numValue))
				textNum.Text = _numValue.ToString();
		}

	}
}
