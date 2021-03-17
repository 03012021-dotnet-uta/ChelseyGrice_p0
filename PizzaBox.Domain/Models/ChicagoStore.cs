using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// Chicago Store Model using abstract AStore and must return a name as defined in AStore
  /// </summary>
  public class ChicagoStore : AStore
  {
 
    public ChicagoStore()
    {
      Name = "Chicago Store";
    }
  }
}
