//#define CONSOLE_SETTINGS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        const string delimeter = "\n----------------------------------------------------\n";
        static void Main(string[] args)
        {

#if CONSOLE_SETTINGS
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;
            //Console.SetWindowPosition(10, 10);
            Console.Title = "Introduction to .NET";

            Console.Beep(70,2000);


            int start_x = 1;
            int start_y = 1;

            int width = 120;
            int height = 32;


            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            Console.WriteLine("Buffer width:\t" + Console.BufferWidth);
            Console.WriteLine("Buffer height:\t" + Console.BufferHeight);
            Console.WriteLine(delimeter);
            Console.WriteLine("Window width:\t" + Console.WindowWidth);
            Console.WriteLine("Window Height:\t" + Console.WindowHeight);



            Console.Write("Hello .NET");
            Console.WriteLine();

            //Console.SetCursorPosition(20, 10);
            Console.CursorLeft = 50;
            Console.CursorTop = 8;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Cursos position check");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(25, 9);
            Console.WriteLine("Cursos position check2");
            Console.ResetColor();
#endif


            Console.Write("Введите ваше ИМЯ: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите вашу ФАМИЛИЮ: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш ВОЗРАСТ: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //1) Конкатенация строк:
            Console.WriteLine("Имя: " + first_name + ", Фамилия: " + last_name + " , Возраст: " + age + " лет.");
            
            //2) Форматирование строек:
            Console.WriteLine(string.Format("Имя: {0}, Фамилия: {1} , возраст: {2} лет.",first_name,last_name,age));

            //3) Интерполяция строк:
            Console.WriteLine($"Имя: {first_name}, фамилия: {last_name} , возраст: {age} лет.");
        }
    }
}
