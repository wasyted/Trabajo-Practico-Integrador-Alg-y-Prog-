using System;

namespace TP_clinica
{
	
	public class Medico
	{
		private int dni;
		private int legajo;
		private string nombre;
		private string especialidad;
		private string horario;
		private double matricula;
		
		public Medico(int dni, int legajo,string nombre,string especialidad,string horario)
		{
			this.dni=dni;
			this.legajo=legajo;
			this.nombre=nombre;
			this.especialidad=especialidad;
			this.horario=horario;
		}
		
		public int DniMed{
			get{return dni;}
			set{dni = value;}
		}
		public int Legajo{
			get{return legajo;}
			set{legajo = value;}
		}
		public string NombreMed {
			get{return nombre;}
			set{nombre = value;}
		}
		public string Especialidad{
			get{return especialidad;}
			set{especialidad = value;}
		}
		public string Horario {
			get{return horario;}
			set{horario = value;}
		}
		public double Matricula {
			get{return matricula;}
			set{matricula = value;}
		}
	}
}
