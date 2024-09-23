namespace Pokedex
{
  class Item(int index, Pokemon pokemon, bool seen, bool owned)
    {
    public int Index = index;
    public Pokemon Pokemon = pokemon;
    public bool Seen = seen;
    public bool Owned = owned;
  }
}
