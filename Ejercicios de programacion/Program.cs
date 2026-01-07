using System;
using System.Collections.Generic;
using System.Linq; // Necesario para ordenar y listas

namespace EjerciciosClase
{
    // CLASE POO: Representa una asignatura (Para ejercicios 1, 2 y 3)
    // Esto cumple con el requisito de usar Programación Orientada a Objetos
    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Asignatura(string nombre)
        {
            Nombre = nombre;
            Nota = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== TAREA ESTRUCTURA DE DATOS ===");
                Console.WriteLine("1. Ejercicio 1: Listar Asignaturas");
                Console.WriteLine("2. Ejercicio 2: Yo estudio <Asignatura>");
                Console.WriteLine("3. Ejercicio 3: Notas de Asignaturas");
                Console.WriteLine("4. Ejercicio 4: Lotería Primitiva (Ordenada)");
                Console.WriteLine("5. Ejercicio 5: Números Inversos (1 al 10)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": Ejercicio1(); break;
                    case "2": Ejercicio2(); break;
                    case "3": Ejercicio3(); break;
                    case "4": Ejercicio4(); break;
                    case "5": Ejercicio5(); break;
                    case "0": continuar = false; break;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        // --- EJERCICIO 1: Mostrar lista de asignaturas ---
        static void Ejercicio1()
        {
            Console.WriteLine("\n--- Ejercicio 1 ---");
            List<string> materias = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            Console.WriteLine("Las asignaturas del curso son:");
            foreach (var materia in materias)
            {
                Console.WriteLine("- " + materia);
            }
        }

        // --- EJERCICIO 2: Mensaje "Yo estudio..." ---
        static void Ejercicio2()
        {
            Console.WriteLine("\n--- Ejercicio 2 ---");
            List<string> materias = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            foreach (var materia in materias)
            {
                Console.WriteLine($"Yo estudio {materia}");
            }
        }

        // --- EJERCICIO 3: Notas (Usando la Clase Asignatura) ---
        static void Ejercicio3()
        {
            Console.WriteLine("\n--- Ejercicio 3 ---");
            
            // Creamos la lista usando Objetos de tipo 'Asignatura'
            List<Asignatura> listaAsignaturas = new List<Asignatura>
            {
                new Asignatura("Matemáticas"),
                new Asignatura("Física"),
                new Asignatura("Química"),
                new Asignatura("Historia"),
                new Asignatura("Lengua")
            };

            // 1. Preguntar notas
            foreach (var asignatura in listaAsignaturas)
            {
                Console.Write($"¿Qué nota has sacado en {asignatura.Nombre}?: ");
                // Validación simple para evitar errores si no escriben un número
                if (double.TryParse(Console.ReadLine(), out double notaIngresada))
                {
                    asignatura.Nota = notaIngresada;
                }
                else
                {
                    asignatura.Nota = 0; // Si escriben texto, se pone 0 por defecto
                }
            }

            // 2. Mostrar resultados
            Console.WriteLine("\n--- Boletín de Notas ---");
            foreach (var asignatura in listaAsignaturas)
            {
                Console.WriteLine($"En {asignatura.Nombre} has sacado {asignatura.Nota}");
            }
        }

        // --- EJERCICIO 4: Lotería Primitiva ---
        static void Ejercicio4()
        {
            Console.WriteLine("\n--- Ejercicio 4 ---");
            List<int> numerosGanadores = new List<int>();

            Console.WriteLine("Introduce los números ganadores de la lotería (escribe 'fin' para terminar o ingresa 6 números):");

            // Pedimos 6 números (típico de la primitiva)
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Número {i}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int numero))
                {
                    numerosGanadores.Add(numero);
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                    i--; // Repetir el intento
                }
            }

            // Ordenamos la lista de menor a mayor
            numerosGanadores.Sort();

            Console.Write("Números ganadores ordenados: ");
            // Imprimimos la lista
            foreach (int n in numerosGanadores)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        // --- EJERCICIO 5: Números Inversos (1 al 10) ---
        static void Ejercicio5()
        {
            Console.WriteLine("\n--- Ejercicio 5 ---");
            List<int> numeros = new List<int>();

            // Llenamos la lista del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            // Invertimos el orden de la lista
            numeros.Reverse();

            // Mostramos separados por comas
            // string.Join es una forma muy eficiente de unir elementos de una lista
            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}