//Ejercicio 1
using System;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre Porfavor: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el día de la semana en que naciste Porfavor (1. Domingo, 2. Lunes, 3. Martes, 4. Miercoles, 5. Jueves, 6. Viernes, 7. Sábado): ");
            int diaSemana = int.Parse(Console.ReadLine());

            if (diaSemana >= 8 || diaSemana == 0)
            {
                Console.WriteLine("ERROR: El día de la semana ingresado es inválido, intentelo otra ves Porfavor");
                return;
            }

            Console.WriteLine("Ingrese su año de nacimiento Porfavor: ");
            int añoNacimiento = int.Parse(Console.ReadLine());

            if (añoNacimiento % 2 == 0)
            {
                Console.WriteLine("Eres de un año par.");
            }
            else
            {
                Console.WriteLine("Eres de un año impar.");
            }

            int edad = DateTime.Now.Year - añoNacimiento;

            Console.WriteLine("Tienes " + edad + " años.");

            if (añoNacimiento >= 1928 && añoNacimiento <= 1945)
            {
                Console.WriteLine("Tú Perteneces a la Generación Silent.");
            }
            else if (añoNacimiento >= 1946 && añoNacimiento <= 1964)
            {
                Console.WriteLine("Tú Perteneces a la Generación Baby Boomer.");
            }
            else if (añoNacimiento >= 1965 && añoNacimiento <= 1980)
            {
                Console.WriteLine("Tú Perteneces a la Generación X.");
            }
            else if (añoNacimiento >= 1981 && añoNacimiento <= 1993)
            {
                Console.WriteLine("Tú Perteneces a la Generación Millennial.");
            }
            else if (añoNacimiento >= 1994 && añoNacimiento <= 2010)
            {
                Console.WriteLine("Tú Perteneces a la Generación Z.");
            }
            else if (añoNacimiento >= 2011 && añoNacimiento <= DateTime.Now.Year)
            {
                Console.WriteLine("Tú Perteneces a la Generación Alpha.");
            }
            else
            {
                Console.WriteLine("Lolamento no se pudo determinar a qué generación perteneces.");
            }

            if (edad < 17)
            {
                Console.WriteLine(nombre + ", si sos patojo frega todo lo que podas, dejamos los recuerdos de nuestras travesuras.");
            }
            else if (edad >= 18 && edad <= 19)
            {
                Console.WriteLine(nombre + ", sos patojo con DPI concentrate en tus cosas aparte del reguetón.");
            }
            else if (edad >= 20 && edad <= 29)
            {
                Console.WriteLine(nombre + ", sos joven, disfrútalo y aprovecha tu juventud, no metas la pata aún se vale equivocarse.");
            }
            else if (edad >= 30 && edad <= 60)
            {
                Console.WriteLine(nombre + ", disfruta tu vida profesional.");
            }
            else if (edad > 60)
            {
                Console.WriteLine(nombre + ", sos adulto mayor, cosecha lo que sembraste, no hay vuelta atrás.");
            }
        }
    }
}







//Ejercicio 2
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese su edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        bool tienePermisoPadres = false;

        if (edad >= 21)
        {
            Console.WriteLine("Usted puede aplicar para una licencia de conducir.");
        }
        else if (edad >= 16)
        {
            Console.WriteLine("Usted necesita el permiso de sus padres para aplicar para una licencia de conducir.");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "sí")
            {
                tienePermisoPadres = true;
            }
            else
            {
                tienePermisoPadres = false;
            }

            if (tienePermisoPadres)
            {
                Console.WriteLine("Usted puede aplicar para una licencia de conducir con el permiso de sus padres.");
            }
        }
        else
        {
            Console.WriteLine("Lo siento, usted no cumple con los requisitos para aplicar para una licencia de conducir.");
        }
    }
}