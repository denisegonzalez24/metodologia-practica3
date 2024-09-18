/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 19:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of IteradorDePila.
	/// </summary>
	public class IteradorDePila:Iterador
	{
		private Pila p;
		private int indice;
		
		public IteradorDePila(Pila p )
		{
			this.p = p;
			primero;
		}
		
		public void primero (){
			this.indice = 0;
		}
		public void siguiente(){
			this.indice++;
		}
		public bool fin(){
			return this.indice >= p.cuantos();
		}
		public Comparable actual(){
			return p.getElementos()[indice];
		}
	}
}
