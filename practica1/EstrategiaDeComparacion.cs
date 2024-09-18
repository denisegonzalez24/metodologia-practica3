/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 17:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(Alumno a1, Alumno a2);
		bool sosMenor(Alumno a1, Alumno a2);
		bool sosMAYOR(Alumno a1, Alumno a2);
	}
}
