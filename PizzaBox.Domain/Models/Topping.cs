namespace PizzaBox.Domain.Models
{
  public class Topping : AComponent
  {
    public Topping()
        {
            Name = "";
            Price = 0;
        }
        public Topping(string name, int price)
        {
            Name = name;
            Price = price;
        }
  }
}