using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue;

namespace Queue
{
    // Clase que implementa una estructura de datos tipo Cola (Queue)
    class queue
    {
        public node head; // Nodo que representa el frente de la cola
        public node tail; // Nodo que representa el final de la cola
        private int length; // Número de elementos en la cola
        
        // Constructor que inicializa una cola vacía
        public queue()
        {
            head = tail = null;
            length = 0;
        }
        
        // Método que muestra la cantidad de elementos en la cola
        public void size()
        {
            Console.WriteLine(length + "\n");
            return;
        }
        
        // Método que imprime el estado actual de la cola
        public void show()
        {
            node current = head;
            Console.WriteLine("\nEstado actual de la cola \n");
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(current.data); // Imprime cada elemento de la cola
                current = current.next; // Avanza al siguiente nodo
            }
            Console.WriteLine("\n");
        }
        
        // Método que agrega un elemento al final de la cola
        public void enqueue(object data)
        {
            if(length == 0){ head = tail = new node(data); } // Si la cola está vacía, el nuevo nodo es tanto head como tail
            else{ tail = tail.next = new node(data); } // Si no está vacía, se agrega un nuevo nodo al final
            length++; // Aumenta el tamaño de la cola
            show(); // Muestra el estado actual de la cola
        }
        
        // Método que elimina el primer elemento de la cola y lo devuelve
        public object dequeue()
        {
            node deletedElement = head; // Guarda el nodo eliminado
            if(length == 0){ Console.WriteLine("La cola no tiene ningún elemento"); } // Si la cola está vacía, muestra un mensaje
            else if (head == tail) // Si hay solo un elemento, la cola se vacía completamente
            {
                head = tail = null;
                Console.WriteLine("La cola está vacía");
            }
            else { head = head.next; } // Avanza el head al siguiente nodo
            length--; // Reduce el tamaño de la cola
            show(); // Muestra el estado actual de la cola
            return deletedElement; // Devuelve el nodo eliminado
        }
        
        // Método que muestra el primer elemento de la cola sin eliminarlo
        public void peek()
        {
            if(length == 0){ Console.WriteLine("La cola no tiene ningún elemento"); }
            else { Console.WriteLine("El primero en la fila es: " + head.data + "\n"); }
        }
        
        // Método que muestra el último elemento de la cola sin eliminarlo
        public void rear()
        {
            if(length == 0){ Console.WriteLine("La cola no tiene ningún elemento"); }
            else { Console.WriteLine("El último en la fila es: " + tail.data + "\n"); }
        }
    }
}