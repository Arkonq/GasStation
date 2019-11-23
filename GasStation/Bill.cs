using System;
using System.Collections.Generic;
using System.Text;

namespace GasStation
{
	public class Bill
	{
		public string GasType { get; set; }
		public int LitresCnt { get; set; }
		public int ChocolateCnt { get; set; }
		public int WaterCnt { get; set; }
		public int CigaretteCnt { get; set; }
		public int ChipsCnt { get; set; }
		public int FoodCnt { get; set; }
		public int JuiceCnt { get; set; }
		public int TotalPrice { get; set; }

		public override string ToString()
		{
			return $"GasType - {GasType}\n" +
				   $"Litres - {LitresCnt}\n" +
				   $"Chocolate - {ChocolateCnt}\n" +
				   $"Water - {WaterCnt}\n" +
				   $"Cigarettes - {CigaretteCnt}\n" +
				   $"Chips - {ChipsCnt}\n" +
				   $"Food - {FoodCnt}\n" +
				   $"Juice - {JuiceCnt}\n" +
				   $"Total - {TotalPrice}";
		}
	}
}
