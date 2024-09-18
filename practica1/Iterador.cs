/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 18:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
