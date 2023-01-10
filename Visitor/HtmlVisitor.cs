using ElementLib;

namespace Visitor;

public class HtmlVisitor : IVisitor
{
    public void VisitFood(Food food) =>
        Result.Add(
            $"<tr><td>{food.Name}</td><td>{food.PricePerUnit}€</td><td>{food.Weight}g</td><td>{food.Calories} kcal</td></tr>");

    public void VisitBeverage(Beverage beverage) => Result.Add(
        $"<tr><td>{beverage.Name}</td><td>{beverage.PricePerUnit}€</td><td>{beverage.Weight}g</td><td>{beverage.Alcohol:0.0}% Alc.</td></tr>");

    public void VisitCosmetic(Cosmetic cosmetic) =>
        Result.Add(
            $"<tr><td>{cosmetic.Name}</td><td>{cosmetic.PricePerUnit}€</td><td>{cosmetic.Weight}g</td><td>&nbsp;</td></tr>");

    public string ResultString => GetStr();

    string GetStr()
    {
        string myStr = "<table><tr><th>Produkt</th><th>Preis</th><th>Gewicht</th><th>Info</th></tr>";
        myStr += string.Join("", Result);
        myStr += "</table>";

        return myStr;
    }

public List<string> Result = new List<string>();

public IVisitor Reset()
{
    Result = new List<string>();
    return this;
}

}