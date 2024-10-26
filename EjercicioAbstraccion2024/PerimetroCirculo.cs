using System;

public class PerimetroCirculo : FormulaMatematica
{
    private double radio;
    private double perimetro;

    public PerimetroCirculo(double radio)
    {
        this.radio = radio;
    }

    public override void Calcular()
    {
        perimetro = 2 * Math.PI * radio;
    }

    public override void Imprimir()
    {
        Console.WriteLine($"El perímetro del círculo es: {perimetro}");
    }
}
