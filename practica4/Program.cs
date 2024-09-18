/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
	
			
			Console.ReadKey(true);
			
			// clase 18/09/2024
			// HACER EN MAIN NUEVO
			// using practica_de_metodologia;
			Teacher teacher = new Teacher();
			Alumno alumno;
			
			for (int i=1; i<=10; i++){
				//probar, luego debo adaptar para que este proceso lo haga una fabrica de student que use a fabrica de alumnos. en las 2 lineas siguientes
				alumno = FabricaDeComparables.crearAleatorio(2);
				Student student = new AlumnoAdapter(alumno);
				teacher.goToClass(student);
			}
			
			teacher.teacherAClass();
			
			
			
			
			
			
		}
		
		// cliente no cambia 
		public static void imprimirElementos(Coleccionable col){
			//suponiendo que todos los coleccionables son iterables y conocen su iterador por l que es un interfaz
			//creo iterador
			Iterador ite = col.crearIterador();
			ite.primero();
			while (!ite.fin){
				Console.WriteLine(ite.actual()); //set estrategia en el ejercicio 9
				ite.siguiente();
			}
			
		}
		
		//variaciones ya no hay new por todo el codigo
		public static void llenarComparable(Coleccionable col, int opc){
			for (int i = 1 ; i<=20; i++){
				Comparable c = FabricaDeComparables.crearAleatorio(opc);
				col.agregar(c);
			}

		}
	}
	
}