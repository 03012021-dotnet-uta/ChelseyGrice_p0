using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomPizza : APizza
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
            Toppings = new List<Topping>
            {
                new Topping(),
                new Topping(),
                new Topping(),
                new Topping()
            };
        }
        public CustomPizza()
        {
            Name = "Custom Pizza";
        }

    }
}
