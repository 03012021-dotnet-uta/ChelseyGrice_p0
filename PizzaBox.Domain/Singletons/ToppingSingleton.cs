using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class ToppingSingleton
  {
    private static ToppingSingleton _toppingSingleton;
    public List<Topping> topping { get; set; } // print job
    private readonly string _path = @"topping.xml";
    public static ToppingSingleton Instance
    {
      get
      {
        if (_toppingSingleton == null)
        {
          _toppingSingleton = new ToppingSingleton(); // printer
        }

        return _toppingSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private ToppingSingleton()  //reading from xml
    {
    //   var fs = new FileStorage();

    //   if (topping == null)
    //   {
    //     topping = fs.ReadFromXml<Topping>(_path).ToList();
    //   }
    }

    public void Seeding()  //writing to xml
    {
      var toppings = new List<Topping>
            {
                new Topping{
                    Name = "Onion",
                    Price = 1
                },
                new Topping{
                    Name = "Mushrooms",
                    Price = 1
                },
                new Topping{
                    Name = "Extra Cheese",
                    Price = 1
                },
                new Topping{
                    Name = "Olives",
                    Price = 1
                },
                new Topping{
                    Name = "Pepperoni",
                    Price = 1
                },
                new Topping{
                    Name = "Spinach",
                    Price = 1
                }
            };

            var fs = new FileStorage();

            fs.WriteToXml<Topping>(toppings, _path);

            topping = fs.ReadFromXml<Topping>(_path).ToList();

    }

  }
}