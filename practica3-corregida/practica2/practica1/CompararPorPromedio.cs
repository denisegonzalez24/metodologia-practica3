/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 23:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of CompararPorPromedio.
	/// </summary>
	public class CompararPorPromedio :  EstrategiaDeComparacion
	{
		public bool SosMayor(Alumno a, Alumno b) { return a.getPromedio() < b.getPromedio();}
		public bool SosMenor(Alumno a, Alumno b) { return a.getPromedio() > b.getPromedio();}
		public bool SosIgual(Alumno a, Alumno b) { return a.getPromedio() == b.getPromedio();}
	}
}
