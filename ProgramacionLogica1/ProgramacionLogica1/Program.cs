using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionLogica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" EJERCICIOS DE PROGRAMACIÓN LÓGICA ");

            // Ejercicio 1: Mayoría de edad
            Console.WriteLine("\n[Ejercicio 1: Votación]");
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            // Hecho: La edad. Regla: Si edad >= 18 entonces puede votar.
            bool puedeVotar = ValidarVotacion(edad);
            Console.WriteLine(puedeVotar ? "Resultado: Puede votar." : "Resultado: No puede votar.");

            // Ejercicio 2: Inferencia de Crédito
            Console.WriteLine("\n[Ejercicio 2: Crédito]");
            Console.Write("¿Tiene empleo? (s/n): ");
            bool tieneEmpleo = Console.ReadLine().ToLower() == "s";
            Console.Write("Ingrese su ingreso mensual: ");
            double ingreso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el monto mínimo requerido para crédito: ");
            double montoMinimo = double.Parse(Console.ReadLine());

            bool otorgarCredito = InferenciaCredito(tieneEmpleo, ingreso, montoMinimo);
            Console.WriteLine(otorgarCredito ? "Resultado: Crédito Aprobado." : "Resultado: Crédito Denegado.");

            // Ejercicio 3 y 4: Reglas dinámicas (Función reutilizable)
            Console.WriteLine("\n[Ejercicio 3 y 4: Salida]");
            Console.Write("¿Está lloviendo? (s/n): ");
            bool llueve = Console.ReadLine().ToLower() == "s";
            Console.Write("¿Tiene paraguas? (s/n): ");
            bool tieneParaguas = Console.ReadLine().ToLower() == "s";

            bool puedeSalir = EvaluarSalida(llueve, tieneParaguas);
            Console.WriteLine(puedeSalir ? "Resultado: Puede salir de casa." : "Resultado: Mejor quédate en casa.");

            // Ejercicio 5: Sistema Experto Simple
            Console.WriteLine("\n[Ejercicio 5: Sistema Experto - Fiebre]");
            Console.Write("Ingrese la temperatura corporal (Celsius): ");
            double temperatura = double.Parse(Console.ReadLine());

            string diagnostico = SistemaExpertoFiebre(temperatura);
            Console.WriteLine($"Diagnóstico del sistema: {diagnostico}");

            Console.WriteLine("\nPresione cualquier tecla para terminar...");
            Console.ReadKey();
        }

        // MÉTODOS DE LÓGICA

       // Ejercicio 1
        static bool ValidarVotacion(int edad) => edad >= 18;

        static bool InferenciaCredito(bool empleo, double ingreso, double min)
        {
            // La inferencia combina múltiples hechos para llegar a una conclusión
            return empleo && (ingreso > min);
        }

       // Ejercicio 3 y 4: Función reutilizable para reglas dinámicas 
        static bool EvaluarSalida(bool llueve, bool tieneParaguas)
        {
            // Regla: salir si no llueve O si tiene paraguas
            return !llueve || tieneParaguas;
        }
            // Ejercicio 5: Sistema experto simple 
        static string SistemaExpertoFiebre(double temp)
        {
            // Base de conocimientos: La fiebre se considera a partir de los 37.5°C
            if (temp > 37.5)
                return "La persona tiene fiebre.";
            else if (temp < 35.0)
                return "Alerta: Temperatura baja (Posible hipotermia).";
            else
                return "Temperatura dentro del rango normal.";
        }
    }
}
