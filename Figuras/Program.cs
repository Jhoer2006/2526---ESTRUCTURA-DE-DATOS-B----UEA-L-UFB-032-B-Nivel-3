using System;

public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

public class Rectangulo
{
    private double baseRect;
    private double altura;

    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return baseRect * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo c = new Circulo(5);
        Rectangulo r = new Rectangulo(8, 4);

        Console.WriteLine("=== CÍRCULO ===");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        Console.WriteLine("\n=== RECTÁNGULO ===");
        Console.WriteLine("Área: " + r.CalcularArea());
        Console.WriteLine("Perímetro: " + r.CalcularPerimetro());

        Console.WriteLine("\nFin del programa.");
    }
}
