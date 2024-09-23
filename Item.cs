namespace Pokedex
{
  class Item(string index, Pokemon pokemon, bool seen, bool owned)
    {
    public string Index = index;
    public Pokemon Pokemon = pokemon;
    public bool Seen = seen;
    public bool Owned = owned;
  }
}
