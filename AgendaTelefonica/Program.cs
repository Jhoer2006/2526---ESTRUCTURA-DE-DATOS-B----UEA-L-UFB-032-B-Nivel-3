using System;

// Registro que representa un contacto de la agenda
struct Contacto
{
    public string Nombre;
    public string Telefono;
    public string Correo;
}

// Clase principal de la Agenda Telefónica
class AgendaTelefonica
{
    // Vector (arreglo) de contactos
    private Contacto[] contactos;
    private int contador;

    // Constructor
    public AgendaTelefonica(int tamaño)
    {
        contactos = new Contacto[tamaño];
        contador = 0;
    }

    // Método para agregar un contacto
    public void AgregarContacto()
    {
        if (contador >= contactos.Length)
        {
            Console.WriteLine("La agenda está llena.");
            return;
        }

        Contacto nuevo;
        Console.Write("Ingrese nombre: ");
        nuevo.Nombre = Console.ReadLine();
        Console.Write("Ingrese teléfono: ");
        nuevo.Telefono = Console.ReadLine();
        Console.Write("Ingrese correo: ");
        nuevo.Correo = Console.ReadLine();

        contactos[contador] = nuevo;
        contador++;
        Console.WriteLine("Contacto agregado correctamente.\n");
    }

    // Método para mostrar todos los contactos (reportería)
    public void MostrarContactos()
    {
        Console.WriteLine("\nLISTA DE CONTACTOS");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"Nombre: {contactos[i].Nombre}");
            Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
            Console.WriteLine($"Correo: {contactos[i].Correo}");
            Console.WriteLine("----------------------");
        }
    }

    // Método para buscar un contacto por nombre
    public void BuscarContacto()
    {
        Console.Write("Ingrese el nombre a buscar: ");
        string nombreBuscar = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < contador; i++)
        {
            if (contactos[i].Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nCONTACTO ENCONTRADO");
                Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                Console.WriteLine($"Correo: {contactos[i].Correo}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
}

// Clase principal del programa
class Program
{
    static void Main(string[] args)
    {
        AgendaTelefonica agenda = new AgendaTelefonica(10);
        int opcion;

        do
        {
            Console.WriteLine("\nAGENDA TELEFÓNICA");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    agenda.AgregarContacto();
                    break;
                case 2:
                    agenda.MostrarContactos();
                    break;
                case 3:
                    agenda.BuscarContacto();
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
