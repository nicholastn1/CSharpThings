using System;

namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.White;

      Menu.DrawScreen();
      Menu.WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandleMenuOptions(option);
    }

    public static void DrawScreen()
    {
      Console.Write("+");

      for (var i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }

      Console.Write("+");
      Console.Write("\n");

      for (var i = 0; i <= 10; i++)
      {
        Console.WriteLine("|\t\t\t\t|");
      }

      Console.Write("+");

      for (var i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }

      Console.Write("+");
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(10, 1);
        Console.WriteLine("HTML Editor");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("===========================");
        Console.SetCursorPosition(5, 4);
        Console.WriteLine("Select one option below:");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - New file");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Open file");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("0 - Leave");
        Console.SetCursorPosition(3, 10);
        Console.Write("Option: ");
    }

    public static void HandleMenuOptions(short option)
    {
        switch (option)
        {
            case 1:
                Editor.Show();
                break;
            case 2:
                Console.WriteLine("View");
                break;
            case 0:
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                Show();
                break;
        }
    }
  }
}
