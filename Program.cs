namespace Pokedex
{
  class Program
  {
    Pokedex pokedex = new Pokedex([]);

    public static void Main(string[] args)
    {
      Program program = new Program();
      program.ShowMenu();
    }

    public void ShowMenu()
    {
      Console.WriteLine("1 > Show all pokemons");
      Console.WriteLine("2 > Show pokemons of a family");
      Console.WriteLine("3 > Add a pokemon");
      Console.WriteLine("4 > Show a pokemon's details");
      Console.WriteLine("5 > Exit");

      string command = Console.ReadLine() ?? "";
      Console.ForegroundColor = ConsoleColor.DarkBlue;

      if (command == "1")
      {
        pokedex.ShowAllPokemons();
      }
      else if (command == "2")
      {
        Console.WriteLine("\nFamily: ");
        string family = Console.ReadLine() ?? "";

        pokedex.ShowPokemonsOfFamily(family);
      }
      else if (command == "3")
      {
        Console.WriteLine("\nName: ");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine("\nFamily: ");
        string family = Console.ReadLine() ?? "";

        Console.WriteLine("\nDescription: ");
        string description = Console.ReadLine() ?? "";

        Console.WriteLine("\nHeight: ");
        float height = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("\nWeight: ");
        float weight = float.Parse(Console.ReadLine() ?? "0");

        pokedex.AddPokemon(name, family, description, height, weight);
      }
      else if (command == "4")
      {
        Console.WriteLine("\nIndex: ");
        string index = Console.ReadLine() ?? "";

        Item item = pokedex.GetItem(index) ?? new Item("", new Pokemon("", "", "", 0, 0), false, false);
        
        item.Pokemon.Show();
      }
      else if (command == "5")
      {
        Environment.Exit(0);
      }

      Console.ResetColor();
      ShowMenu();
    }
  }
}
