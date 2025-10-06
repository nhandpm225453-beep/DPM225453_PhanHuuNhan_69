﻿namespace Builder.NetStructural;

/// <summary>
/// The 'ConcreteBuilder2' class.
/// </summary>
public class ConcreteBuilder2 : Builder
{
    private readonly Product _product = new();

    public override void BuildPartA() => _product.Add("PartX");
    public override void BuildPartB() => _product.Add("PartY");
    public override Product GetResult() => _product;
}
