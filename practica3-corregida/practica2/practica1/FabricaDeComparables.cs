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
	public interface FabricaDeComparables
	{
		Comparable crearAleatorio();
		Comparable crearPorTeclado(int opcion);
	}
}

