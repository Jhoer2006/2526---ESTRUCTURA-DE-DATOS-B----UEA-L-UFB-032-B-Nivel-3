using System;
using System.Collections.Generic;

class Program
{
    static Stack<int> A = new Stack<int>();
    static Stack<int> B = new Stack<int>();
    static Stack<int> C = new Stack<int>();

    static void Main()
    {
        Console.Write("Ingrese número de discos: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = n; i >= 1; i--)
            A.Push(i);

        MostrarTorres();
        ResolverHanoi(n, A, C, B, "A", "C", "B");
    }

    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                              string nomO, string nomD, string nomA)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nomO, nomD);
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino, nomO, nomA, nomD);
        MoverDisco(origen, destino, nomO, nomD);
        ResolverHanoi(n - 1, auxiliar, destino, origen, nomA, nomD, nomO);
    }

    static void MoverDisco(Stack<int> desde, Stack<int> hacia, string nomDesde, string nomHacia)
    {
        int disco = desde.Pop();
        hacia.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {nomDesde} a {nomHacia}");
        MostrarTorres();
    }

    static void MostrarTorres()
    {
        Console.WriteLine("Estado de las torres:");
        MostrarPila("A", A);
        MostrarPila("B", B);
        MostrarPila("C", C);
        Console.WriteLine("----------------------");
    }

    static void MostrarPila(string nombre, Stack<int> pila)
    {
        Console.Write(nombre + ": ");
        foreach (int d in pila)
            Console.Write(d + " ");
        Console.WriteLine();
    }
}
