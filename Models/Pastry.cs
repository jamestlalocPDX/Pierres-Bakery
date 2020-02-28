namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Amount {get; set; }

    public Pastry(int price, int amount)
    {
      Price = price;
      Amount = amount;
    }
  }
}