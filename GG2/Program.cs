namespace aboba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Игра 'Угадай число' ");
            Console.WriteLine("2) Таблица умножения");
            Console.WriteLine("3) Вывод делителей числа");
            Console.WriteLine("4) Выход из программы");
            Console.Write("Выберите приложение: ");
            int func;
        L:
            func = Convert.ToInt32(Console.ReadLine());
            {
                if (func <= 0)
                {
                    Console.WriteLine("Вы выбрали неправильное приложение.");
                    Console.Write("Попробуйте снова: ");
                    goto L;
                }
                else if (func > 4)
                {
                    Console.WriteLine("Вы выбрали неправильное приложение.");
                    Console.Write("Попробуйте снова: ");
                    goto L;
                }
                else
                {
                    {
                        switch (func)
                        {
                            case 1:
                                second();
                                break;
                            case 2:
                                umn();
                                break;
                            case 3:
                                del();
                                break;
                        }
                    }
                }
            }

        }
        static void second()
        {
            Random sus = new Random();
            int x;
            int y = sus.Next(100);
            for (int p = 0; p < 1; p++)
            {
                Console.WriteLine("Угадайте число от 0 до 100");
                Console.WriteLine("Хотите узнать ответ? Введите -1");
            G:
                Console.Write("Ваш ответ: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == y)
                {
                    Console.WriteLine("Вы угадали число!");
                }
                else if (x > y)
                {
                    Console.WriteLine("Неправильно! Нужно меньше.");
                    goto G;
                }
                else if (x == -1)
                {
                    Console.WriteLine("Ответ: " + y);
                    goto G;
                }
                else
                {
                    Console.WriteLine("Неправильно! Нужно больше.");
                    goto G;
                }
                Program.Main(new string[] { });
            }
        }
        static void umn()
        {
            Console.WriteLine("Таблица умножения");
            int[,] tabl = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tabl[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(tabl[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Program.Main(new string[] { });
        }
        static void del()
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int c;
            string p;
            Console.Write("Делители: ");
            Console.Write("1, ");
            for (c = 2; c <= n / 2; c++)
            {
                if (n % c == 0)
                {
                    Console.Write(p = c.ToString());
                    Console.Write(", ");
                }
            }
            Console.WriteLine(n);
            Program.Main(new string[] { });
        }
    }
}