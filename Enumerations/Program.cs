using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
	internal class Program
	{
		static readonly string delimeter = "\n------------------------------------------\n";
		static void Main(string[] args)
		{

			DayOfWeek day = DayOfWeek.Friday;

            Console.WriteLine($"Day - {day}\n");
			string[] dayName = Enum.GetNames(typeof(DayOfWeek));

			for (int i = 0; i < dayName.Length; i++)
			{
                Console.WriteLine($"{i}: {dayName[i]}");
            }

            Console.WriteLine($"\n{delimeter}");



			DistanceFromSun dfs = DistanceFromSun.Earth;

            Console.WriteLine($"DFS:\nEarth - {dfs.GetHashCode()}\n");

			string[] distNames = Enum.GetNames(typeof(DistanceFromSun));
			ulong[] distValues = (ulong[])Enum.GetValues(typeof(DistanceFromSun));

			for(int i = 0; i < distNames.Length; i++)
			{
				Console.WriteLine($"{distNames[i]}\t - {distValues[i]}");
            }
			Console.WriteLine(Enum.GetUnderlyingType(typeof(DistanceFromSun)));
        }
		enum DayOfWeek { Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday };

		enum DistanceFromSun :ulong { 
		Sun = 0,
		Mercury = 57900000,
		Venus   = 108200000,
		Earth    = 149600000
		};

	}
}
