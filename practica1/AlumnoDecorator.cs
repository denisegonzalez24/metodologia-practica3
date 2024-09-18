/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 18/09/2024
 * Time: 19:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator : IAlumno
	{
		//es una clase abstracta
		protected IAlumno adicional;
		
		public AlumnoDecorator()
		{
		}
		
		virtual public string mostrarCalificacion(){
			return adicional.mostrarCalificacion();
		}
		
//		public string getNombre()
//		{
//			return adicional.getNombre();
//		}
//	}
}
