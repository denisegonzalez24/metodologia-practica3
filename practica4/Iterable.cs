/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 18:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of Iterable.
	/// </summary>
	public interface Iterable
	{
		public iterador crearIterador(){
			return new IteradorDePila(this);
		}
	}
}
