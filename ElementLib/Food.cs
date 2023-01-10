namespace ElementLib;

public class Food : Good
{

  public Food()
  {
    Name = "Food";
  }
  public int Calories { get; set; }
  public override void Accept(IVisitor visitor) => visitor.VisitFood(this);
}
