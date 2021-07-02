using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string respuesta;
            string caracter;
            string reverso ="";
            int x;
            Console.WriteLine("Escribe una palabra y yo te diré si es palíndromo ");
            respuesta = Convert.ToString(Console.ReadLine());
            x = respuesta.Length;
            for (int i = x-1; i >= 0; i--)
            {
                caracter = respuesta.Substring(i, 1);
                reverso = reverso + caracter;

            }   
            if (reverso == respuesta)

                {
                    Console.WriteLine("La palabra " + respuesta + " es palíndromo ");
                }
            else
            {
                Console.WriteLine("La palabra " + respuesta + " NO es palíndromo ");
            }
                
        }
    }
}
