namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Amount {get; set; }

    public int Total { get; set; }

    public Bread(int price, int amount, int total)
    {
      Price = price;
      Amount = amount;
      Total = total;
    }

    public void breadTotal()
    {
      calculateBreadPrice();
    }

    private void calculateBreadPrice()
    {
      if (hearty.Amount == 3)
      {
        hearty.Total = 5;
      }
      else
      {
        hearty.Total = (hearty.Price * hearty.Amount);
      }
    }
  }
}