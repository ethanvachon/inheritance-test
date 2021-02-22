namespace inheritance_test.Models
{
  public class Whale : Mammal
  {
    public int Length { get; set; }
    public Whale(int length) : base(2, "ocean")
    {
      Length = length;
    }
  }
}