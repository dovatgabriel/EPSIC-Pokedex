namespace Pokedex {
  class Pokedex(Pokemon[] pokemons)
  {
    public Pokemon[] Pokemons = pokemons;

    public void Show()
    {
      foreach (Pokemon pokemon in Pokemons)
      {
        pokemon.Show();
      }
    }

    public void ShowPokemonsOfFamily(string family)
    {
      foreach (Pokemon pokemon in Pokemons)
      {
        if (pokemon.Family == family)
        {
          pokemon.Show();
        }
      }
    }
  }
}
