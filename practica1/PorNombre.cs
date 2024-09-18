/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 18:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of PorNombre.
	/// </summary>
	public class PorNombre:EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getNombre.compareTo == a2.getNombre;
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getNombre > a2.getNombre;
		}
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getNombre < a2.getNombre;
		}
	}
}
