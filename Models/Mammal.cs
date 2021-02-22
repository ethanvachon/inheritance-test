namespace inheritance_test.Models
{
  abstract public class Mammal
  {
    public bool hair = true;

    protected Mammal(int eyes, string habitat)
    {
      this.eyes = eyes;
      this.habitat = habitat;
    }

    public int eyes { get; set; }
    public string habitat { get; set; }
  }
}