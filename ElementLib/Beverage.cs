namespace ElementLib;

public class Beverage : Good
{

  public Beverage()
  {
    Name = "Beverage";
    Alcohol = new Random().Next(1, 75);
    Calories = new Random().Next(75, 750);
  }
  
  public int Calories { get; set; }
  public double Alcohol { get; set; }
  public override void Accept(IVisitor visitor) => visitor.VisitBeverage(this);
}
