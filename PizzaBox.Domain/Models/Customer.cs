using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// customer model defines that customer will accept Name Email and Orders
  /// orders will be assigned to a list
  /// </summary>
  public class Customer
  {
      public string Name { get; set; }

      public string Email { get; set; }

      public List<Order> orders { get; set; }
  }
}
