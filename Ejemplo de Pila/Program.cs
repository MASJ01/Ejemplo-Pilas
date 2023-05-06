using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TADS pila, colas, etc.
using System.Collections;

namespace Ejemplo_de_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Stack miPila = new Stack(); //Se declara una pila
            miPila.Push("hola");// La funcion "Push" sirve para meter o apilar datos
            miPila.Push("buenos");
            miPila.Push("dias");
            miPila.Push("Hola mundo");

            for (int i = 0; i < 4; i++)
            {
                palabra = (string)miPila.Pop(); // Esta funcion "Pop" toma lo que esta hasta el ultimo, lo convierte en string, es para sacar elementos
                Console.WriteLine(palabra); 
                
            }

            Console.ReadKey();
        }
    }
}
