using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// Abstract of AStore requires that a name method must be implimented
  /// xml included
  /// </summary>
  [XmlInclude(typeof(ChicagoStore))]
  [XmlInclude(typeof(NewYorkStore))]
  public class AStore
  {
    public string Name { get; set; }
    // public List<Order> Orders { get; set; }


    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
}