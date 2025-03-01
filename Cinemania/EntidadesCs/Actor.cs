using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCs
{
   public class Actor : Ente
   {
      private DateTime fechaNacimiento;

      public Actor(string nombre, DateTime fechaNacimiento) : base(nombre)
      {
         FechaNacimiento = fechaNacimiento;
      }

      public DateTime FechaNacimiento
      {
         get => fechaNacimiento;
         set => fechaNacimiento = value < DateTime.Now ? value : throw new ArgumentException(" la fecha de nacimiento no puede ser mayor a la del sistema.");
      }

      public override string ToString()
      {
         return $"{Nombre}";
      }
   }
}
