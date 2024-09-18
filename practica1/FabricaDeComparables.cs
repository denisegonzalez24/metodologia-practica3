/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 19:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		private GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
		private GeneradorDeDatosTeclado teclado = new GeneradorDeDatosTeclado();
			
		//el metodo crea fabricas no comparables, pero a esa fabrica despues se le pide que cree 	
		public static Comparable crearPorAleatorio(int opcion){
			FabricaDeComparables fabrica = null;
			switch (opcion){
					case 1: fabrica = new FabricaDeAlumno();
									  break;
					
					//case 2: fabrica = new FabricaDePersona;
					//case 3: fabrica = new FabricaDeProfesor;
					case 4: fabrica = new FabricaDeAlumno();
									break;
					
			return fabrica.CrearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables facbrica = null;
			switch (opcion){
					case 1: fabrica ;
					case 2: fabrica ;
					
			}
		}
		//por cada static tengo un abstracto
		public abstract Comparable CrearAleatorio(){
			
		}
		public abstract Comparable CrearAleatorio(){
			
		}
	}
}
