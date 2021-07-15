
using System;

namespace TP_clinica
{
	/// <summary>
	/// En esta clase está definida la excepcion de falta de cupo de camas disponibles.
	/// </summary>
	public class ExcepcionFaltaDeCupo:Exception
	{
		public void ExepcionFaltaDeCupo()
		{

				Console.WriteLine("No hay cupo de camas disponible");	

			
		}
	}
}