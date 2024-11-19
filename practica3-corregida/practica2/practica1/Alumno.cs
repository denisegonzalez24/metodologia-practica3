/*
 * Created by SharpDevelop.
 * User: Den
 * Date: 4/9/2024
 * Time: 18:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona , IObservador
	{
		private int calificacion;
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia;
		private string[] distracciones = {
            "Mirando el celular",
            "Dibujando en el margen de la carpeta",
            "Tirando aviones de papel"
        };
		
		
		public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public void setStrategy(EstrategiaDeComparacion nuevaEstrategia)
        {
            this.estrategia = nuevaEstrategia;
        }

        public int getLegajo()
        {
            return legajo;
        }
		public double getPromedio()
        {
            return promedio;
        }

       
		public override string ToString()
		{
			return base.ToString() + string.Format(", Legajo: {0}, Promedio: {1}", legajo, promedio);
		}
		
		public  bool SosIgual(Alumno comparable)
        {
			return legajo == ((Alumno)comparable).getLegajo();
        }
		
		  public bool SosMayor(Alumno comparable)
        {
		  	return legajo > ((Alumno)comparable).getLegajo();
        }
		  
        public bool SosMenor(Alumno comparable)
        {
        	return legajo < ((Alumno)comparable).getLegajo();
        }
        public void Distraerse()
        {
        	Random random = new Random();
        	Console.WriteLine( this.getNombre() + " esta distraído con: " + distracciones[random.Next(0,2)]);
        }
        
        
        public void PrestarAtencion()
        {
        	Console.WriteLine(this.getNombre() + " está prestando atención.");
        }
        
        public void Actualizar(IObservado observado)
        {
            if (observado is Profesor)
            {
                bool hablando = ((Profesor)observado).hablando;
                if (hablando)
                {
                    PrestarAtencion();
                }
                else
                {
                    Distraerse();
                }
            }
        }

       


//
//        public int GetCalificacion()
//        {
//            return this.calificacion;
//        }
//
//        public double GetPromerdio()
//        {
//            return this.promedio;
//        }
//
//        public void SetCalificacion(int calificacion)
//        {
//            this.calificacion = calificacion;
//        }
//
//        public virtual int ResponderPregunta(int pregunta)
//        {
//            return new Random().Next(1, 3);
//        }
//
//        public virtual string MostrarCalificacion()
//        {
//            return this.GetNombre() + " - " + this.GetCalificacion();
//        }
//        
   		
	}
}
