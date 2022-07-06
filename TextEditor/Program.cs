using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do you wanna do?");
            Console.WriteLine("1- Open file");
            Console.WriteLine("2- Create new file");
            Console.WriteLine("0- Leave");
            short option = short.Parse(Console.ReadLine());

            switch (option){
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Create(); break;
                default: Menu(); break;
            }
        }
        static void Create()
        {
            Console.Clear();
            Console.WriteLine("Write your text down below (ESC to exit):");
            Console.WriteLine("=========================================");

            string text = "";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }
        static void Open()
        {
            Console.Clear();
            Console.WriteLine("What is your file path?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path)){
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
            Menu();
        }
        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("What path do you want to save?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path)){
                file.Write(text);
            }

            Console.WriteLine("Your text was saved to '" + path + "' successfully!\nPress any key to continue");
            Console.ReadLine();
            Menu();
        }
    }
}
