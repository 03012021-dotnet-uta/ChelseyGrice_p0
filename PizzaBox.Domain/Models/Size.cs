namespace PizzaBox.Domain.Models
{
  public class Size : AComponent
  {
    public Size()
        {
            Name = "";
            Price = 0;
        }
        public Size(string name, int price)
        {
            Name = name;
            Price = price;
        }

  }
}
