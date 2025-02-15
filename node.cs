using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    // Clase que representa un nodo de una estructura de datos enlazada
    class node
    {
        public object data; // Dato almacenado en el nodo
        public node next;   // Referencia al siguiente nodo en la estructura
        
        // Constructor que inicializa el nodo con un dato y una referencia al siguiente nodo
        public node(object data, node next)
        {
            this.data = data;
            this.next = next;
        }
        
        // Constructor que inicializa el nodo con un dato y sin referencia a otro nodo
        public node(object data)
        {
            this.data = data;
            next = null;
        }
        
        // Constructor por defecto que inicializa el nodo sin datos y sin referencia a otro nodo
        public node()
        {
            data = null;
            next = null;
        }
    }
}