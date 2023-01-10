using ElementLib;

namespace Visitor;

public class PriceVisitor : IVisitor
{
    private double _prc = 0;
    
    public void VisitFood(Food food) => _prc += (food.PricePerUnit * food.NrUnits);

    public void VisitBeverage(Beverage beverage) => _prc += (beverage.PricePerUnit * beverage.NrUnits);

    public void VisitCosmetic(Cosmetic cosmetic) => _prc += (cosmetic.PricePerUnit * cosmetic.NrUnits);

    public string ResultString => string.Format("{0:0.00} €",_prc);

    public IVisitor Reset()
    {
        _prc = 0;
        return this;
    }
}