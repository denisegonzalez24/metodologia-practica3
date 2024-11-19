/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 23:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of CompararPorDNI.
	/// </summary>
	public partial class CompararPorDNI : EstrategiaDeComparacion
    {
		public bool SosMayor(Alumno a, Alumno b) { return a.getDni() <  b.getDni();}
		public bool SosMenor(Alumno a, Alumno b) { return a.getDni() >  b.getDni();}
		public bool SosIgual(Alumno a, Alumno b) { return a.getDni() ==  b.getDni();}
    
}
}