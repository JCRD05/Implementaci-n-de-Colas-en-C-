using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Queue
    {
        public Node head; // Primer elemento de la queue
        public Node tail; // Ultimo elemento de la queue
        public int length; // Tamaño de la queue
        
        // Constructor de la queue 
        public Queue()
        {
            head = tail = null;
            length = 0;
        }
        
        // Metodo que imprime la queue
        public void Print()
        {
            if(IsEmpty())
            {
                Console.WriteLine("La lista esta vacia\n");
                Thread.Sleep(500);
                return;
            }
            
            Node current = head;
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine();
            Thread.Sleep(500);
        }
        
        // Metodo que agrega un elemento al final de la queue
        public void Enqueue(object data)
        {
            if(IsEmpty()) { head = tail = new Node(data); }
            else { tail = tail.next = new Node(data); }
            length++;
        }
        
        // Metodo que elimina un elemento del principio de la queue
        public object Dequeue()
        {
            Node deletedElement = head;
            if(IsEmpty()) { Console.WriteLine("La cola esta vacia"); }
            else if(length == 1)
            {
                head = tail = null;
                Console.WriteLine("La cola se vacio");
            }
            else { head = head.next; }
            length--;
            
            return deletedElement;
        }
        
        // Metodo que retorna el primer elemento de la queue
        public object Peek() 
        { 
            if(IsEmpty()) { return "Nadie";}
            return head.data; 
        }
        
        // Metodo que retorna el ultimo elemento de la queue
        public object Rear() 
        { 
            if(IsEmpty()) { return "Nadie";}
            return tail.data; 
        }
        
        // Metodo que retorna el tamaño de la queue
        public int Size() { return length; }
        
        // Metodo que checa si la queue esta vacia
        public bool IsEmpty() { return length == 0; }
    }
}
