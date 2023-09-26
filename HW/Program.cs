using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task1
			{
				Console.WriteLine($"Преобразование числа в денежный формат.\nВведите дробное число: ");
				double money = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine($"{money} грн. - это {(int)money}грн. {(int)((money - (int)money) * 100)} коп.");
			}

			//Task2
			{
				Console.WriteLine($"\nВычисление стоимости покупки.\nВведите исходные данные: ");

				Console.WriteLine($"Цена тетради: ");
				double cost1 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine($"Количество тетрадей: ");
				int count1 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine($"Цена карандаша: ");
				double cost2 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine($"Количество карандашей: ");
				int count2 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine($"Стоимость покупки: {(cost1 * count1) + (cost2 * count2)} грн.");
			}

			//Task3
			{
				Console.WriteLine($"\nВычисление стоимости покупки.\nВведите исходные данные: ");

				Console.WriteLine($"Цена тетради: ");
				double cost1 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine($"Цена обложки: ");
				double cost2 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine($"Количество комплектов: ");
				int count1 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine($"Стоимость покупки: {(cost1 + cost2) * count1} грн.");
			}

			//Task4
			{
                Console.WriteLine($"\nВычисление стоимости поездки на дачу и обратно");

				Console.WriteLine($"Расстояние до дачи (км): ");
                int km = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine($"Расход бензина (литров на 100км пробега): ");
				double consumption = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine($"цена 1 литра бензина: ");
				double cost = Convert.ToDouble(Console.ReadLine());

				Console.Write($"Поездка на дачу обойдётся в:{ (int)((km / (consumption* 0.1))  * cost)} грн. ");
				Console.Write($"{(int)((((km / (consumption * 0.1)) * cost) - (int)((km / (consumption * 0.1)) * cost)) * 100)} коn.\n");

			}

            Console.WriteLine("~Калькулятор");

            Console.WriteLine("Введите ваше выражение: ");
			string calc = Console.ReadLine();

            Console.WriteLine();
        }
	}
}
