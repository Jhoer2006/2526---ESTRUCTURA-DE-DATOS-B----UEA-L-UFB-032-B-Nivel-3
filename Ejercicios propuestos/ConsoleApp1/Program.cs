using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Ejercicio 1: contar elementos
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }

    // Ejercicio 2: invertir lista
    public void InvertirLista()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        cabeza = anterior;
    }

    public void MostrarLista()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("EJERCICIO 1: CONTAR ELEMENTOS");
        EjecutarEjercicio1();

        Console.WriteLine("\n-----------------------------\n");

        Console.WriteLine("EJERCICIO 2: INVERTIR LISTA");
        EjecutarEjercicio2();
    }

    static void EjecutarEjercicio1()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.InsertarFinal(10);
        lista.InsertarFinal(20);
        lista.InsertarFinal(30);

        Console.WriteLine("Elementos en la lista: " + lista.ContarElementos());
    }

    static void EjecutarEjercicio2()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.InsertarFinal(1);
        lista.InsertarFinal(2);
        lista.InsertarFinal(3);

        Console.WriteLine("Lista original:");
        lista.MostrarLista();

        lista.InvertirLista();

        Console.WriteLine("Lista invertida:");
        lista.MostrarLista();
    }
}
