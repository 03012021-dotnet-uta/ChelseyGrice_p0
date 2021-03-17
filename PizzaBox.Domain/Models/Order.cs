using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{

  public class Order
  {
    public List<APizza> Pizzas { get; set; }

    private int total;

    public string StoreName {get; set;}

    public string customerEmail { get; set; }

    public Order(List<APizza> P){
        Pizzas = P;
    }

    public Order(){

    }

    public int calcTotal(){

      foreach( var pizza in Pizzas){
        total += (int)pizza.Crust.Price;
        total += (int)pizza.Size.Price;
        foreach(var t in pizza.Toppings){
            
            total += (int)t.Price;
        }
      }
      return total;
    }

  }


}