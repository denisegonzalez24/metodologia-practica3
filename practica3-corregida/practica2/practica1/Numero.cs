/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 9/11/2024
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using practica1;


namespace practica1
{
	
	public class Numero : Comparable
    	
    {
        public int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int getValor()
        {
            return valor;
        }

        public virtual bool SosIgual(Comparable comparable)
        {
        	return this.valor == ((Numero)comparable).getValor();
        }

        public virtual bool SosMenor(Comparable comparable)
        {
        	return this.valor < ((Numero)comparable).getValor();
        }

        public virtual bool SosMayor(Comparable comparable)
        {
            return this.valor > ((Numero)comparable).getValor();
        }

        public override string ToString()
        {
            return this.getValor().ToString();
        }
    }
}