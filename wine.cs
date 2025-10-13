using System
public class Wine {
  public decimal Price;
  public int Year;

  public Wine(decimal price){
    Price = price;
  }
  public Wine(decimal price, int year) : this(price)
  {
    Year = year;
  }
}

public class Program {
  public static void Main()
  {
    Wine wine1 = new Wine(13.43m);
    Console.Writeline($"Wine 1 - Price: {wine1.Price}, Year: {wine1.Year}");
    Wine wine2 = new Wine(34.98m, 2017);
    Console.WriteLine($"Wine 2 - Price: {wine2.Price}, Year: {wine2.Year}");
  }
}
