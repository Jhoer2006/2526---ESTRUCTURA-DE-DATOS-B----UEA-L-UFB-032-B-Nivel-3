using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la expresión:");
        string expresion = Console.ReadLine() ?? "";

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    static bool EstaBalanceada(string texto)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in texto)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false;

                char tope = pila.Pop();
                if (!EsPar(tope, c)) return false;
            }
        }

        return pila.Count == 0;
    }

    static bool EsPar(char a, char c)
    {
        return (a == '(' && c == ')') ||
               (a == '{' && c == '}') ||
               (a == '[' && c == ']');
    }
}

