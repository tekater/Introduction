using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static readonly string delimeter = "\n------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine("Массив");
			Console.WriteLine($"Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			Random rand = new Random(0);

			FillRand(arr);
			Print(arr);

			Console.WriteLine($"Сумма всех элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее арифметическое: {arr.Average()}");
			Console.WriteLine($"Min: {arr.Min()}");
			Console.WriteLine($"Max : {arr.Max()}");

			Console.WriteLine(delimeter);
            
			//////////////////////////////////////////////////////////////////////////
			
			
			n = Convert.ToInt32(Console.ReadLine());
			double[] d_arr = new double[n];

			FillRand(d_arr);
			Print(d_arr);

			Console.WriteLine($"Сумма всех элементов массива: {d_arr.Sum()}");
			Console.WriteLine($"Среднее арифметическое: {d_arr.Average()}");
			Console.WriteLine($"Min: {d_arr.Min()}");
			Console.WriteLine($"Max : {d_arr.Max()}");

			Console.WriteLine(delimeter);


			//////////////////////////////////////////////////////////////////////////

			Console.WriteLine("Двумерный Массив");
			Console.WriteLine($"Введите кол-во строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Введите кол-во элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] arr2 = new int[rows, cols];

			FillRand(arr2);
			Print(arr2);
			//Console.WriteLine(arr2);

			Console.WriteLine($"Сумма всех элементов массива: {arr2.Cast<int>().Sum()}");
			Console.WriteLine($"Среднее арифметическое: {arr2.Cast<int>().Average()}");
			Console.WriteLine($"Min: {arr2.Cast<int>().Min()}");
			Console.WriteLine($"Max : {arr2.Cast<int>().Max()}");

			Console.WriteLine("foreach");
			foreach (int i in arr2)
			{
				Console.WriteLine(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine(delimeter);

			////////////////////////////////////////////////////////////////

			Console.WriteLine("Динамический Двумерный Массив");
			Console.WriteLine($"Введите кол-во строк: ");
			int rowsd = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Введите кол-во строк строки: ");
			int colsd = Convert.ToInt32(Console.ReadLine());

			int[][] arrd = new int[rowsd][];
			for (int i = 0; i < rowsd; i++)
			{
				arrd[i] = new int[colsd];
				for (int j = 0; j < colsd; j++)
				{
					arrd[i][j] = rand.Next(10);
				}
			}

			for (int i = 0; i < rowsd; i++)
			{
				for (int j = 0; j < colsd; j++)
				{
					Console.Write($"{arrd[i][j]}\t");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine(delimeter);

			////////////////////////////////////////////////////////////////

			Console.WriteLine("Зубчатый Массив");
			{

				int[][] j_arr = new int[][]
				{
					new int[]{3,5,8,13,21},
					new int[]{34,55,89},
					new int[]{144,233,377,510}
				};

				for (int i = 0; i < j_arr.Length; i++)
				{
					for (int j = 0; j < j_arr[i].Length; j++)
					{
						Console.WriteLine($"{j_arr[i][j]} \t");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
				Console.WriteLine(delimeter);

			}

			////////////////////////////////////////////////////////////////
			Console.WriteLine("Зубчатый Массив с Двумерными массивами");
			int[][,] j_arr2 = new int[][,]
			{
				arr2,
				new int[,]
				{
					{ 2, 5, 6, 7, 8 },
					{20, 50, 60, 70, 80 }
				}
			};

			////////////////////////////////////////////////////////////////

			Console.WriteLine("Трёхмерный Массив");
			Console.WriteLine($"Введите кол-во строк: ");
			int rows1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Введите кол-во строк строки: ");
			int cols1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Введите кол-во элементов строки: ");
			int cols2 = Convert.ToInt32(Console.ReadLine());

			int[,,] arr3 = new int[rows, cols, cols1];
			for (int i = 0; i < rows1; i++)
			{
				for (int j = 0; j < cols1; j++)
				{
					for (int z = 0; z < cols2; z++)
					{
						arr3[i, j, z] = rand.Next(100);
					}
				}
			}

			for (int i = 0; i < arr3.GetLength(0); i++)
			{
				for (int j = 0; j < arr3.GetLength(1); j++)
				{
					for (int z = 0; z < arr3.GetLength(2); z++)
					{
						Console.Write($"{arr3[i, j, z]}\t");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
			}

			Console.WriteLine(delimeter);

			////////////////////////////////////////////////////////////////
		}

		public static void FillRand(int[] arr)
		{
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100,200)/10;
			}
		}
		public static void FillRand(int[,] arr)
		{
			Random rand = new Random(0);
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j= 0; j < arr.GetLength(1); j++)
				{
					arr[i,j] = rand.Next(100, 200) / 10;
				}
			}
		}

		public static void FillRand(double[] arr)
		{
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.NextDouble();
			}
		}

		public static void FillRand

		public static void Print<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"{arr[i]}\t");

			}
			Console.WriteLine();
		}
		public static void Print<T>(T[,] arr)
		{
			for(int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write($"{arr[i, j]}\t");
				}
				Console.WriteLine();
			}
		}













		/// не нужно
		/*public static int minValueIn(int[] arr)
		{
			int min = arr[0];
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}
			return min;
		}

		public static int maxValueIn(int[] arr)
		{
			int max = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			return max;
		}

		public static int Sum(int[] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			return sum;
		}

		public static double Avg(int[] arr)
		{
			return (double)Sum(arr) / arr.Length;
		}
		*/





	}
}
