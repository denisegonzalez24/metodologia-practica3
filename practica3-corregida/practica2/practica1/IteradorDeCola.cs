/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 10/11/2024
 * Time: 00:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of IteradorDeCola.
	/// </summary>
	public class IteradorDeCola : Iterador
    {
        int elementoActual;
        Cola cIteable;

        public IteradorDeCola(Coleccionable c)
        {
            cIteable = (Cola)c;
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
            return elementoActual >= cIteable.cola.Count;
        }

        public Comparable actual()
        {
            return cIteable.cola[elementoActual];
        }
    }
}