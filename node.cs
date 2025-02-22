using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node
    {
        public object data; // Dato que guarda el nodo
        public Node next; // Direccion de memoria del nodo siguiente
        
        // Constructores de los nodos
        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }
        
        public Node(object data)
        {
            this.data = data;
            next = null;
        }
        
        public Node()
        {
            data = null;
            next = null;
        }
    }
}
