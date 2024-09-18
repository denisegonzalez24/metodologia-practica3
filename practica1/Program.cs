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
			Student student;
			
			for (int i=1; i<=10; i++){
				//probar, luego debo adaptar para que este proceso lo haga una fabrica de student que use a fabrica de alumnos. en las 2 lineas siguientes
				alumno = FabricaDeComparables.crearAleatorio(2);
				
				student = new AlumnoAdapter(alumno);
				teacher.goToClass(student);
			}
			
			teacher.teacherAClass();
			// IMLEMENTO PATRON DECORATOR - Creo la cadena recursiva
			//no debe faltar alumno porque es la unica clase que sabe la nota y el nombre
			Teacher teacher = new Teacher();
			Student student1;
			IAlumno alumno, deco1,deco2,deco3;
			for (int i=1; i<=10; i++){
				
				alumno = FabricaDeComparables.crearAleatorio(2);
				deco1 = new DecoradoConLetra(alumno);
				deco2 = new DecoradoConLegajo(deco1);
				deco3 = new DecoradoConAprobado(deco2);
				
				student1 = new AlumnoAdapter(alumno);
				teacher.goToClass(student1);
			}
			teacher.teachingAClass();
			
			//IMPLEMENTO CON FABRICAS
			// IMLEMENTO PATRON DECORATOR - Creo la cadena recursiva
			//no debe faltar alumno porque es la unica clase que sabe la nota y el nombre
			Teacher teacher1;
			Student student1;
			IAlumno alumno1, deco11,deco22,deco33;
//			for (int i=1; i<=10; i++){
//				
//				alumno = FabricaDeComparables.crearAleatorio(2);
//				deco1 = new DecoradoConLetra(alumno);
//				deco2 = new DecoradoConLegajo(deco1);
//				deco3 = new DecoradoConAprobado(deco2);
//				
//				student1 = new AlumnoAdapter(alumno);
			student1 = FabricaDeComparables.crearAleatorio(8);
			teacher.goToClass(student1);
			}
			
			
						
	}
			
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