using System;
using System.Collections;

namespace TP_clinica
{

	public class Servicio
	{
		private string especialidad;
		private Medico jefe;
		private int cupo;
		private ArrayList plantel = new ArrayList();
		private ArrayList listaPacientes = new ArrayList();
		
		public Servicio(string especialidad,Medico jefe,int cupo)
		{
			this.especialidad=especialidad;
			this.jefe=jefe;
			this.cupo=cupo;
		}
		
		//Propiedades de servicio:
		
		public string Especialidad{
			get{return especialidad;}
			set{especialidad = value;}
		}
		public Medico Jefe{
			get{return jefe;}
			set{jefe = value;}
		}
		public int Cupo{
			get{return cupo;}
			set{cupo = value;}
		}
		public ArrayList ListaPacientes{
			get{return listaPacientes;}
		}
		public ArrayList Plantel{
			get{return plantel;}
		}
		
		
		//Metodos del objeto medico:
		
		public void agregarMedico(Medico med){
			
			if(med.Especialidad == especialidad){
			
				plantel.Add(med);
			}
		}
		
		public void eliminarMedico(int dni, int legajo){
			ArrayList plantelAux=(ArrayList)plantel.Clone();
			
			foreach (Medico med in plantelAux) {
				if(dni == med.DniMed && legajo == med.Legajo){
					plantel.Remove(med);
				}	
			}
		}
		
		public void totalMedico(){
			
			int contador = 0;
			foreach(Medico med in plantel){
				
				contador = contador + 1;
				Console.WriteLine("La cantidad de medicos es de: "+contador);
				
				}
			}
				
		public void verMedico(int i){
				
			string medico = plantel[i].ToString();
				Console.WriteLine("El medico numero "+i+" es: "+medico);
			}
		
		public void todosMedico(){
			
			
			Console.WriteLine("Medico(s) disponible(s) en el servicio "+especialidad+" :" );
			foreach (Medico med in Plantel) {

				Console.WriteLine(med.NombreMed);
				}
			}
		public void serviciosTurnoNocturno(){
			
						foreach (Medico med in plantel) {
						
							if(med.Horario=="h1"){
					
								Console.WriteLine(Especialidad);
						
						}
							
				}
		}
		
			//Métodos del objeto Paciente:
			
			public void agregarPaciente(Paciente pac, string medico, string servicio){
				
				foreach(Medico med in plantel){
					
					if(medico == med.NombreMed && servicio == especialidad){
						
						//Bloque de excepción, posible falta de camas disponibles:
						
						try {
							
							cupo = cupo - 1;
							if(cupo<0){
							
								throw new ExcepcionFaltaDeCupo();
							}
							else{
						listaPacientes.Add(pac);
						}
						} catch (ExcepcionFaltaDeCupo ){
							
								throw;	
						}
					}	
				}
			}
			
			
			public void eliminarPaciente(int dni,string especialista){
			ArrayList listaPacientesAux=(ArrayList)listaPacientes.Clone();
			
			foreach (Paciente pac in listaPacientesAux) {
				if(dni == pac.DniPac){
					foreach (Medico med in plantel) {
						if(med.NombreMed == especialista){
						
							plantel.Remove(pac);
							cupo = cupo +1;
						
						}
					}
					
				}	
			}
		}

			public void verPaciente(int i){
				
			string pac = listaPacientes[i].ToString();
			Console.WriteLine("El medico numero "+i+" es: "+pac);
			}

			public void todosPaciente(string especialidad){
				if(especialidad == Especialidad){
				foreach (Paciente pac in listaPacientes) {
				
						Console.WriteLine(pac.NombrePac);
					}
				}
			}
			
			public void esPaciente(int dni){
				
				foreach (Paciente pac in listaPacientes) {
					
					if (dni == pac.DniPac){
						
						Console.WriteLine("El paciente está internado en la clinica.");
					}
					
					else{
						
						Console.WriteLine("El paciente no está internado en la clinica.");
					}
					
				}
				
			}
	
	}
}
