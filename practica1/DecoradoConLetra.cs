/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 18/09/2024
 * Time: 19:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of DecoradoConLetra.
	/// </summary>
	public class DecoradoConLetra : AlumnoDecorator
	{
		//por legado
		public DecoradoConLetra(IAlumno a)
		{
			this.adicional = a;
		}
		
		//posibilidad de usar una lista array o dict
		
		private 
			
		// variable metodo para otro decorator usar un insert
		public override string mostrarCalificacion(){
			
			insert()
			return base.mostrarCalificacion() + "\t" + adicional.getLegajo();
		}
		
	}
}