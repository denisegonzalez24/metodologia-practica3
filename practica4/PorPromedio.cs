/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 18:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of PorPromedio.
	/// </summary>
	public class PorPromedio:EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getPromedio == a2.getPromedio;
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getPromedio > a2.getPromedio;
		}
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getPromedio < a2.getPromedio;
		}
	}
}
