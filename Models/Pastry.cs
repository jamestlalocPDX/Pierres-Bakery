namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }

    public Pastry(int price)
    {
      _price = price;
    }
  }
}