/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/9/2024
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of FabricaDeAlumno.
	/// </summary>
	public class FabricaDeAlumno : Fabrica
    {
		public override Comparable crearAleatorio()
        {
        	Random random = new Random();
        	string nombreAleatorio = GeneradorDeDatosAleatorios.stringAleatorio(4);
            int dniAleatorio = GeneradorDeDatosAleatorios.numeroAleatorio(5);
            int legajoAleatorio = GeneradorDeDatosAleatorios.numeroAleatorio(999);
            double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

            return new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
        }

        public override Comparable crearPorTeclado(int a)
        {

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el DNI del alumno (8 dígitos): ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el legajo del alumno (4 dígitos): ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el promedio del alumno (0.0 a 10.0): ");
            double promedio = double.Parse(Console.ReadLine());

            return new Alumno(nombre, dni, legajo, promedio);
            
        }
    }
}