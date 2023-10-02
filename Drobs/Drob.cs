using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Drob
{
	internal class Drob
	{
		int znamen;

		public int Ans
		{
			/*
			get { return ans; }
			set { ans = value; }
			*/
			get;
			set;
		}
		public int Chislit
		{
			get;
			set;
		}
		public int Znamen
		{
			get { return znamen; }
			set { 
				if(value == 0)
				{
					value = 1;
				}
				znamen = value; 
			}
		}

		//				Constructor:
		public Drob()
		{
			Ans = 0;
			Chislit = 0;
			Znamen = 1;
			Console.WriteLine("Def Constructor");
		}
		public Drob(int ans)
		{
			Ans = ans;
			Znamen = 0;
			Chislit = 0;
			Console.WriteLine("1Arg Constructor");
		}
		public Drob(int chislit, int znamenat)
		{
			Ans = 0;
			Znamen = znamenat;
			Chislit = chislit;
			Console.WriteLine("2Arg Constructor");
		}
		public Drob(int ans, int chislit, int znamenat)
		{
			Chislit = (chislit);
			Znamen = (znamenat);
			Ans = (ans);
			Console.WriteLine("3Arg Constructor");
		}
		public Drob(double num)
		{
			Console.WriteLine("Double Constructor");
			Ans = (int)num;
			for (int i = 1; i < 10; i++)
			{
				for (int j = 1; j < 10; j++)
				{
					if ((double)i / j == (num - (int)num))
					{			
						Chislit = i;
						Znamen = j;
						return;
					}
				}
			}
		}

		public Drob(Drob other)
		{
			this.Ans = other.Ans;
			this.Chislit = other.Chislit;
			this.Znamen = other.Znamen;
            Console.WriteLine("Copy Constructor");
        }

		//				Operators

		public static Drob operator *(Drob left,Drob right)
		{
			Drob left_copy = new Drob();
			Drob right_copy = new Drob();
			left_copy.toImproper();
			right_copy.toImproper();
			return new Drob(left_copy.Chislit * right_copy.Chislit, left_copy.Znamen * right_copy.Znamen).toProper();
		}

		public static Drob operator /(Drob left,Drob right)
		{
			return left * right.Inverted();
		}


		//				Methods:

		public Drob toProper()
		{
			Ans += Chislit / Znamen;
			Chislit %= Znamen;
			return this;
		}

		public Drob toImproper()
		{
			Chislit += Ans * Znamen;
			Ans = 0;
			return this;
		}

		public Drob Inverted()
		{
			Drob inverted = new Drob(this);
			inverted.toImproper();
			(inverted.Chislit, inverted.Znamen) = (inverted.Znamen, inverted.Chislit);
			return inverted;
		}

		public void Print()
		{
			if (Ans != 0)
			{
				Console.Write(Ans);
			}
			if (Chislit != 0)
			{
				if (Ans != 0)
				{
					Console.Write($"(");
				}
				Console.Write($"{Chislit} / {Znamen}");
				if (Ans != 0)
				{
					Console.Write($")");
				}
			}
			else if (Ans == 0)
			{
				Console.Write(0);
			}
			Console.WriteLine("\n");
		}
		public void Print(int chislit,int znamen,int ans = 0)
		{
            Console.Write($"my drob:\n");
            if (Ans != 0)
			{
				Console.Write(Ans);
			}
			if (Chislit != 0)
			{
				if (Ans != 0)
				{
					Console.Write($"(");
				}
				Console.Write($"{Chislit} / {Znamen}");
				if (Ans != 0)
				{
					Console.Write($")");
				}
			}
			else if (Ans == 0)
			{
				Console.Write(0);
			}

			Console.WriteLine("\nsecond Drob");

			if (ans != 0)
			{
				Console.Write(ans);
			}
			if (chislit != 0)
			{
				if (ans != 0)
				{
					Console.Write($"(");
				}
				Console.Write($"{chislit} / {znamen}");
				if (ans != 0)
				{
					Console.Write($")");
				}
			}
			else if (ans == 0)
			{
				Console.Write(0);
			}
            Console.WriteLine("\n");
        }

		/////////////////////////////

		public override string ToString()
		{
			string output = "";
			if (Ans != 0)
			{
				output += Ans.ToString();
			}
			if (Chislit != 0)
			{
				if (Ans != 0)
				{
					Console.Write($"(");
				}
				Console.Write($"{Chislit} / {Znamen}");
				if (Ans != 0)
				{
					Console.Write($")");
				}
			}
			else if (Ans == 0)
			{
				output = "0";
			}
			Console.WriteLine("\n");

			return output;
		}

		/////////////////////////////


		public double mult_(int chislit, int znamen)
		{
			return ((double)Chislit / Znamen) * ((double)chislit / znamen);
		}
		public double min_(int chislit, int znamen)
		{
			return ((double)Chislit / Znamen) - ((double)chislit / znamen);
		}

		public double del_(int chislit, int znamen)
		{
			return ((double)Chislit / Znamen) / (Chislit / znamen);
		}

		public double plus_(int chislit, int znamen)
		{
			return ((double)Chislit / Znamen) + ((double)chislit / znamen);
		}

		/////////////////////////////
		//			MegaPrints
		/////////////////////////////
		public void Fplus(int chislit, int znamen, int ans = 0)
		{
			Console.Write($"Plus_Full:\n");

			Chislit += Ans * Znamen;
			Ans = 0;

			chislit += ans * znamen;
			ans = 0;

			Print(chislit, znamen,ans);

			Console.Write($"{ Chislit} * {znamen} + {chislit} * {Znamen}");
			Console.Write($"\n------------\t =");
            Console.Write(plus_(chislit,znamen));
			Console.WriteLine($"\n{ znamen} * { Znamen}");

			Console.WriteLine("\n");

		}

		public void Fmin(int chislit, int znamen,int ans = 0)
		{
			Console.Write($"Min_Full:\n");

			Chislit += Ans * Znamen;
			Ans = 0;

			chislit += ans * znamen;
			ans = 0;

			Print(chislit, znamen, ans);

			Console.Write($"{Chislit} * {znamen} - {chislit} * {Znamen}");
			Console.Write($"\n------------\t =");
			Console.Write(min_(chislit, znamen));
			Console.WriteLine($"\n{znamen} * {Znamen}");

            Console.WriteLine("\n");
        }

		public void Fmult(int chislit, int znamen, int ans = 0)
		{
			Console.Write($"Mult_Full:\n");

			Chislit += Ans * Znamen;
			Ans = 0;

			chislit += ans * znamen;
			ans = 0;

			Print(chislit, znamen, ans);

			Console.Write($"{Chislit} * {chislit}");
			Console.Write($"\n------------\t =");
			Console.Write(mult_(chislit, znamen));
			Console.WriteLine($"\n{znamen} * {Znamen}");

			Console.WriteLine("\n");
		}

		public void Fdel(int chislit, int znamen, int ans = 0)
		{
			Console.Write($"Del_Full:\n");

			Chislit += Ans * Znamen;
			Ans = 0;

			chislit += ans * znamen;
			ans = 0;

			Print(chislit, znamen, ans);

			Console.Write($"{ Chislit} * {znamen}");
			Console.Write($"\n------------\t =");
			Console.Write(del_(chislit, znamen));
            Console.WriteLine($"\n{Znamen} * {chislit} ");

			Console.WriteLine("\n");
		}

	}
}
