namespace Pokedex {
  public class Pokemon(string name, string family, string description)
  {
    public string Name = name;
    public string Family = family;
    public string Description = description;
    public float Height;
    public float Weight;

    public void Show()
    {
      System.Console.WriteLine($"Name: {Name}");
      System.Console.WriteLine($"Family: {Family}");
      System.Console.WriteLine($"Description: {Description}");
      System.Console.WriteLine($"Height: {Height}");
      System.Console.WriteLine($"Weight: {Weight}");
    }
  }
}
