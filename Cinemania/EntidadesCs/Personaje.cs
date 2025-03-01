using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCs
{
   public class Personaje : Ente
   {
      private Actor actor; // asoc simple (1 personaje 1 actor)
      private Pelicula pelicula; // asoc bidireccional (1 personaje 1 pelicula) dependiente
      private decimal sueldo;

      public Personaje(string nombre, Actor actor, Pelicula pelicula, decimal sueldo) : base(nombre)
      {
         Actor = actor;
         Sueldo = sueldo;
         Pelicula = pelicula;
      }

      public decimal Sueldo
      {
         get => sueldo;
         set => sueldo = value >= 0 ? value : throw new ArgumentException(" el sueldo no puede ser menor a cero.");
      }

      public Actor Actor
      {
         get => actor;
         set => actor = value ?? throw new ArgumentException(" el actor no puede ser nulo.");
      }

      public Pelicula Pelicula
      {
         get => pelicula;
         set
         {
            pelicula = value ?? throw new ArgumentException(" la pelicula no puede ser nula.");
            pelicula.AddPersonaje(this); // referencia pelicula 
         }
      }

      public override string ToString()
      {
         return $"{Nombre} ({Actor.Nombre})";
      }
   }
}
