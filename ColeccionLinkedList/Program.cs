using System;
using System.Collections.Generic;

namespace ColeccionLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ejemplo1();
        }

        public static void ejemplo1()
        {
            LinkedList<int> numeros = new LinkedList<int>();
            
            foreach (int item in new int[] {5,4,3,2,1,0})
            {
                numeros.AddFirst(item);
            }

            /* Forma sencilla de imprimir los valores de la colección
                          
            foreach  (int item in numeros)
            {
                Console.WriteLine(item);
            }
            
             */
            Console.WriteLine("Lista ligada original");
            imprimir(numeros);

            //Eliminar nodo por valor

            numeros.Remove(5);
            Console.WriteLine("Lista ligada despúes de eliminar un nodo");
            imprimir(numeros);

            //Crear un nodo nuevo

            LinkedListNode<int> nodoNuevo = new LinkedListNode<int>(25);
            numeros.AddFirst(nodoNuevo);
            Console.WriteLine("Lista ligada con el nuevo nodo");
            imprimir(numeros);

        }

        public static void imprimir(LinkedList<int> lista)
        {
            for (LinkedListNode<int> nodo = lista.First; nodo != null; nodo = nodo.Next)
            {
                int valor = nodo.Value;
                Console.WriteLine(valor);
            }
            Console.WriteLine();
        }
    }
}
