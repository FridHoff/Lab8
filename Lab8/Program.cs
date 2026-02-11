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
                Console.WriteLine("1. (10)Дана строка. Если она начинается на 'abc', то заменить их на 'www', иначе добавить в конец строки 'zzz'");
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
            if (str[0] == 'a' && str[1] == 'b' && str[2] == 'c')
                Console.WriteLine("www" + str.Substring(3));
            else
                Console.WriteLine(str + "zzz");
        }
    }
}
