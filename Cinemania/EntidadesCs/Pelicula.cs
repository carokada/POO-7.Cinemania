using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCs
{
   public class Pelicula : Ente
   {
      private List<Personaje> personajes;

      public ushort Anio { get; set; }

      public Pelicula(string nombre, ushort anio) : base(nombre)
      {
         personajes = new List<Personaje>();

         Anio = anio;
      }

      // public para agregar por demo pero deberia ser internal por asoc
      public void AddPersonaje(Personaje personaje)
      {
         if (personaje == null)
            throw new ArgumentException(" el personaje no puede ser nulo.");
         if (personajes.Contains(personaje))
            throw new ArgumentException(" el personaje ya se encuentra en la lista.");
         personajes.Add(personaje);
      }

      public void RemovePersonaje(Personaje personaje)
      {
         if (personaje == null)
            throw new ArgumentException(" el personaje no puede ser nulo.");
         if (!personajes.Contains(personaje))
            throw new ArgumentException(" el personaje no se encuentra en la lista.");
         personajes.Remove(personaje);
      }

      public List<Personaje> GetPersonajes()
      {
         return personajes;
      }

      public decimal SumarSueldos()
      {
         decimal totalSueldos = 0;
         foreach (var personaje in personajes)
            totalSueldos = personaje.Sueldo;
         return totalSueldos;
      }

      // GetCreditos : lista con los nombres de los actores y su personaje interpretado entre parentesis ordenado por nombre de actor
      public List<string> GetCreditos()
      {
         List<string> creditos = new List<string>();

         string credito = "";
         foreach (var personaje in personajes)
         {
            credito = $"{personaje.Actor} ({personaje})";
            creditos.Add(credito);
         }
         return creditos;
      }

      // versiones linq
      public List<string> GetCreditosOrdenados()
      {
         return personajes
           .Select(personaje => new { Credito = $"{personaje.Actor.Nombre} ({personaje})", personaje.Actor })
           .OrderBy(credito => credito.Actor.Nombre)
           .Select(formato => formato.Credito)
           .ToList();
      }

      public List<string> TopSueldo()
      {
         return personajes
           .OrderByDescending(personaje => personaje.Sueldo)
           .Take(3)
           .Select(personaje => $"{personaje.Actor.Nombre} (${personaje.Sueldo})")
           .ToList();
      }

      // TopSueldo : lista de 3 actores con mejor sueldo. asignar nombre de actor y monto del sueldo.

      public override string ToString()
      {
         return $"{Nombre} ({Anio})";
      }
   }
}
