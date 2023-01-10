using ElementLib;

namespace Visitor;

public class StringVisitor : IVisitor
{
    public void VisitFood(Food food) =>
        ResultString =
            $"{food.Name} {food.PricePerUnit}€ {food.Weight} {food.Calories} kcal";

    public void VisitBeverage(Beverage beverage) => ResultString =
        $"{beverage.Name} {beverage.PricePerUnit}€ {beverage.Weight} {beverage.Alcohol:0.0}% Alc.";

    public void VisitCosmetic(Cosmetic cosmetic) =>
        ResultString =
            $"{cosmetic.Name} {cosmetic.PricePerUnit}€ {cosmetic.Weight}g;";

    public string ResultString { get; private set; }

    public IVisitor Reset()
    {
        ResultString = string.Empty;
        return this;
    }
}