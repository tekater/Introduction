using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimeter = "\n---------------------------\n";
		static void Main(string[] args)
		{
			// Object
			Console.WriteLine("BOOL:");
			Console.WriteLine($"sizeof(bool) - {sizeof(bool)}"); // Boolean
            Console.WriteLine($"true - {true}");
            Console.WriteLine($"true.GetType() - {true.GetType()}");
            Console.Write($"3 + 2.6 = {3 + 2.6} - {(3 + 2.6).GetType()}\n");

            Console.WriteLine(delimeter);

            Console.WriteLine("CHAR:");
            Console.Write($"sizeof(char) - {sizeof(char)}\n");
			Console.WriteLine($"MinValue: {(int)(char.MinValue)}");
			Console.WriteLine($"MaxValue: {(int)(char.MaxValue)}");

            Console.WriteLine(delimeter);

            Console.WriteLine("SHORT");
            Console.WriteLine($"sizeof(short) - {sizeof(short)}");
			Console.WriteLine($"MinValue: {(short.MinValue)}");
			Console.WriteLine($"MaxValue: {(short.MaxValue)}");

            Console.WriteLine(delimeter);

			Console.WriteLine("USHORT");
			Console.WriteLine($"sizeof(ushort) - {sizeof(ushort)}");
			Console.WriteLine($"MinValue: {(ushort.MinValue)}");
			Console.WriteLine($"MaxValue: {(ushort.MaxValue)}");

			Console.WriteLine(delimeter);

			Console.WriteLine("INT");
			Console.WriteLine($"sizeof(int) - {sizeof(int)}");
			Console.WriteLine($"MinValue: {(int.MinValue)}");
			Console.WriteLine($"MaxValue: {(int.MaxValue)}");

			Console.WriteLine(delimeter);

			Console.WriteLine("UINT");
			Console.WriteLine($"sizeof(uint) - {sizeof(uint)}");
			Console.WriteLine($"MinValue: {(uint.MinValue)}");
			Console.WriteLine($"MaxValue: {(uint.MaxValue)}");

			Console.WriteLine(delimeter);

			Console.WriteLine("LONG");
			Console.WriteLine($"sizeof(long) - {sizeof(long)}");
			Console.WriteLine($"MinValue: {(long.MinValue)}");
			Console.WriteLine($"MaxValue: {(long.MaxValue)}");

			Console.WriteLine(delimeter);

			Console.WriteLine("ULONG");
			Console.WriteLine($"sizeof(ulong) - {sizeof(ulong)}");
			Console.WriteLine($"MinValue: {(ulong.MinValue)}");
			Console.WriteLine($"MaxValue: {(ulong.MaxValue)}");

		}
	}
}
