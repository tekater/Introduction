using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferParameters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a;// = 2;
			int b;// = 3;

			Input(out a);
			Input(out b);

            Console.WriteLine($"\nPrint:\na - {a}\nb - {b}\n\nExchange: ");
            Exchange(ref a, ref b);
			Console.WriteLine($"a - {a}\nb - {b}");
		}
		static void Input(out int a)
		{
            Console.Write($"Введите число: ");
			a = Convert.ToInt32(Console.ReadLine());
        }
		static void Exchange(ref int a, ref int b)
		{
			int buffer = a;
			a = b;
			b = buffer;
		}
	}
}
