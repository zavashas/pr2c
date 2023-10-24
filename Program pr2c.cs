namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int program = 0;
            while (program != 4)
            {
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите программу: ");
                program = Convert.ToInt32(Console.ReadLine());

                if (program == 1)
                {

                    Program1();
                }
                if (program == 2)
                {
                    Program2();
                }

                if (program == 3)
                {
                    Program3();
                }
            }
        }

        static void Program1()
        {
            Random random = new Random();
            int randNum = random.Next(0, 101);
            int num;
            do
            {
                Console.Write("Введите число: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < randNum)
                {
                    Console.WriteLine("Надо больше!");
                }
                else if (num > randNum)
                {
                    Console.WriteLine("Надо меньше!");
                }
            } while (num != randNum);

            Console.WriteLine("Вы угадали число!");
        }

        static void Program2()
        {
            int[,] table = new int[9, 9];

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    table[a - 1, b - 1] = a * b;
                }
            }

            Console.WriteLine("Таблица умножения:");
            for (int a = 0; a < 9; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    Console.Write(table[a, b] + "\t");

                }
                Console.WriteLine();
            }
        }

        static void Program3()
        {


            string input;
            do
            {
                Console.Write("\nЧтобы выйти, введите 'выйти'\nВведите число: ");
                input = Console.ReadLine();

                if (input.ToLower() == "выйти")
                {
                    break;
                }

                int num = Convert.ToInt32(input);

                Console.Write("Делители числа " + num + ":\n ");
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.Write(i + "\t");
                    }
                }
            } while (true);



        }
        
    }
}

