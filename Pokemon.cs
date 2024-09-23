namespace Pokedex {
  public class Pokemon(string name, string family, string description, float height, float weight)
  {
    public string Name = name;
    public string Family = family;
    public string Description = description;
    public float Height = height;
    public float Weight = weight;

    public void Show()
    {
      Console.WriteLine("\n\n====== - Pokemon's details - ======\n");
      Console.WriteLine("NOM: " + Name);
      Console.WriteLine("FAMILLE: " + Family);
      Console.WriteLine("TAILLE: " + Height + "m");
      Console.WriteLine("POIDS: " + Weight + "kg");
      Console.WriteLine("\n========= - Description - =========\n");
      Console.WriteLine(Description);
      Console.WriteLine("\n====== - Pokemon's details - ======\n\n");
    }
  }
}
