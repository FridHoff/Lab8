namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1. (6)Дана строка. Показать третий, шестой, девятый и так далее симовлы");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("Esc. Выход");
                choice = Console.ReadKey().Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Task6();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        //Task16();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        //Task26();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine();
                        //Task36();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            } while (choice != ConsoleKey.Escape);
        }
        static void Task6()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            for (int i = 0; i<str.Length; i++)
                if((i+1)%3==0)
                Console.WriteLine($"{i+1}-й символ строки — {str[i]}");
        }
    }
}
