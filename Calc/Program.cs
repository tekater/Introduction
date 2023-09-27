using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine($"Введите арифметическое выражение: ");
			string expression = Console.ReadLine();
            //Console.WriteLine(expression);

			//string[] operands = expression.Split(new char[] { '+', '-', '*', '/' });
			string[] operands = expression.Split('+', '-', '*', '/');
			
			/*operands[0] = operands[0].Replace(" ", "");
			operands[1] = operands[1].Replace(" ", "");

			for (int i = 0; i < operands.Length; i++)
			{
				Console.WriteLine(operands[i]);
            }
			*/
			double a = Convert.ToDouble(operands[0]);
			double b = Convert.ToDouble(operands[1]);


			if (expression.Contains("+"))
			{
				Console.WriteLine($"{a} + {b} = {a + b}");
			}
			else if (expression.Contains("-"))
			{
				Console.WriteLine($"{a} - {b} = {a - b}");
			}
			else if (operands.Contains("*"))
			{
				Console.WriteLine($"{a} * {b} = {a * b}");
			}
			else if (operands.Contains("/"))
			{
				Console.WriteLine($"{a} / {b} = {a / b}");
			}
			else
			{
				Console.WriteLine($"Error");
			}
        }
	}
}
