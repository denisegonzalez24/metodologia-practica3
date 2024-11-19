/*
 * Created by SharpDevelop.
 * User: Den
 * Date: 4/9/2024
 * Time: 18:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace practica1
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	public interface Coleccionable 
	{
		int Cuantos();
        Comparable Minimo();
        Comparable Maximo();
        void Agregar(Comparable comparable);
        bool Contiene(Comparable comparable);
	}
}
