using System;

namespace Estudiante
{
  public class Estudiante
  {

    public string nombre;
    public int edad;
    public string carnet;
    public bool solvente;
    public string curso;
    public int parcial1;
    public int parcial2;
    public int final;

    public Estudiante(
      string nombre, 
      string carnet,
      int edad,
      bool solvente,
      string curso,
      int parcial1,
      int parcial2,
      int final
      )
      {
        this.nombre = nombre;
        this.carnet = carnet;
        this.edad = edad;
        this.solvente = solvente;
        this.curso = curso;
        this.parcial1 = parcial1;
        this.parcial2 = parcial2;
        this.final = final;
      }

        public Estudiante(string nombre, int edad, string carnet, bool solvente, string curso, int parcial1, int parcial2, int final)
        {
          this.nombre = nombre;
          this.edad = edad;
          this.carnet = carnet;
          this.solvente = solvente;
          this.curso = curso;
          this.parcial1 = parcial1;
          this.parcial2 = parcial2;
          this.final = final;
        }
  }

}


