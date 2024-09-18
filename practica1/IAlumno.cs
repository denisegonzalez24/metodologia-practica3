/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 18/09/2024
 * Time: 18:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno : Comparable
	{
		//implementar los metodos que queria utilizar opcionalmente de alumno
		double mostrarCalificacion();
	}
}
