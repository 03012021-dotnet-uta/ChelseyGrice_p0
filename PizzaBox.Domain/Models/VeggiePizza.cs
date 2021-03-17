using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class VeggiePizza : APizza
  {
    protected override void AddCrust()
    {
      Crust = new Crust();
    }

    protected override void AddSize()
    {
      Size = new Size();
    }

    protected override void AddToppings()
    {
      Toppings = new List<Topping>{
            new Topping{
                Name = "Onion",
                Price = 1
            },
            new Topping{
                Name = "Spinach",
                Price = 1
            },
            new Topping{
                Name = "Olives",
                Price = 1
            },
            new Topping{
                Name = "Mushrooms",
                Price = 1
            }
      };
    }

            public VeggiePizza()
        {
            Name = "Veggie Pizza";
        }
  }
}