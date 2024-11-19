/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using practica1;


namespace practica1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//crear fabrica profesor
		
			
			FabricaDeProfesor fabricProfe = (FabricaDeProfesor)Fabrica.fabricaOpcion(1);
			Profesor profe = (Profesor)fabricProfe.crearAleatorio();
           
			
			llenarAlumnosObservando(profe);
			
			dictadoDeClases(profe);
		

			
			
			Console.ReadKey(true);
		}
		public static void llenarAlumnos(Coleccionable coleccionable)
		{
			
			Random random = new Random();
			for (int i = 0; i < 20; i++)
			{
				string nombreAleatorio = getNombreAleatorio();
				int dniAleatorio = random.Next(10000000, 99999999);
				int legajoAleatorio = random.Next(1000, 9999);
				double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);
				coleccionable.Agregar(new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio));
			}
		}
			
			
			public static void informar(Coleccionable coleccionable)
			{
				Console.WriteLine("El más grande de la coleccion es {0} ", coleccionable.Maximo());
				Console.WriteLine("El más chico de la coleccion es {0} ", coleccionable.Minimo());
				Console.WriteLine("La cantidad de elementos de la coleccion es {0}", coleccionable.Cuantos());
				

				Console.WriteLine("ingrese un numero de dni para buscar: ");
				int dni = int.Parse(Console.ReadLine());
				Console.WriteLine("ingrese nombre: ");
				string nombre = Console.ReadLine();
				Console.WriteLine("ingrese legajo: ");
				int leg = int.Parse(Console.ReadLine());
				Console.WriteLine("ingrese promedio: ");
				double pro = double.Parse(Console.ReadLine());
				
				Comparable comparable = new Alumno(nombre, dni, leg, pro);		

				if (coleccionable.Contiene(comparable))
				{
					Console.WriteLine("El elemento leído está en la colección");
				}
				else
				{
					Console.WriteLine("El elemento leído no está en la colección");
				}
			}
			public static string getNombreAleatorio()
			{
				List<string> nombres = new List<string>();
				nombres.Add("Jose");
				nombres.Add("Roberto");
				nombres.Add("Antonio");
				nombres.Add("Martin");
				nombres.Add("Rodolfo");
				nombres.Add("Miguel");
				nombres.Add("Joaquin");
				nombres.Add("Valentin");
				nombres.Add("Ramiro");
				nombres.Add("Nahuel");
				nombres.Add("Lisandro");
				nombres.Add("Agustina");
				nombres.Add("Josefina");
				nombres.Add("Maria");
				return nombres[new Random().Next(nombres.Count - 1)];
			}
			
//			public void imprimirElementos(Coleccionable coleccionable)
//			{
//				Iterador iterador = coleccionable.crearIterador();
//				
//				while (!iterador.fin())
//				{
//					Console.WriteLine(iterador.actual());
//					iterador.siguiente();
//				}
//			}
			
			public static void cambiarEstrategia(Iterable ite, EstrategiaDeComparacion strategy)
        {
            Pila pila = (Pila)ite;

            foreach (var item in pila.pila)
            {
                Alumno alumno = (Alumno)item;
                alumno.setStrategy(strategy);
            }
        }
			public static void dictadoDeClases(Profesor profesor)
			{
				Random random = new Random();
				int iter = 0;
				do
				{
					switch (random.Next(1, 3))
					{
						case 1:
							profesor.hablarALaClase();
							break;
						case 2:
							profesor.escribirEnElPizarron();
							break;
						default:
							profesor.hablarALaClase();
							break;
					}
					iter++;

				} while (iter < 5);
				
			}
			
			public static void llenarAlumnosObservando(Profesor profesor)
			{
				Random random = new Random();
				for (int i = 0; i < 10; i++)
				{
					string nombreAleatorio = getNombreAleatorio();
					int dniAleatorio = random.Next(10000000, 99999999);
					int legajoAleatorio = random.Next(1000, 9999);
					double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

					Alumno alumno = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
					profesor.agregarObservador((Alumno)alumno);
				}
			}


			// cliente no cambia
//		public static void imprimirElementos(Coleccionable col){
//			//suponiendo que todos los coleccionables son iterables y conocen su iterador por l que es un interfaz
//			//creo iterador
//			Iterador ite = col.crearIterador();
//			ite.primero();
//			while (!ite.fin){
//				Console.WriteLine(ite.actual()); //set estrategia en el ejercicio 9
//				ite.siguiente();
//			}
			
			//variaciones ya no hay new por todo el codigo
//		public static void llenarComparable(Coleccionable col, int opc){
//			for (int i = 1 ; i<=20; i++){
//				Comparable c = FabricaDeComparables.crearAleatorio(opc);
//				col.agregar(c)
//					
//			}
		
	}
	
}
//			
//			informar(pilaAlumnos);
//			Console.WriteLine("Estrategia de comparar por DNI");
//			cambiarEstrategia(pilaAlumnos, new CompararPorDNI());
//			informar(pilaAlumnos);
//			Console.WriteLine("Estrategia de comparacion por Nombre ");
//			cambiarEstrategia(pilaAlumnos, new CompararPorNombre());
//			informar(pilaAlumnos);
//			Console.WriteLine("Estrategia de comparacion por Legajo ");
//			cambiarEstrategia(pilaAlumnos, new CompararPorLegajo());
//			informar(pilaAlumnos);
//			Console.WriteLine("Estrategia de comparacion por Promedio ");
//			cambiarEstrategia(pilaAlumnos, new CompararPorPromedio());
//			informar(pilaAlumnos);