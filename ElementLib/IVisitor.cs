namespace ElementLib;

public interface  IVisitor
{
  void VisitFood(Food food);
  void VisitBeverage(Beverage beverage);
  void VisitCosmetic(Cosmetic cosmetic);
  abstract string ResultString { get; }
  IVisitor Reset();
}

