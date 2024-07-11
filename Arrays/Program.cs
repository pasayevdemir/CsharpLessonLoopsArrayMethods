using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			double de,de1,de2,x1,x2;
			double[,] matris = new double[2,3];
			for (int i = 0; i < 2; i++)
            {
				for (int j = 0; j < 3; j++)
				{
					matris[i, j] = double.Parse(Console.OpenStandardInput().ToString());
				}
			}
				de = (matris[0,0] * matris[1,1]) - (matris[0,1] * matris[1,0]);
				de1 = (matris[0,2] * matris[1,1]) - (matris[0,1] * matris[1,2]);
				de2 = (matris[0,0] * matris[1,2]) - (matris[0,2] * matris[1,0]);
				x1 = de1 / de;
				x2 = de2 / de;
			NumberFormatInfo setPrecision = new NumberFormatInfo();
			setPrecision.NumberDecimalDigits = 3;
			Console.WriteLine(x1.ToString("N",setPrecision));
			Console.WriteLine(x2.ToString("N", setPrecision));
			Console.ReadKey();
		}
    }
}
