using System;
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
        Console.WriteLine(name);
        return name.ToLower() switch
        {
            "durchschn. alk" => new DurchschnVisitor(),
            "kalorien" => new kcalVisitor(),
            "kasse" => new PriceVisitor(),
            "render html" => new HtmlVisitor(),
            "waage" => new WaageVisitor(),
            _ => new PriceVisitor()
        };
    }
}