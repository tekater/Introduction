
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Drob
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Drob A = new Drob();
			//A.setAns(22);
			//A.setChislit(33);
			//A.setZnamenat(44);

			A.Ans = 123;
			A.Chislit = 456;
			A.Znamen = 789;

			A.Print();

			Console.WriteLine("\n-----------------------\n");


			Drob B = new Drob(5);
			B.Print();

			Console.WriteLine("\n-----------------------\n");

			Drob C = new Drob(2,3,5);
			C.Print();
			C.Fdel(1,2);
			C.Fmult(1, 2);
			C.Fplus(1, 2);
			C.Fmin(1, 2);

            Console.WriteLine("\n-----------------------\n");

            Drob D = new Drob(2,3,5);
			D.Print();

			Drob G = new Drob(2.75);
			G.Print();
		}


	}
}

