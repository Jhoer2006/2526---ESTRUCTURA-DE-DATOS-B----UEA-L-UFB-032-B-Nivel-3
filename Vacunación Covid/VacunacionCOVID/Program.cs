using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCOVID
{
    class Ciudadano
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Ciudadano(int id)
        {
            Id = id;
            Nombre = "Ciudadano " + id;
        }

        // Sobrescribir Equals para teoría de conjuntos
        public override bool Equals(object? obj)
        {
            if (obj is Ciudadano otro)
                return this.Id == otro.Id;
            return false;
        }

        // Sobrescribir GetHashCode
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ciudadanos = GenerarCiudadanos(500);
            var pfizer = GenerarSubconjunto(ciudadanos, 1, 75);
            var astraZeneca = GenerarSubconjunto(ciudadanos, 51, 125);

            var vacunados = Union(pfizer, astraZeneca);
            var ambasDosis = Interseccion(pfizer, astraZeneca);
            var soloPfizer = Diferencia(pfizer, astraZeneca);
            var soloAstra = Diferencia(astraZeneca, pfizer);
            var noVacunados = Diferencia(ciudadanos, vacunados);

            MostrarResultados(noVacunados, ambasDosis, soloPfizer, soloAstra);
        }

        static HashSet<Ciudadano> GenerarCiudadanos(int cantidad)
        {
            var conjunto = new HashSet<Ciudadano>();
            for (int i = 1; i <= cantidad; i++)
                conjunto.Add(new Ciudadano(i));
            return conjunto;
        }

        static HashSet<Ciudadano> GenerarSubconjunto(HashSet<Ciudadano> universo, int inicio, int fin)
        {
            return universo.Where(c => c.Id >= inicio && c.Id <= fin)
                           .ToHashSet();
        }

        static HashSet<Ciudadano> Union(HashSet<Ciudadano> A, HashSet<Ciudadano> B)
        {
            var resultado = new HashSet<Ciudadano>(A);
            resultado.UnionWith(B);
            return resultado;
        }

        static HashSet<Ciudadano> Interseccion(HashSet<Ciudadano> A, HashSet<Ciudadano> B)
        {
            var resultado = new HashSet<Ciudadano>(A);
            resultado.IntersectWith(B);
            return resultado;
        }

        static HashSet<Ciudadano> Diferencia(HashSet<Ciudadano> A, HashSet<Ciudadano> B)
        {
            var resultado = new HashSet<Ciudadano>(A);
            resultado.ExceptWith(B);
            return resultado;
        }

        static void MostrarResultados(
            HashSet<Ciudadano> noVacunados,
            HashSet<Ciudadano> ambasDosis,
            HashSet<Ciudadano> soloPfizer,
            HashSet<Ciudadano> soloAstra)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("CAMPAÑA DE VACUNACIÓN COVID-19");
            Console.WriteLine("Procesamiento mediante Teoría de Conjuntos");
            Console.WriteLine("=========================================\n");

            Console.WriteLine($"No vacunados: {noVacunados.Count}");
            Console.WriteLine($"Ambas dosis: {ambasDosis.Count}");
            Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
            Console.WriteLine($"Solo AstraZeneca: {soloAstra.Count}\n");

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
