/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 19:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace practica1
{
	/// <summary>
	/// Description of IteradorDePila.
	/// </summary>
public class IteradorDePila : Iterador
    {
        Pila pIterable;
        int elementoActual;

        public IteradorDePila(Coleccionable p)
        {
            pIterable = (Pila)p;
            primero();
        }

        public void primero()
        {
            elementoActual = 0;
        }

        public void siguiente()
        {
            elementoActual++;
        }

        public bool fin()
        {
            return elementoActual >= pIterable.pila.Count;
        }

        public Comparable actual()
        {
            return pIterable.pila[elementoActual];
        }
    }

}