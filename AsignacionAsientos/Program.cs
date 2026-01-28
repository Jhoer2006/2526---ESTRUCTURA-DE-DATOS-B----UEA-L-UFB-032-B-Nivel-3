using System;
using System.Collections.Generic;

// Clase que representa a una persona
class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<Persona> cola = new Queue<Persona>();
        const int totalAsientos = 30;
        int asientosAsignados = 0;
        int opcion;

        do
        {
            Console.WriteLine("\nASIGNACIÓN DE ASIENTOS");
            Console.WriteLine("1. Registrar persona en la cola");
            Console.WriteLine("2. Asignar asiento");
            Console.WriteLine("3. Ver personas en cola");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (asientosAsignados < totalAsientos)
                    {
                        Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        cola.Enqueue(new Persona(nombre));
                        Console.WriteLine("Persona registrada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Todos los asientos ya han sido asignados.");
                    }
                    break;

                case 2:
                    if (cola.Count > 0 && asientosAsignados < totalAsientos)
                    {
                        Persona atendida = cola.Dequeue();
                        asientosAsignados++;
                        Console.WriteLine($"Asiento asignado a: {atendida.Nombre}");
                    }
                    else
                    {
                        Console.WriteLine("No hay personas en la cola o los asientos están completos.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Personas en la cola:");
                    foreach (var persona in cola)
                    {
                        Console.WriteLine(persona.Nombre);
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }
}
