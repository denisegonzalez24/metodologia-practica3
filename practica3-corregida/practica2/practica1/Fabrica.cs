/*
 * Created by SharpDevelop.
 * User: den
 * Date: 19/11/2024
 * Time: 19:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of Fabrica.
	/// </summary>
	public abstract class Fabrica
	{
		//public abstract Comparable crearAleatorio();
		
		public virtual Comparable crearAleatorio()
		{
			Fabrica creator = fabricaOpcion(1);
			
			return creator.crearAleatorio();
		}
		
		// public abstract Comparable crearPorTeclado();
		public virtual Comparable crearPorTeclado(int opcion = 1)
		{
			Fabrica creator = fabricaOpcion(opcion);
			
			return creator.crearPorTeclado();
		}
		
		public static Fabrica fabricaOpcion(int opcion)
		{
			Fabrica fabrica = null;
			switch (opcion)
			{
				case 0:
					fabrica = new FabricaDeAlumno();
					break;
				case 1:
					fabrica = new FabricaDeProfesor();
					break;
				default:
					fabrica = new FabricaDeAlumno();
					break;
			}
			return fabrica;
		}
		
		
	}
}
