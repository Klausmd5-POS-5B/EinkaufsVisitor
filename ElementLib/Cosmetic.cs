namespace ElementLib;

public class Cosmetic : Good
{

  public Cosmetic()
  {
    Name = "Cosmetic";
  }
  public override void Accept(IVisitor visitor) => visitor.VisitCosmetic(this);
}
