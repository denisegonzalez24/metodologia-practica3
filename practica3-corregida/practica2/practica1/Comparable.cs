/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 17:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace practica1
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	public interface Comparable
	{
		bool SosIgual(Comparable comparable);
		bool SosMayor(Comparable comparable);
		bool SosMenor(Comparable comparable);
	}
}
