
using System;
using System.Collections;

namespace TP_clinica
{
	public class Clinica
	{
		ArrayList listaServicios = new ArrayList();
		string nombreClinica;
		
		
		public Clinica(string nombreClinica)
		{	
			this.nombreClinica=nombreClinica;
		}
		
		//Propiedades:
		
		public string NombreClinica{
			
				get{return nombreClinica;}
				set{nombreClinica = value;}
			
			}
			public ArrayList ListaServicios{
			
				get{return listaServicios;}

				
			}
		
		//Metodos:
		
		public void agregarServicio(Servicio ser){
				
				listaServicios.Add(ser);
				
			}
			
		public void eliminarServicio(string especialidad){
			
			foreach (Servicio ser in listaServicios) {
				
				if(especialidad == ser.Especialidad){
					
						listaServicios.Remove(ser);
					}
				}
			}
			
		public void cantidadServ(){
			
				int contador=0;
					foreach (Servicio ser in listaServicios) {
						
						contador = contador + 1;
						
					}
				Console.WriteLine("Hay "+contador+" servicio(s) disponibles.");
				
			}
			
		public Servicio verServicio(int i){
			Servicio ser = (Servicio)ListaServicios[i];
			return ser;
				
			}
			
		public ArrayList todosServ(){
			
			
			return (ArrayList)listaServicios;
			}
			
			
		public void existeServ(string especialidad){
			
				foreach (Servicio ser in listaServicios) {
					
					if(especialidad == ser.Especialidad){
					
						Console.WriteLine("El servicio de "+especialidad+" está disponible en la clinica.");
						}
					else{
						
						Console.WriteLine("El servicio de "+especialidad+" no está disponible en la clinica.");	
							
						}
					
					
						
				}
			}
	}
}
