namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Amount {get; set; }

    public Bread(int price, int amount)
    {
      Price = price;
    } 
  }
}