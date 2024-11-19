/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 11/11/2024
 * Time: 20:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using practica1;

namespace practica1
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>

		public class FabricaDeProfesor : Fabrica
    {
			
		public FabricaDeProfesor() {}
		
        public override Comparable crearAleatorio()
        {
            Random random = new Random();
            string nombreAleatorio = GeneradorDeDatosAleatorios.stringAleatorio(4);
            int dniAleatorio = random.Next(10000000, 99999999);
            int antiguedad = random.Next(0, 35);
           // List<IObservador> lista = new List<IObservador>();

            return new Profesor(nombreAleatorio, dniAleatorio, antiguedad);
        }

        public  override Comparable crearPorTeclado(int a)
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el DNI del alumno (8 dígitos): ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese una antiguedad: ");
            int antiguedad = int.Parse(Console.ReadLine());

            return new Profesor(nombre, dni, antiguedad);
        }
    }
}