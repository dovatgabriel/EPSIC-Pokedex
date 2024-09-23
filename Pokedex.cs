namespace Pokedex {
  class Pokedex(Item[] items)
  {
    public Item[] items = items;

    public void ShowAllPokemons()
    {
      Console.WriteLine("\n\n========= - Pokedex - =========\n");

      foreach (Item item in items)
      {
        string index = item.Index;
        string prefix = "";
        string value = "";

        if (!item.Seen)
        {
          prefix = "";
          value = "---------------";
        }
        else if (item.Seen && !item.Owned)
        {
          prefix = "";
          value = item.Pokemon.Name;
        }
        else if (item.Seen && item.Owned)
        {
          prefix = "(-)";
          value = item.Pokemon.Name;
        }

        Console.WriteLine(index + " " + prefix + " " + value);
      }

      Console.WriteLine("\n========= - Pokedex - =========\n\n");
    }

    public Item? GetItem(string index)
    {
      foreach (Item item in items)
      {
        if (item.Index == index)
        {
          return item;
        }
      }

      return null;
    }

    public void ShowPokemonsOfFamily(string family)
    {
      Console.WriteLine("\n\n========= - " + family + " - =========\n");

      foreach (Item item in items)
      {
        if (item.Pokemon.Family == family)
        {
          string index = item.Index;
          string prefix = "";
          string value = "";

          if (!item.Seen)
          {
            prefix = "";
            value = "---------------";
          }
          else if (item.Seen && !item.Owned)
          {
            prefix = "";
            value = item.Pokemon.Name;
          }
          else if (item.Seen && item.Owned)
          {
            prefix = "(-)";
            value = item.Pokemon.Name;
          }

          Console.WriteLine(index + " " + prefix + " " + value);
        }
      }

      Console.WriteLine("\n========= - " + family + " - =========\n\n");
      Console.ResetColor();
    }

    public void AddPokemon(string name, string family, string description, float height, float weight)
    {
      Pokemon pokemon = new Pokemon(name, family, description, height, weight);
      Item item = new Item(items.Length.ToString(), pokemon, false, false);
      Array.Resize(ref items, items.Length + 1);
      items[items.Length - 1] = item;

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\n\n(+) Pokemon added !\n\n");
      Console.ResetColor();
    }
  }
}
