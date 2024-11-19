/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 18:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using practica1;

namespace practica1
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
public class Persona : Comparable
    {
        private string nombre;
        private int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre() { return nombre; }
        
        public int getDni() { return dni; }

        public virtual bool SosIgual(Comparable comparable)
        {
        	return dni == ((Persona)comparable).getDni();
        }

        public virtual bool SosMenor(Comparable comparable)
        {
        	return dni < ((Persona)comparable).getDni();
        }

        public virtual bool SosMayor(Comparable comparable)
        {
        	return dni > ((Persona)comparable).getDni();
        }

         public override string ToString()
    {
        return string.Format("Nombre: {0}, DNI: {1}", nombre, dni);
    }
    }
}