/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple : Coleccionable
    {
        public Pila Pila { get; set; }
        public Cola Cola { get; set; }

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.Pila = p;
            this.Cola = c;
        }

        public int Cuantos()
        {
            return Pila.Cuantos() + Cola.Cuantos();
        }

        public Comparable Minimo()
        {
            Comparable minPila = Pila.Minimo();
            Comparable minCola = Cola.Minimo();

            Comparable minGeneral = null;

            if (minPila != null && minCola != null)
            {
                if (minPila.SosMenor(minCola))
                {
                    minGeneral = minPila;
                }
                else
                {
                    minGeneral = minCola;
                }
            }

            return minGeneral;
        }

        public Comparable Maximo()
        {
            Comparable minPila = Pila.Minimo();
            Comparable minCola = Cola.Minimo();

            Comparable maxGeneral = null;

            if (minPila != null && minCola != null)
            {
                if (minPila.SosMenor(minCola))
                {
                    maxGeneral = minPila;
                }
                else
                {
                    maxGeneral = minCola;
                }
            }

            return maxGeneral;
        }

        public void Agregar(Comparable comparable)
        {
            Pila.Agregar(comparable);
            Cola.Agregar(comparable);
        }

        public bool Contiene(Comparable comparable)
        {
            return Pila.Contiene(comparable) || Cola.Contiene(comparable);
        }

        public Iterador CrearIterador()
        {
            throw new NotImplementedException();
        }
    }
}