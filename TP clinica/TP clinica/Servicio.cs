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
		
		public void eliminarMedico(Medico med){
				plantel.Remove(med);
			}
		
		
		public void totalMedico(){
			
			int contador = 0;
			foreach(Medico med in plantel){
				
				contador = contador + 1;
				Console.WriteLine("La cantidad de medicos es de: "+contador);
				
				}
			}
				
		public Medico verMedico(int i){
			
			return (Medico)plantel[i];
			
			}
		
		public ArrayList todosMedico(){
			
			return (ArrayList)plantel;
		}
			
		
			//Métodos del objeto Paciente:
			
			public void agregarPaciente(Paciente pac){
				
				listaPacientes.Add(pac);
			}
			
			
			public void eliminarPaciente(Paciente pac){

				listaPacientes.Remove(pac);
							cupo = cupo +1;
						
						}
					

			public Paciente verPaciente(int i){
				
				return (Paciente)listaPacientes[i];
			}

			public ArrayList todosPaciente(){
				
				return (ArrayList)listaPacientes;
				
					}
				
			
			
			public bool esPaciente(int dni){
				
				foreach (Paciente pac in listaPacientes) {
					
					if (dni == pac.DniPac){

						return true;
					}
					
					else{
						
						return false;
					}
					
				}
				
			}
			
			public int cantPac(){
				
				return listaPacientes.Count;
				
			}
	
	}
}
