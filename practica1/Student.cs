/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 18/09/2024
 * Time: 18:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter : Student
	{
		private IAlumno alu;
		//modifico
		//private IAlumno alu;
		
		public AlumnoAdapter(IAlumno alu)
		{
			this.alu = alu;
		}
		public string gentName(){
			return alu.getNombre();
		}
		public int yourAnswerIs(int question){
			return alu.responderPregunta(question);
		}
		
	}
}
	

