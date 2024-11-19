/*
 * Created by SharpDevelop.
 * User: Den
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
		bool SosIgual(Alumno a1, Alumno a2);
		bool SosMenor(Alumno a1, Alumno a2);
		bool SosMayor(Alumno a1, Alumno a2);
	}
}
