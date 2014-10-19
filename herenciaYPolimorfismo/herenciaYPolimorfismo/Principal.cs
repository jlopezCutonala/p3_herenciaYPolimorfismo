using System;

namespace herenciaYPolimorfismo
{
	class Principal
	{
		
		public void polimorfismo(){
			System.Collections.ArrayList arreglo = new System.Collections.ArrayList();
			Alumno alumno = new Alumno();
			alumno.nombre = "Juan Hernandez";
			alumno.edad = 20;
			alumno.codigo = "3443423";
			alumno.semestre = "3";
			
			arreglo.Add(alumno);			
			
			Profesor profesor = new Profesor();
			profesor.nombre = "Mario Rodriguez";
			profesor.edad = 30;
			profesor.codigo = "3443423";
			profesor.materia = "Bases de datos";
			
			arreglo.Add(profesor);
			
			foreach(Persona persona in arreglo){
				Console.WriteLine(persona.informacion());
			}
			
			
		}
		public void alumno(){
			Alumno alumno = new Alumno();
			alumno.nombre = "Juan Hernandez";
			alumno.edad = 20;
			alumno.codigo = "3443423";
			alumno.semestre = "3";
			alumno.presenteEnClase();
			alumno.cumpleaños();
			
			//Polimorfismo	
			Persona persona = alumno;
			persona.cumpleaños();
			Console.WriteLine(persona.informacion());
		
		}
		
		public void profesor(){
			Profesor profesor = new Profesor();
			profesor.nombre = "Mario Rodriguez";
			profesor.edad = 30;
			profesor.codigo = "3443423";
			profesor.materia = "Bases de datos";
			profesor.nombrarLista();
			profesor.cumpleaños();
			
			//Polimorfismo	
			Persona persona = profesor;
			persona.cumpleaños();
			Console.WriteLine(persona.informacion());
		}
		
		public static void Main (string[] args)
		{
			Principal programa = new Principal();
			//programa.alumno();
			//programa.profesor();
			programa.polimorfismo();
			
		}
	}
}

