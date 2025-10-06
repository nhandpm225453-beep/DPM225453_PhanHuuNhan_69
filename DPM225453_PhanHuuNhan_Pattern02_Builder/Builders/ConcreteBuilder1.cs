﻿namespace Builder.NetStructural;

/// <summary>
/// The 'ConcreteBuilder1' class.
/// </summary>
public class ConcreteBuilder1 : Builder
{
    private readonly Product _product = new();

    public override void BuildPartA() => _product.Add("PartA");
    public override void BuildPartB() => _product.Add("PartB");
    public override Product GetResult() => _product;
}
