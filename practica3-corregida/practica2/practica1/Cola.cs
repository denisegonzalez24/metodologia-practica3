/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 18:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;


namespace practica1
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : Coleccionable, Iterable
	{
		public List<Comparable> cola = new List<Comparable>();

		public int Cuantos()
		{
			return cola.Count;
		}

		public Comparable Minimo()
		{
			Comparable minimo = cola[0];
			foreach (Comparable elemento in cola)
			{
				if (elemento.SosMenor(minimo))
					minimo = elemento;
			}
			return minimo;
		}

		public Comparable Maximo()
		{
			Comparable maximo = cola[0];
			foreach (Comparable elemento in cola)
			{
				if (elemento.SosMayor(maximo))
					maximo = elemento;
			}
			return maximo;
		}

		public void Agregar(Comparable comparable)
		{
			cola.Add(comparable);
		}

		public bool Contiene(Comparable comparable)
		{
			foreach (Comparable elemento in cola)
			{
				if (elemento.SosIgual(comparable))
					return true;
			}
			return false;
		}
		public Iterador crearIterador()
		{
			return new IteradorDeCola(this);
		}
	}
}