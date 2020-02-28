namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Amount {get; set; }
    public int Total { get; set; }

    public Pastry(int price, int amount, int total)
    {
      Price = price;
      Amount = amount;
      Total = total;
    }

    public void pastryBag()
    {
      calculatePastryPrice();
    }

    private void calculatePastryPrice()
    {
     if (Amount == 3)
      {
        Total = 5;
      }
      else
      {
        Total = (Price * Amount);
      }
    }
  }
}