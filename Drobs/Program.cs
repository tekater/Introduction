using Drobs.std;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Drobs
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine($"Равны: {(d == d2)}");
			Console.WriteLine($"Принт: {d}");

			//d++;
			//Console.WriteLine($"++{d}");

			//Console.WriteLine($"{d}");

			//d + d2;
			//Console.WriteLine($"Плюс: {d}");

			//d.setCh(4);
			//d.setZn(8);

			//d* d2;
			//Console.WriteLine($"Мульт: {d}");
		}
		/*

		double mult(const Drob& d)
    {
        return (double(chislit) / znamenat) * (double(d.chislit) / d.znamenat);
    }

	double min_(const Drob& d)
	{
		return double(chislit) / znamenat - double(d.chislit) / d.znamenat;
	}
	double del(const Drob& d)
	{
		return (double(chislit) / znamenat) / (double(d.chislit) / d.znamenat);
	}
	double plus_(const Drob& d)
	{
		return double(chislit) / znamenat + double(d.chislit) / d.znamenat;
	}
	void print(const Drob& d)
	{
		cout << d.chislit << "/" << d.znamenat << "\n";
	}
	void Fplus(const Drob& d)
	{
		cout << "Plus_Full:\t\b\b\b\b" << chislit * d.znamenat + d.chislit * znamenat << "/" << d.znamenat * znamenat;
	}
	void Fmin(const Drob& d)
	{
		cout << "Min_Full:\t\b\b\b\b" << chislit * d.znamenat - d.chislit * znamenat << "/" << d.znamenat * znamenat;
	}
	void Fmult(const Drob& d)
	{
		cout << "Mult_Full:\t\b\b\b\b" << chislit * d.chislit << "/" << d.znamenat * znamenat;
	}
	void Fdel(const Drob& d)
	{
		cout << "Del_Full:\t\b\b\b\b" << chislit * d.znamenat << "/" << znamenat * d.chislit;
	}

	*/

	/*Drob& operator +(const Drob& d2)
	{
		chislit = (chislit * d2.znamenat + d2.chislit * znamenat);
		znamenat = d2.znamenat * znamenat;
		return *this;
	}

	Drob& operator -(const Drob& d2)
	{
		chislit = (chislit * d2.znamenat - d2.chislit * znamenat);
		znamenat = d2.znamenat * znamenat;
		return *this;
	}

	Drob& operator *(const Drob& d2)
	{
		chislit = (chislit * d2.chislit);
		znamenat = d2.znamenat * znamenat;
		return *this;
	}

	Drob& operator /(const Drob& d2)
	{
		chislit = (chislit * d2.znamenat);
		znamenat = d2.chislit * znamenat;
		return *this;
	}

	Drob& operator ++()
	{
		znamenat++;
		return *this;
	}
	Drob& operator ++(int)
	{
		Drob temp{ *this };
		znamenat++;
		return temp;
	}

	Drob& operator --()
	{
		znamenat--;
		return *this;
	}
	Drob& operator --(int)
	{
		Drob temp{ *this };
		znamenat--;
		return temp;
	}

	friend bool operator ==(const Drob& d1, const Drob& d2);
	friend ostream& operator <<(ostream& out, const Drob& d1);
	friend istream& operator >>(istream& in, Drob& d1);
};

bool operator ==(const Drob& d1, const Drob& d2)
{
	return (d1.chislit / d1.znamenat) == (d2.chislit / d2.znamenat);
}

bool operator !=(const Drob& d1, const Drob& d2)
{
	return !(d1 == d2);
}

ostream & operator <<(ostream& out, const Drob& d1)
{
    out << d1.chislit << "/" << d1.znamenat << "\n";
	return out;
}
istream & operator >>(istream& in, Drob& d1)
{
    in >> d1.chislit >> d1.znamenat;
	return in;
}
	*/
	}
}
