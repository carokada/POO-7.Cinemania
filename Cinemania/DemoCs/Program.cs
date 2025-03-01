using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         string divisor = "----------------------------------------------------------";

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando actores...");
         Actor actor1 = new Actor("Zendaya", new DateTime(1996, 9, 1));
         Actor actor2 = new Actor("Mike Faist", new DateTime(1992, 1, 5));
         Actor actor3 = new Actor("Josh O'Connor", new DateTime(1990, 5, 20));
         Actor actor4 = new Actor("Timothee Chalamet", new DateTime(1996, 9, 1));
         Actor actor5 = new Actor("Ana Taylor-Joy", new DateTime(1996, 4, 16));
         try
         {
            Actor actor6 = new Actor("T", new DateTime(1996, 4, 16));
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Actor actor6 = new Actor("Tom Hardy", new DateTime(2025, 4, 16));
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n actores cargados:");
         Console.WriteLine(actor1);
         Console.WriteLine(actor2);
         Console.WriteLine(actor3);
         Console.WriteLine(actor4);
         Console.WriteLine(actor5);

         Console.WriteLine($"\n {divisor}");
         Console.WriteLine(" cargando peliculas...");
         Pelicula pelicula1 = new Pelicula("Challengers", 2024);
         Pelicula pelicula2 = new Pelicula("Dune: Part Two", 2024);
         Pelicula pelicula3 = new Pelicula("Emma", 2020);
         Console.WriteLine("\n peliculas cargadas:");
         Console.WriteLine(pelicula1);
         Console.WriteLine(pelicula2);
         Console.WriteLine(pelicula3);

         Console.WriteLine($"\n {divisor}");
         Console.WriteLine(" cargando personajes...");
         Personaje personaje1 = new Personaje("Tashi Duncan", actor1, pelicula1, 3000000);
         Personaje personaje2 = new Personaje("Art Donaldson", actor2, pelicula1, 2500000);
         Personaje personaje3 = new Personaje("Patrick Zweig", actor3, pelicula1, 2500000);
         Personaje personaje4 = new Personaje("Chani", actor1, pelicula2, 5000000);
         Personaje personaje5 = new Personaje("Paul Atreides", actor4, pelicula2, 6000000);
         Personaje personaje6 = new Personaje("Alia Atreides", actor5, pelicula2, 4000000);
         Personaje personaje7 = new Personaje("Emma Woodhouse", actor5, pelicula3, 4000000);
         Personaje personaje8 = new Personaje("Mr. Elton", actor3, pelicula3, 4000000);
         try
         {
            Personaje personaje9 = new Personaje("Mr. Knightley", null, pelicula3, 4000000);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Personaje personaje9 = new Personaje("Furiosa", actor5, null, 4000000);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n personajes cargados:");
         Console.WriteLine(personaje1);
         Console.WriteLine(personaje2);
         Console.WriteLine(personaje3);
         Console.WriteLine(personaje4);
         Console.WriteLine(personaje5);
         Console.WriteLine(personaje6);
         Console.WriteLine(personaje7);
         Console.WriteLine(personaje8);

         Console.WriteLine($"\n {divisor}");
         Console.WriteLine(" mostrando personajes por pelicula... \n");
         MostrarPersonajesPorPelicula(pelicula1);
         MostrarPersonajesPorPelicula(pelicula2);
         MostrarPersonajesPorPelicula(pelicula3);

         Console.WriteLine(divisor);
         Console.WriteLine(" probando metodos RemovePersonaje y AddPersonaje... \n");
         pelicula2.RemovePersonaje(personaje6);
         MostrarPersonajesPorPelicula(pelicula2);
         pelicula2.AddPersonaje(personaje6);
         MostrarPersonajesPorPelicula(pelicula2);

         Console.WriteLine(divisor);
         Console.WriteLine(" mostrando creditos por pelicula... \n");
         MostrarCreditosOrdenadosPorPelicula(pelicula1);
         MostrarCreditosOrdenadosPorPelicula(pelicula2);
         MostrarCreditosOrdenadosPorPelicula(pelicula3);

         Console.WriteLine(divisor);
         Console.WriteLine(" mostrando mejores sueldos por pelicula... \n");
         MostrarTopSueldosPorPelicula(pelicula1);
         MostrarTopSueldosPorPelicula(pelicula2);
         MostrarTopSueldosPorPelicula(pelicula3);

         //Console.WriteLine($"\n {divisor}");
         //Console.WriteLine("");
         //Console.WriteLine();
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarPersonajesPorPelicula(Pelicula pelicula)
      {
         Console.WriteLine($" personajes de {pelicula}");
         foreach (var personaje in pelicula.GetPersonajes())
            Console.WriteLine($"\t ~ {personaje}");
         Console.WriteLine();
      }

      private static void MostrarCreditosOrdenadosPorPelicula(Pelicula pelicula)
      {
         Console.WriteLine($" creditos de {pelicula}");
         foreach (var actor in pelicula.GetCreditosOrdenados())
            Console.WriteLine($"\t ~ {actor}");
         Console.WriteLine();
      }

      private static void MostrarTopSueldosPorPelicula(Pelicula pelicula)
      {
         Console.WriteLine($" top sueldos de {pelicula}");
         foreach (var sueldo in pelicula.TopSueldo())
            Console.WriteLine($"\t ~ {sueldo}");
         Console.WriteLine();
      }
   }
}
