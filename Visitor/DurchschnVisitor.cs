using ElementLib;

namespace Visitor;

public class DurchschnVisitor : IVisitor
{
    private double _alc = 0;
    private int _units = 0;
    
    public void VisitFood(Food food)
    {
        _alc += (food.PricePerUnit * food.NrUnits);
        _units += food.NrUnits;
    }

    public void VisitBeverage(Beverage beverage)
    {
        _alc += (beverage.PricePerUnit * beverage.NrUnits);
        _units += beverage.NrUnits;
    }

    public void VisitCosmetic(Cosmetic cosmetic)
    {
        _alc += (cosmetic.PricePerUnit * cosmetic.NrUnits);
        _units += cosmetic.NrUnits;
    }

    public string ResultString => string.Format("{0:0.00} %",_alc / _units);

    public IVisitor Reset()
    {
        _alc = 0;
        _units = 0;
        return this;
    }
}