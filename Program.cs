using System;
namespace Estudiante
{
    public class Program
    {
      public static int Main(String[] args)
      {
          Estudiante[] listaEstudiantes = new Estudiante[9];
          int cont = 0;
          while (cont < 5)
          {
            //INGRESO DEL USUARIO
           Console.WriteLine("Ingrese nombre");
           string nombre = Console.ReadLine();

           Console.WriteLine("Ingrese edad");
           int edad = int.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese carnet");
           string carnet = Console.ReadLine();

           Console.WriteLine("Indique si esta solvente");
           bool solvente = Boolean.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese el curso");
           string curso = Console.ReadLine();

           Console.WriteLine("Ingrese la nota del primer parcial");
           int parcial1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese la nota del segundo parcial");
           int parcial2 = int.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese la nota final");
           int final = int.Parse(Console.ReadLine());

           Estudiante estudiantes = new Estudiante(nombre, edad, carnet, solvente, curso, parcial1, parcial2, final);
           listaEstudiantes[cont] = estudiantes;
           cont++;

          }

          //IMPRIMIR
          Console.WriteLine("----LISTA DE ESTUDIANTES----\n");
          for (int i = 0; 1 < 5; i++)
          {
            Estudiante estudiantes = listaEstudiantes[i];
            Console.WriteLine("Nombre estudiante " + estudiantes.nombre + " Carnet " + estudiantes.carnet + " edad " + estudiantes.edad + " Solvente " + estudiantes.solvente + " Curso " + estudiantes.curso + " Primer parcial " + estudiantes.parcial1 + " Segundo parcial " + estudiantes.parcial2 + " Nota final " + estudiantes.final + "\n");
          }


        }
    }

}