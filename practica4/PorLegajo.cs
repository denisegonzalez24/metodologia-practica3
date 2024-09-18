/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 18:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo:EstrategiaDeComparacion
	{
		
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getLegajo == a2.getLegajo;
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getLegajo > a2.getLegajo;
		}
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getLegajo < a2.getLegajo;
		}
	}
}
