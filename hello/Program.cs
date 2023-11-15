namespace hello
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      System.Console.WriteLine("hello everyone");
    }

    public static void GreetWhite()
    {
      System.Console.WriteLine("hello white");
      GreetWhite();
      GreetBlack();
    }

    public static void GreetBlack()
    {
      System.Console.WriteLine("hello black");
    }
  }
  }
}