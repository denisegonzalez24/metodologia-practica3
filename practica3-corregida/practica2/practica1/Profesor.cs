/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 11/11/2024
 * Time: 20:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using practica1;

namespace practica1
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona, IObservado
	{
		public int antigueadad { get; set; }
		public bool hablando;
		public List<IObservador> listaObservadores;
		
		   public Profesor(string n, int d, int antiguedad) : base (n, d)
        {
            this.antigueadad = antiguedad;
            this.listaObservadores = new List<IObservador>();
            
        }
		   
		public void hablarALaClase()
        {
            hablando = true;
            Console.WriteLine("Hablando de algún tema."); 
            notificar();
        }
		
		  public void escribirEnElPizarron()
        {
            hablando = false;
            Console.WriteLine("Escribiendo en el pizarrón.");
            notificar();
            
        }
		  public override bool SosIgual(Comparable comparable)
        {
            return this.antigueadad == ((Profesor)comparable).antigueadad;
        }

        public override bool SosMenor(Comparable comparable)
        {
            return this.antigueadad < ((Profesor)comparable).antigueadad;
        }

        public override bool SosMayor(Comparable comparable)
        {
            return this.antigueadad > ((Profesor)comparable).antigueadad;
        }

        public override string ToString()
        {
        	return base.ToString() + string.Format("Profesor: {0} con Dni {1} y antiguedad de {2} años.", this.getNombre(),this.getDni() , this.antigueadad );
        }
        
           public void agregarObservador(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            listaObservadores.Remove(observador);
        }

        public void notificar()
        {
            foreach (var observador in listaObservadores)
            {
                observador.Actualizar(this);
            }
        }

		
	}
}
