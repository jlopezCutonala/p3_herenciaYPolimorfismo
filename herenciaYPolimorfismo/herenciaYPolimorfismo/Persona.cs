using System;
namespace herenciaYPolimorfismo
{
	public class Persona
	{
		public string nombre;
		public int edad;
		
		public Persona(){
			this.nombre = "";
			this.edad = 0;
		}
		
		public virtual void cumpleaños(){
			this.edad++;
			Console.WriteLine("Método cumpleaños de la clase Persona.");
			Console.WriteLine();
		}
		
		public virtual String informacion(){
			return "Información de la persona \n" +
					"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad;
		}
	}
}

