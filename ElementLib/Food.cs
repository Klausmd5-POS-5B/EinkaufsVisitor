namespace ElementLib;

public class Food : Good
{

  public Food()
  {
    Name = "Food";
    Calories = new Random().Next(75, 750);
  }
  public int Calories { get; set; }
  public override void Accept(IVisitor visitor) => visitor.VisitFood(this);
}
