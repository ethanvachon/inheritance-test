namespace inheritance_test.Models
{
  public class Dog : Mammal
  {
    public Dog(int legs) : base(2, "houses")
    {
      this.legs = legs;
    }
    public int legs { get; set; }


  }
}