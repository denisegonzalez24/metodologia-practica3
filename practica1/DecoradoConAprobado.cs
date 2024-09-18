/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 18/09/2024
 * Time: 19:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of DecoradoConAprobado.
	/// </summary>
	public class DecoradoConAprobado : AlumnoDecorator
	{
		//por legado
		public DecoradoConAprobado(IAlumno a)
		{
			this.adicional = a;
		}
		
		//metodo que se usa para variar al decorator
		public override string mostrarCalificacion(){
			return base.mostrarCalificacion() + "\t" + adicional.getLegajo();
		}
		
		
		// variable metodo para otro decorator usar un insert
		public override string mostrarCalificacion(){
			
			insert()
			return base.mostrarCalificacion() + "\t" + adicional.getLegajo();
		}
		
	}
}