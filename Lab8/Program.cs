using System.Runtime.InteropServices;

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
                Console.WriteLine("2. (15)Дана строка. Определить, сдержит ли строка только символы 'a', 'b', 'c' или нет");
                Console.WriteLine("3. (28)Вывести слова, в которых заменить каждую большую букву одноименной малой; удалить все символы, не являющиеся буквами или цифрами; вывести в алфавитном порядке все гласные буквы, входящие в каждое слово строки.");
                Console.WriteLine("4. (33)Дана строка, содержащая полное имя файла (например, 'c:\\WebServers\\home\\testsite\\www\\myfile.txt'). Выделите из этой строки имя файла без расширения.");
                Console.WriteLine("Esc. Выход");
                choice = Console.ReadKey().Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Task10();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Task15();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Task28();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine();
                        Task33();
                        Console.WriteLine();
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            } while (choice != ConsoleKey.Escape);
        }
        static void Task10()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (str[0] == 'a' && str[1] == 'b' && str[2] == 'c')
                Console.WriteLine("www" + str.Substring(3));
            else
                Console.WriteLine(str + "zzz");
        }
        static void Task15()
        {
            bool flag = true;
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            foreach (char c in str)
            {
                if (c != 'a' && c!='b' && c!='c')
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Строка содержит только символы 'a', 'b', 'c'");
            else
                Console.WriteLine("Строка содержит не только символы 'a', 'b', 'c'");
        }
        static void Task28()
        {
            string vowels = "eyuioaуеаоэяиюёы";
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] words = str.ToLower().Split(' ');            
            foreach (string word in words)
            {
                string result = word;
                foreach (char c in word)
                {                    
                    if (!Char.IsLetterOrDigit(c))
                        result= result.Replace(c.ToString(), "");                    
                }
                Console.Write($"{result} \t");
            }
            Console.WriteLine();
            foreach (string word in words)
            {
            string result = "";
                foreach (char c in word)
                {                    
                    if (vowels.Contains(c))
                        result += c;
                }                
                char[] charArray = result.ToCharArray();
                Array.Sort(charArray);
                String s = new String(charArray);
                Console.Write($"{s} \t");
            }
        }
        static void Task33()
        {
            string path = "c:\\WebServers\\home\\testsite\\www\\myfile.txt";
            Console.WriteLine("Путь к файлу: "+path);
            string[] name = path.Split('\\');
            Console.WriteLine("Наименование файла: " + name[name.Length - 1].Split('.')[0]);
        }
    }
}
