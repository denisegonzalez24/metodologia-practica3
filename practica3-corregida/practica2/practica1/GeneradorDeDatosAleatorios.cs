/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 11/11/2024
 * Time: 20:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace practica1
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>


    public class GeneradorDeDatosAleatorios
    {
        
        public GeneradorDeDatosAleatorios()
        {
        }

        
        public static int numeroAleatorio(int max)
        {
            return new Random().Next(0, max);
        }

        
        public static string stringAleatorio(int cant)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder resultado = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < cant; i++)
            {
                int index = random.Next(caracteres.Length);
                resultado.Append(caracteres[index]);
            }

            return resultado.ToString();
        }
    }
}
