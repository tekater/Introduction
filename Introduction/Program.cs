//#define CONSOLE_SETTINGS
//#define WALTER_WHITE_50
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

#if WALTER_WHITE_50

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





#endif

            char measurement;

            do
            {
                measurement = Console.ReadKey().KeyChar;
                switch (measurement)
                {
                    case 'w':
                        Console.WriteLine(" - Вверх");
                        break;
                    case 'a':
                        Console.WriteLine(" - Влево");
                        break;
                    case 'd':
                        Console.WriteLine(" - Вправо");
                        break;

                    case 's':
                        Console.WriteLine(" - Вниз");
                        break;
                    case ' ':
                        Console.WriteLine(" - Прыжок");
                        break;
                    case '\r':
                        Console.WriteLine(" - Выстрел");
                        break;
                    case 'q':
                        Console.WriteLine(" - Exit");
                        break;
                    default:
                        Console.WriteLine(" - Error");
                        break;
                }
            } while (measurement != 'q');

            Console.WriteLine("\n\nGeometry:\n(0):\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n(1):\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n(2):\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n(3):\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n(4):\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 5; j++)
                {
                    if (j <= i)
                    {
                        Console.Write("*");

                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n(5):\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5 - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                for (int j = (i + 1) * 2; j < (5) * 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                Console.WriteLine();
            }

            Console.WriteLine("\n(6):\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }



            {
                Console.WriteLine("Введите размер Шахматной доски:\n");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.Write('+');
                        }
                        else if (i == 0 && j == n)
                        {
                            Console.Write('+');
                        }
                        else if (i == n && j == 0)
                        {
                            Console.Write('+');
                        }
                        else if (i == n && j == n)
                        {
                            Console.Write('+');
                        }
                        else if (i == 0 || i == n)
                        {
                            Console.Write("-" + "-");
                        }
                        else if (j == 0 || j == n)
                        {
                            Console.Write("|");
                        }
                        else if ((i + j) % 2 == 0)
                        {
                            Console.Write("#" + "#");
                        }
                        else
                        {
                            Console.Write(" " + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }



            {
                Console.WriteLine("Введите размер Шахматной доски:\n");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            for (int l = 0; l < n; l++)
                            {
                                if ((i + k) % 2 == 0)
                                {
                                    Console.Write("* ");
                                }
                                else 
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
