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
  /// create crust singleton instance and read from crust.xml
  /// </summary>
  public class CrustSingleton
  {
    private static CrustSingleton _crustSingleton;
    public List<Crust> Crusts { get; set; } // print job
    private readonly string _path = @"crust.xml";// read from crust.xml
    public static CrustSingleton Instance 
    {
      get
      {
        if (_crustSingleton == null)
        {
          _crustSingleton = new CrustSingleton(); // printer
        }

        return _crustSingleton;
      }
    }

    private CrustSingleton()  //reading from xml
    {
      var fs = new FileStorage();

      if (Crusts == null)
      {
        Crusts = fs.ReadFromXml<Crust>(_path ).ToList();
      }
    }

    public void Seeding()  //Defining list 
    {
      var crusts = new List<Crust>
            {
                new Crust{
                    Name = "Thick",
                    Price = 2
                },
                new Crust{
                    Name = "Thin",
                    Price = 1
                }
            };

            var fs = new FileStorage();

            fs.WriteToXml<Crust>(crusts, _path );

            Crusts = fs.ReadFromXml<Crust>(_path ).ToList();


    }

  }
}