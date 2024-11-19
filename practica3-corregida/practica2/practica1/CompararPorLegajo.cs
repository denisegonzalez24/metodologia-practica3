/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 23:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of CompararPorLegajo.
	/// </summary>
	public class CompararPorLegajo : EstrategiaDeComparacion
	{
		
	
		public bool SosMayor(Alumno a, Alumno b)
		{ return a.getLegajo() > b.getLegajo();}
		
		public bool SosMenor(Alumno a, Alumno b)
		{ return a.getLegajo() < b.getLegajo();}
		
		public bool SosIgual(Alumno a, Alumno b)
		{ return a.getLegajo() == b.getLegajo();}
	}
}