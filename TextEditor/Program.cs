
namespace TextEditor
{
  class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      short opcao;

      Console.Clear();
      System.Console.WriteLine("TextEditor");
      System.Console.WriteLine("1 - Abrir Arquivo");
      System.Console.WriteLine("2 - Criar novo arquivo");
      System.Console.WriteLine("0 - Sair");
      System.Console.WriteLine("O que você deseja fazer?");
      opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
      }
    }

    static void Abrir() { }

    static void Editar()
    {
      string text = "";

      Console.Clear();
      System.Console.WriteLine("Digite seu texto abaixo ou ESC para sair:");

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while (Console.ReadKey().Key != ConsoleKey.Escape);

      System.Console.Write(text);
    }

    static void Salvar(string text)
    {
      var path = "";

      Console.Clear();
      Console.WriteLine("Qual caminho para salvar o arquivo?");
      path = Console.ReadLine();

      using (var file = new StreamWriter(path!))
      {
        file.Write(text);
      }
    }

  }
}