/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 18:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno:Persona,Comparable,IAlumno
	{
		private EstrategiaDeComparacion estrategia;
		private  string nombre;
		private string calificacion;
		
		public Alumno()
		{
			this.estrategia = new PorLegajo();
		}
		
		public void setEstrategia(EstrategiaDeComparacion nuevaEstrategia){
			this.estrategia = nuevaEstrategia;
		
		}
		public override bool sosIgual(Comparable com){
			return this.Estrategia.sosIgual(this (alumno) com);
		}
		
		//metodo mostrar calificacion
		
		public string mostrat calificacion(){
			
			return this.getNombre() + "\t" + getCalificacion();
		}
		
		
		
		//Patron decorator creo el decorado
		
		
	}
}
