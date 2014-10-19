using System;
namespace herenciaYPolimorfismo
{
	public class Alumno : Persona
	{
		public string codigo;
		public string semestre;
		
		public Alumno ()
		{
		}
		
		public void presenteEnClase(){
			Console.WriteLine("El alumno con el código " + this.codigo +" y nombre " + this.nombre +" del semetre "+ this.semestre +" se encuentra presente.");
			Console.WriteLine();
		}
		
		public override void cumpleaños(){
			this.edad++;
			Console.WriteLine("Método cumpleaños de la clase Alumno.");
			Console.WriteLine();
		}
		
		public override String informacion(){
			return "Información del alumno \n" +
					"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad+ "\n" +
					"Código :" + this.codigo + "\n" +
					"Semestre :" + this.semestre + "\n";
		}
	}
}

