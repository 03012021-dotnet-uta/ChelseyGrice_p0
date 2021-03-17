namespace PizzaBox.Domain.Models
{
  public class Crust : AComponent
  {
    public Crust(){
      Name = "";
      Price = 0;
    }

    public Crust(string name, int price)
        {
            Name = name;
            Price = price;
        }
  }
}
