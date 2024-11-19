/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 11/11/2024
 * Time: 20:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public double numeroPorTeclado()
		{
			double numero;
			while (true)
			{
				Console.Write("Introduce un número: ");
				string entrada = Console.ReadLine();
				if (double.TryParse(entrada, out numero))
				{
					return numero;
				}
				Console.WriteLine("Entrada no válida. Por favor, introduce un número.");
			};
		}
		
		public string StringPorTeclado()
		{
			Console.Write("Introduce un texto: ");
			return Console.ReadLine();
		}
		
        }
		
		
	
}
