/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 23:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using practica1;
using System.Linq;

namespace practica1
{
	/// <summary>
	/// Description of CompararPorNombre.
	/// </summary>
	public class CompararPorNombre : EstrategiaDeComparacion 
    {
		 public bool SosMayor(Alumno a, Alumno b)
        {
            return (a.getNombre()).Count() > (b.getNombre()).Count();
        }
        public bool SosMenor(Alumno a, Alumno b)
        {
            return (a.getNombre()).Count() < (b.getNombre()).Count();
        }
        public bool SosIgual(Alumno a, Alumno b)
        {
            return a.getPromedio() == b.getPromedio();
        }
    }
}