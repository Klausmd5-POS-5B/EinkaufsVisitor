using ElementLib;

namespace Visitor;

public class WaageVisitor : IVisitor
{
    private double _prc = 0;
    
    public void VisitFood(Food food) => _prc += (food.Weight * food.NrUnits);

    public void VisitBeverage(Beverage beverage) => _prc += (beverage.Weight * beverage.NrUnits);

    public void VisitCosmetic(Cosmetic cosmetic) => _prc += (cosmetic.Weight * cosmetic.NrUnits);

    public string ResultString => string.Format("{0:0.00} g",_prc);

    public IVisitor Reset()
    {
        _prc = 0;
        return this;
    }
}