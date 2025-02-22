using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace Program
{
    class Menu
    {
        Queue queue;
        object data;
        int option;
        
        public Menu(){}
        
        public void Show()
        {
            Console.WriteLine("Sistema De Atencion De Clientes\n");
            this.queue = new Queue();
            
            do
            {
                Operations(ref option);
                if(option == 4) { return; }
            }while(true);
        }
        
        public void Operations(ref int option)
        {
            Thread.Sleep(500);
            Console.WriteLine("¿Que accion desea realizar?");
            Console.Write("1. Agregar Un Cliente A La Cola              ");
            Console.WriteLine("2. Atender Al Cliente Actual");
            Console.Write("3. Mostrar El Estado Actual De La Cola       ");
            Console.WriteLine("4. Salir Del Programa");
            
            option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                    // Agregar un cliente a la cola
                    Console.Write("Introduzca el nombre del cliente: ");
                    data = Console.ReadLine();
                    queue.Enqueue(data);
                    Console.WriteLine("\nLista De Clientes\n");
                    queue.Print();
                    break;
                case 2:
                    // Atender al cliente actual (eliminarlo de la cola)
                    if(queue.IsEmpty()) 
                    {
                        Console.WriteLine("\nLa fila esta vacia\n"); 
                        return;
                    }
                    
                    Console.WriteLine("\nSe atendio al cliente " + queue.head.data + "\n");
                    queue.Dequeue();
                    Console.WriteLine("\nLista De Clientes\n");
                    queue.Print();
                    break;
                case 3:
                    
                    Console.WriteLine("Lista De Clientes\n");
                    queue.Print(); 
                    Console.WriteLine("Primero en la fila: " + queue.Peek() + "\n");
                    Console.WriteLine("Ultimo en la fila: " + queue.Rear() + "\n");
                    break;
                case 4:
                    // Salir del programa
                    Console.WriteLine("Gracias Por Usar El Programa!");
                    break;
                default:
                    // Validación de entrada incorrecta
                    Console.WriteLine("Introduzca una opcion entre 1 y 4");
                    break;
            }
        }
    }
}