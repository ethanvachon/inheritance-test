using System;
using inheritance_test.Models;

namespace inheritance_test
{
  class Program
  {
    static void Main(string[] args)
    {
      Dog newDog = new Dog(4);
      Console.WriteLine(newDog.habitat);
      Console.WriteLine(newDog.hair);
      Console.WriteLine(newDog.legs);
    }
  }
}
