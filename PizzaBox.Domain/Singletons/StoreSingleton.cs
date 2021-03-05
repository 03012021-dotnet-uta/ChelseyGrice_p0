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
  public class StoreSingleton
  {
    private static StoreSingleton _storeSingleton;
    public List<ChicagoStore> Stores { get; set; } // print job
    public static StoreSingleton Instance
    {
      get
      {
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton(); // printer
        }

        return _storeSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
      var fs = new FileStorage();

      if (Stores == null)
      {
        Stores = fs.ReadFromXml<ChicagoStore>().ToList();
      }
    }

    /* SINGLETON METHOD WORKFLOW */

    // public static StoreSingleton GetInstance()
    // {
    //   if (_storeSingleton == null)
    //   {
    //     _storeSingleton = new StoreSingleton(); // printer
    //   }

    //   return _storeSingleton;
    // }
  }
}
