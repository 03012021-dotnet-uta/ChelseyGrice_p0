using System;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      PlayWithStore();
    }

    public static void PlayWithStore()
    {
      var storeSingleton = new StoreSingleton();

      foreach (var store in storeSingleton.Stores)
      {
        Console.WriteLine(store);
      }
    }
  }
}
