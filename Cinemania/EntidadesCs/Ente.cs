using System;

namespace EntidadesCs
{
   public abstract class Ente
   {
      private string nombre;

      public Ente(string nombre)
      {
         Nombre = nombre;
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = value.Length >= 3 ? value : throw new ArgumentException(" el nombre debe tener al menos 3 caracteres.");
      }
   }
}
