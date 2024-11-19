/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 11/11/2024
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica1
{
	/// <summary>
	/// Description of IObservador.
	/// </summary>
	public interface IObservador
    {
        void Actualizar(IObservado observado);
    }
}