namespace ElementLib;

public class Beverage : Good
{

  public Beverage()
  {
    Name = "Beverage";
  }
  
  public int Calories { get; set; }
  public double Alcohol { get; set; }
  public override void Accept(IVisitor visitor) => visitor.VisitBeverage(this);
}
