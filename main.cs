using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue;

class Program
{
    // Método que pregunta al usuario si desea realizar otra operación
    static bool Exit()
    {
        int opt;
        do
        {
            Console.WriteLine("¿Desea realizar otra operacion?\n1.Si 2.No\n");
            opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1){ return true;}  // Si elige 1, el programa continúa
            else if (opt == 2){ return false; } // Si elige 2, el programa termina
            else{ Console.WriteLine("Introduzca una opción correcta"); } // Mensaje de error en caso de opción inválida
        }while(opt != 1 && opt != 2);
        return true;
    }
    
    // Método para mostrar el menú de opciones al usuario
    static void Menu(ref short option)
    {
        Console.WriteLine("Sistema De Atencion De Clientes\n");
        Console.WriteLine("¿Que accion desea realizar?");
        Console.WriteLine("1. Agregar Un Cliente A La Cola");
        Console.WriteLine("2. Atender Al Cliente Actual");
        Console.WriteLine("3. Mostrar El Estado Actual De La Cola");
        Console.WriteLine("4. Salir Del Programa");
    
        // Captura la opción ingresada por el usuario
        option = Convert.ToInt16(Console.ReadLine());
    }
    
    // Método para ejecutar las operaciones según la opción elegida
    static void Operations(queue fila, short option)
    {
        string name;
        switch(option)
        {
            case 1:
                // Agregar un cliente a la cola
                Console.WriteLine("Introduzca el nombre del cliente: ");
                name = Console.ReadLine();
                fila.enqueue(name);
                break;
            case 2:
                // Atender al cliente actual (eliminarlo de la cola)
                Console.WriteLine("Se atendio al cliente " + fila.head.data);
                fila.dequeue();
                break;
            case 3:
                // Mostrar el estado actual de la cola
                fila.show();  // Muestra todos los elementos de la cola
                fila.peek();  // Muestra el cliente que está al frente
                fila.rear();  // Muestra el cliente que está al final
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
    
    // Método principal que ejecuta el programa
    static void Main()
    {
        short option = 0;
        queue fila = new queue(); // Se crea una cola de clientes
    
        do
        {
            // Muestra el menú y obtiene la opción del usuario
            Menu(ref option);
    
            // Ejecuta la operación correspondiente
            Operations(fila, option);
    
            // Si el usuario elige salir, termina el programa
            if (option == 4) { return; }
        } 
        while (Exit() || (option > 0 && option < 4)); // Continúa mientras el usuario no elija salir
    }
}
