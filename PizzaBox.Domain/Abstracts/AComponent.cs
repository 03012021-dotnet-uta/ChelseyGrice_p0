namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// name and price must be implimented as defeined by AComponents
  /// </summary>
  public abstract class AComponent
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}
