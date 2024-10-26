using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular volumen de un cilindro");
            Console.WriteLine("2. Convertir libras a kilogramos");
            Console.WriteLine("3. Calcular perímetro de un círculo");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 4) break;

            FormulaMatematica formula = null;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el radio del cilindro: ");
                    double radioCilindro = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del cilindro: ");
                    double altura = double.Parse(Console.ReadLine());
                    formula = new VolumenCilindro(radioCilindro, altura);
                    break;
                case 2:
                    Console.Write("Ingrese las libras a convertir: ");
                    double libras = double.Parse(Console.ReadLine());
                    formula = new ConversionLibrasKilogramos(libras);
                    break;
                case 3:
                    Console.Write("Ingrese el radio del círculo: ");
                    double radioCirculo = double.Parse(Console.ReadLine());
                    formula = new PerimetroCirculo(radioCirculo);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    continue;
            }

            formula.Calcular();
            formula.Imprimir();
            Console.WriteLine();
        }
    }
}
