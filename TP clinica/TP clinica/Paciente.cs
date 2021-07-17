using System;

namespace TP_clinica
{

	public class Paciente
	{
			private int dni;
			private string nombre;
			private string apellido;

		
		public Paciente(int dni, string nombre,string apellido)
		{
			this.dni=dni;
			this.nombre=nombre;
			this.apellido=apellido;

		}
		
		//Propiedades del objeto Paciente:
		
		public int DniPac{
			get{return dni;}
			set{dni = value;}
		}
		public string NombrePac {
			get{return nombre;}
			set{nombre = value;}
		}
		public string ApellidoPac {
			get{return apellido;}
			set{apellido = value;}
		}
	}
}
