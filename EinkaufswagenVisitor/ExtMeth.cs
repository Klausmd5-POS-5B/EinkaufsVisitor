using ElementLib;
using Visitor;

namespace EinkaufswagenVisitor;

public static class ExtMeth
{
    public static Good GetElem(this string name)
    {
        return name.ToLower() switch
        {
            "food" => new Food(),
            "cosmetic" => new Cosmetic(),
            "beverage" => new Beverage(),
            _ => new Beverage()
        };
    }
    
    public static IVisitor GetMeth(this string name)
    {
        return name.ToLower() switch
        {
            "durchschn. alkoholgehalt" => new StringVisitor(),
            "kalorien" => new StringVisitor(),
            "kasse" => new StringVisitor(),
            "render html" => new HtmlVisitor(),
            "waage" => new StringVisitor(),
            _ => new StringVisitor()
        };
    }
}