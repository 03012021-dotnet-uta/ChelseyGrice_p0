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
  public class SizeSingleton
  {
    private static SizeSingleton _sizeSingleton;
    public List<Size> mySize { get; set; } // print job
    private readonly string _path = @"size.xml";
    public static SizeSingleton Instance
    {
      get
      {
        if (_sizeSingleton == null)
        {
          _sizeSingleton = new SizeSingleton(); // printer
        }

        return _sizeSingleton;
      }
    }

    private SizeSingleton()  //reading from xml
    {
      var fs = new FileStorage();

      if (mySize == null)
      {
        mySize = fs.ReadFromXml<Size>(_path).ToList();
      }
    }

    public void Seeding()  //writing to xml
    {
      var sizes = new List<Size>
            {
                new Size{
                    Name = "Small",
                    Price = 9
                },
                new Size{
                    Name = "Medium",
                    Price = 12
                },
                new Size{
                    Name = "Large",
                    Price = 15
                }
            };

            var fs = new FileStorage();

            fs.WriteToXml<Size>(sizes, _path);

            mySize = fs.ReadFromXml<Size>(_path).ToList();

    }

  }
}