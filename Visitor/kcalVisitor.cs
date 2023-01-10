using ElementLib;

namespace Visitor;

public class kcalVisitor : IVisitor
{
    private double _prc = 0;
    
    public void VisitFood(Food food) => _prc += (food.Calories * food.NrUnits);

    public void VisitBeverage(Beverage beverage) => _prc += (beverage.Calories * beverage.NrUnits);

    public void VisitCosmetic(Cosmetic cosmetic) => _prc += 0;

    public string ResultString => string.Format("{0:0.00} kcal",_prc);

    public IVisitor Reset()
    {
        _prc = 0;
        return this;
    }
}