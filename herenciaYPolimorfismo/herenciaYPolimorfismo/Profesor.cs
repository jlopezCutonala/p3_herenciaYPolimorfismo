using System;
namespace herenciaYPolimorfismo
{
	public class Profesor : Persona
	{
		public string codigo;
		public string materia;
		
		public Profesor ()
		{
		}
		
		public void nombrarLista(){
			Console.WriteLine("El profesor con el código " + this.codigo +" y nombre " + this.nombre +" nombra lista de la materia " + this.materia + ".");
			Console.WriteLine();
		}
		
		public override void cumpleaños(){
			this.edad++;
			Console.WriteLine("Método cumpleaños de la clase Profesor.");
			Console.WriteLine();
		}
		
		public override String informacion(){
			return "Información del profesor \n" +
					"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad+ "\n" +
					"Código :" + this.codigo + "\n" +
					"Materia :" + this.materia + "\n";
		}
	}
}

