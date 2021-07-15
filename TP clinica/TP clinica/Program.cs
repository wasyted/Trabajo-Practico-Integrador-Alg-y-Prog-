/*
 
Una clínica tiene varios servicios. Cada servicio tiene un jefe, una especialidad, un cupo de camas libres, el plantel de médicos que trabajan en él y la lista de pacientes internados. 
Cada médico tiene un dni, legajo, nombre, especialidad, horario que cumple en el servicio (mañana, tarde o noche). De cada paciente se conoce su dni, nombre y apellido, diagnostico.
Se deberá desarrollar una aplicación, utilizando las clases que crea necesarias, que resuelva las funcionalidades que se muestran en el siguiente menú:

a) Agregar un médico en el servicio correspondiente a su especialidad.

b) Eliminar un médico dado.

c) Internar un paciente en un servicio dado y a cargo de un médico determinado (Se modifica el cupo de camas libres y se agrega el paciente a la lista del servicio). 
En caso de no haber camas libres en dicho servicio, se debe levantar una excepción indicando lo sucedido (“No hay cama disponible”).

d) Listado de los servicios que tienen médicos de guardia en horario nocturno.

e) Dar el alta (egreso) a un paciente internado en un servicio dado y a cargo de un médico determinado.

f) Listado de servicios.

g) Listado de médicos.

h) Listado de pacientes de un servicio.

*/
using System;
using System.Collections;

namespace TP_clinica
{
	class Program
	{
		public static void Main(string[] args)
		{
			int dni;
			int legajo;
			string nombre;
			string especialidad;
			string horario;
			string apellido;
			string serv;
			string especialista;
			
			//Instancio la clase clinica
			Clinica salud = new Clinica("salud");
			
			//Instancio 4 jefes de tipo Medico para los servicios
			Medico jefe1 = new Medico(32623226, 1515, "carlos","e1","h1");
			Medico jefe2 = new Medico(22723226, 1616, "enrique","e2","h2");
			Medico jefe3 = new Medico(41323226, 1717, "oscar","e3","h3");
			Medico jefe4 = new Medico(37323226, 1818, "roman","e4","h1");
			
			//Instancio 4 servicios
			Servicio kinesiologia = new Servicio("e1",jefe1,3);
			Servicio odontologia = new Servicio("e2",jefe2,1);
			Servicio radiologia = new Servicio("e3",jefe3,4);
			Servicio cardiologia = new Servicio("e4",jefe4,5);
			
			//Agrego los servicios a la clinica
			salud.agregarServicio(kinesiologia);
			salud.agregarServicio(odontologia);
			salud.agregarServicio(radiologia);
			salud.agregarServicio(cardiologia);
			
			//Menu de opciones con bloque while
			Console.WriteLine(" 1 - agregar medico");
			Console.WriteLine(" 2 - eliminar medico");
			Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
			Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
			Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
			Console.WriteLine(" 6 - listado de servicios");
			Console.WriteLine(" 7 - listado de medicos");
			Console.WriteLine(" 8 - listado de pacientes de un servicio");
			Console.WriteLine();
			
			Console.Write("Seleccione una opcion del menu: ");
			int opcion = int.Parse(Console.ReadLine());
			Console.Clear();
			while (opcion != 9){
				
				switch(opcion){
						
					case 1: //Agregar medico
						
						Console.WriteLine("Dni del medico");
						dni = int.Parse(Console.ReadLine());
						Console.WriteLine("Legajo del medico");
						legajo = int.Parse(Console.ReadLine());
						Console.WriteLine("Nombre del medico");
						nombre = Console.ReadLine().ToLower();
						Console.WriteLine("Especialidad: ");
						Console.WriteLine("e1 - Kinesiologia ");
						Console.WriteLine("e2 - Odontologia ");
						Console.WriteLine("e3 - Radiologia ");
						Console.WriteLine("e4 - Cardiologia ");
						especialidad = Console.ReadLine().ToLower();
						Console.WriteLine("Horario");
						Console.WriteLine("h1 - 00:00 a 08:00");
						Console.WriteLine("h2 - 08:00 a 16:00");
						Console.WriteLine("h3 - 16:00 a 00:00");
						
						horario = Console.ReadLine().ToLower();
						
								
						
						switch (especialidad) {
							case "e1" :
									Medico med = new Medico(dni,legajo,nombre,especialidad,horario);
									kinesiologia.agregarMedico(med);
									Console.WriteLine("Medico agregado al servicio de kinesiología");
								break;
							case "e2" :
									Medico med1 = new Medico(dni,legajo,nombre,especialidad,horario);
									odontologia.agregarMedico(med1);
									Console.WriteLine("Medico agregado al servicio de odontologia");
									
								break;
							case "e3":
									Medico med2 = new Medico(dni,legajo,nombre,especialidad,horario);
									radiologia.agregarMedico(med2);
									Console.WriteLine("Medico agregado al servicio de radiologia");
								break;
							case "e4" :
									Medico med3 = new Medico(dni,legajo,nombre,especialidad,horario);
									cardiologia.agregarMedico(med3);
									Console.WriteLine("Medico agregado al servicio de cardiologia");
								break;
							default:
									Console.WriteLine("Especialidad invalida, intente nuevamente: ");

								break;
						}
						
						Console.WriteLine("Presione una tecla para volver al menú...");
						Console.ReadKey();
						Console.Clear();
						
						//Vuelvo a mostrar el menú
						Console.WriteLine("Seleccione una opcion del menu: ");
						Console.WriteLine(" 1 - agregar medico");
						Console.WriteLine(" 2 - eliminar medico");
						Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
						Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
						Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
						Console.WriteLine(" 6 - listado de servicios");
						Console.WriteLine(" 7 - listado de medicos");
						Console.WriteLine(" 8 - listado de pacientes de un servicio");
						Console.WriteLine(" 9 - salir del programa);");
						Console.WriteLine();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
						
						break;
					case 2:	//Eliminar un medico
						
						Console.WriteLine("Ingrese dni y legajo del medico a dar de baja: ");
						Console.Write("DNI: ");
						dni = int.Parse(Console.ReadLine());
						Console.Write("Legajo: ");
						legajo = int.Parse(Console.ReadLine());
						
						kinesiologia.eliminarMedico(dni,legajo);
						odontologia.eliminarMedico(dni,legajo);
						radiologia.eliminarMedico(dni,legajo);
						cardiologia.eliminarMedico(dni,legajo);
						
						Console.WriteLine("Medico eliminado satisfactoriamente");
						
						Console.WriteLine();
						Console.WriteLine("Presione una tecla para volver al menú...");
						Console.ReadKey();
						Console.Clear();
						
						//Vuelvo a mostrar el menú
						Console.WriteLine("Seleccione una opcion del menu: ");
						Console.WriteLine(" 1 - agregar medico");
						Console.WriteLine(" 2 - eliminar medico");
						Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
						Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
						Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
						Console.WriteLine(" 6 - listado de servicios");
						Console.WriteLine(" 7 - listado de medicos");
						Console.WriteLine(" 8 - listado de pacientes de un servicio");
						Console.WriteLine(" 9 - salir del programa);");
						Console.WriteLine();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
						
						break;
					case 3: 	//Internar un paciente
						
						Console.WriteLine("Dni del paciente: ");
						dni = int.Parse(Console.ReadLine());
						
						Console.WriteLine("Nombre del paciente: ");
						nombre = Console.ReadLine().ToLower();
							
						Console.WriteLine("Apellido del paciente: ");
						apellido = Console.ReadLine().ToLower();
							
						Console.WriteLine("Servicio requerido: ");
						Console.WriteLine();
						Console.WriteLine("e1 - Kinesiologia ");
						Console.WriteLine("e2 - Odontologia ");
						Console.WriteLine("e3 - Radiologia ");
						Console.WriteLine("e4 - Cardiologia ");
						serv = Console.ReadLine().ToLower();
						
						Paciente pac = new Paciente(dni, nombre, apellido, serv);
						
						Console.WriteLine("Nombre del medico a cargo: ");
						especialista = Console.ReadLine().ToLower();
						
						switch (serv) {
							case "e1":
								kinesiologia.agregarPaciente(pac,especialista,serv);
								Console.WriteLine("Paciente internado con exito para kinesiologia");
								break;
							case "e2":
								odontologia.agregarPaciente(pac,especialista,serv);
								Console.WriteLine("Paciente internado con exito para odontologia");
								break;
							case "e3":
								radiologia.agregarPaciente(pac,especialista,serv);
								Console.WriteLine("Paciente internado con exito para radiologia");
								break;
							case "e4":
								cardiologia.agregarPaciente(pac,especialista,serv);
								Console.WriteLine("Paciente internado con exito para cardiologia");
								break;
						}
						
						Console.WriteLine();						
						Console.WriteLine("Presione una tecla para volver al menú...");
						Console.ReadKey();
						Console.Clear();
						
						//Vuelvo a mostrar el menú
						Console.WriteLine("Seleccione una opcion del menu: ");
						Console.WriteLine(" 1 - agregar medico");
						Console.WriteLine(" 2 - eliminar medico");
						Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
						Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
						Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
						Console.WriteLine(" 6 - listado de servicios");
						Console.WriteLine(" 7 - listado de medicos");
						Console.WriteLine(" 8 - listado de pacientes de un servicio");
						Console.WriteLine(" 9 - salir del programa);");
						Console.WriteLine();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
						
						break;
					case 4:	//Listado de servicios con medicos en turno nocturno
								
								Console.WriteLine("Lista de Servicios: ");
								Console.WriteLine();
								Console.WriteLine("e1 - Kinesiologia ");
								Console.WriteLine("e2 - Odontologia ");
								Console.WriteLine("e3 - Radiologia ");
								Console.WriteLine("e4 - Cardiologia ");
								Console.WriteLine();
								Console.WriteLine("Los siguientes servicios tienen medicos en turno nocturno: ");
								kinesiologia.serviciosTurnoNocturno();
								odontologia.serviciosTurnoNocturno();
								radiologia.serviciosTurnoNocturno();
								cardiologia.serviciosTurnoNocturno();
								
								Console.WriteLine();
								Console.WriteLine("Presione una tecla para volver al menú...");
								Console.ReadKey();
								Console.Clear();
						
								//Vuelvo a mostrar el menú
								Console.WriteLine("Seleccione una opcion del menu: ");
								Console.WriteLine(" 1 - agregar medico");
								Console.WriteLine(" 2 - eliminar medico");
								Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
								Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
								Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
								Console.WriteLine(" 6 - listado de servicios");
								Console.WriteLine(" 7 - listado de medicos");
								Console.WriteLine(" 8 - listado de pacientes de un servicio");
								Console.WriteLine(" 9 - salir del programa);");
								Console.WriteLine();
								opcion = int.Parse(Console.ReadLine());
								Console.Clear();
						
						break;
					case 5:	//Dar el alta a un paciente con medico determinado
						
						Console.WriteLine("Dni del paciente: ");
						dni = int.Parse(Console.ReadLine());
						
						Console.WriteLine("Nombre del medico a cargo: ");
						especialista = Console.ReadLine().ToLower();
						
						kinesiologia.eliminarPaciente(dni, especialista);
						odontologia.eliminarPaciente(dni, especialista);
						radiologia.eliminarPaciente(dni, especialista);
						cardiologia.eliminarPaciente(dni, especialista);
							
						Console.WriteLine();
						Console.WriteLine("Presione una tecla para volver al menú...");
						Console.ReadKey();
						Console.Clear();
						
						//Vuelvo a mostrar el menú
						Console.WriteLine("Seleccione una opcion del menu: ");
						Console.WriteLine(" 1 - agregar medico");
						Console.WriteLine(" 2 - eliminar medico");
						Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
						Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
						Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
						Console.WriteLine(" 6 - listado de servicios");
						Console.WriteLine(" 7 - listado de medicos");
						Console.WriteLine(" 8 - listado de pacientes de un servicio");
						Console.WriteLine(" 9 - salir del programa);");
						Console.WriteLine();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
						
						break;
					case 6:	//Listado de servicios disponibles
						
						salud.todosServicio();
						
						Console.WriteLine();
						Console.WriteLine("Presione una tecla para volver al menú...");
						Console.ReadKey();
						Console.Clear();
						
						//Vuelvo a mostrar el menú
						Console.WriteLine("Seleccione una opcion del menu: ");
						Console.WriteLine(" 1 - agregar medico");
						Console.WriteLine(" 2 - eliminar medico");
						Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
						Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
						Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
						Console.WriteLine(" 6 - listado de servicios");
						Console.WriteLine(" 7 - listado de medicos");
						Console.WriteLine(" 8 - listado de pacientes de un servicio");
						Console.WriteLine(" 9 - salir del programa);");
						Console.WriteLine();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
						
						break;
					case 7:	//Listado de medicos disponibles
						
						Console.WriteLine("Codigo de specialidad: ");
						Console.WriteLine("E1 - Kinesiologia ");
						Console.WriteLine("E2 - Odontologia ");
						Console.WriteLine("E3 - Radiologia ");
						Console.WriteLine("E4 - Cardiologia ");
						Console.WriteLine();
						kinesiologia.todosMedico();
						Console.WriteLine();
						radiologia.todosMedico();
						Console.WriteLine();
						odontologia.todosMedico();
						Console.WriteLine();
						cardiologia.todosMedico();
						Console.WriteLine();
						
						Console.WriteLine();
						Console.WriteLine("Presione una tecla para volver al menú...");
						Console.ReadKey();
						Console.Clear();
						
						//Vuelvo a mostrar el menú
						Console.WriteLine("Seleccione una opcion del menu: ");
						Console.WriteLine(" 1 - agregar medico");
						Console.WriteLine(" 2 - eliminar medico");
						Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
						Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
						Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
						Console.WriteLine(" 6 - listado de servicios");
						Console.WriteLine(" 7 - listado de medicos");
						Console.WriteLine(" 8 - listado de pacientes de un servicio");
						Console.WriteLine(" 9 - salir del programa);");
						Console.WriteLine();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
						
						break;
						
					case 8:	//Listado de pacientes en un servicio
						
						Console.WriteLine("Seleccione un servicio para ver la lista de pacientes: ");
						Console.WriteLine("Codigo de specialidad: ");
						Console.WriteLine("E1 - Kinesiologia ");
						Console.WriteLine("E2 - Odontologia ");
						Console.WriteLine("E3 - Radiologia ");
						Console.WriteLine("E4 - Cardiologia ");
						
						especialidad = Console.ReadLine();
						
						kinesiologia.todosPaciente(especialidad);
						radiologia.todosPaciente(especialidad);
						odontologia.todosPaciente(especialidad);
						cardiologia.todosPaciente(especialidad);
						
						Console.WriteLine();
						Console.WriteLine("Presione una tecla para volver al menú...");
						Console.ReadKey();
						Console.Clear();
						
						//Vuelvo a mostrar el menú
						
						Console.WriteLine("Seleccione una opcion del menu: ");
						Console.WriteLine(" 1 - agregar medico");
						Console.WriteLine(" 2 - eliminar medico");
						Console.WriteLine(" 3 - internar un paciente con un medico a cargo");
						Console.WriteLine(" 4 - lista de servicios con medicos de turno nocturno");
						Console.WriteLine(" 5 - dar el alta a un paciente con un medico determinado");
						Console.WriteLine(" 6 - listado de servicios");
						Console.WriteLine(" 7 - listado de medicos");
						Console.WriteLine(" 8 - listado de pacientes de un servicio");
						Console.WriteLine(" 9 - salir del programa);");
						Console.WriteLine();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
						
						break;
						
					case 9:
						
						Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						
						break;
				}
				
			}
			
		}
	}
}