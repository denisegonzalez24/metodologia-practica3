/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of FabricaDeAlumno.
	/// </summary>
	public class FabricaDeAlumno: FabricaDeComparables
	{
		public FabricaDeAlumno()
		{
		}
		
		
		public override Comparable CrearAleatorio(){
			return new Alumno(aleatorio.stringAleatorio(5), aleatorio.numeroAleatorio(10), aleatorio.numeroAleatorio(1000), aleatorio.numero(10));
		}

	}
}
