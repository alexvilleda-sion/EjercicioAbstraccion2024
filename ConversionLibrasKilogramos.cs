using System;

public class ConversionLibrasKilogramos : FormulaMatematica
{
    private double libras;
    private double kilogramos;

    public ConversionLibrasKilogramos(double libras)
    {
        this.libras = libras;
    }

    public override void Calcular()
    {
        kilogramos = libras * 0.453592;
    }

    public override void Imprimir()
    {
        Console.WriteLine($"{libras} libras es igual a {kilogramos} kilogramos");
    }
}
