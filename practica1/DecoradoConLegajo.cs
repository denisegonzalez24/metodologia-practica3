/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 18/09/2024
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of AlumnoDecoratorA.
	/// </summary>
	public class DecoradoConLegajo : AlumnoDecorator
	{
		
		//por legado
		public DecoradoConLegajo(IAlumno a)
		{
			this.adicional = a;
		}
		
		//metodo que se usa para variar al decorator
		public override string mostrarCalificacion(){
			return base.mostrarCalificacion() + "\t" + adicional.getLegajo();
		}
		
	}
}
