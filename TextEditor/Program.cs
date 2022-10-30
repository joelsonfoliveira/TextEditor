
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
      Console.Clear();
      System.Console.WriteLine("O que você deseja fazer?");
      System.Console.WriteLine("1 - Abrir Arquivo");
      System.Console.WriteLine("2 - Criar novo arquivo");
      System.Console.WriteLine("0 - Sair");
      short opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
      }
    }

    static void Abrir() { }

    static void Editar() { }
  }
}