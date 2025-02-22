# Implementación de Cola (Queue) en C#

## Descripción
Este proyecto implementa una estructura de datos de cola (queue) en C#, la cual sigue el principio FIFO (First In, First Out). Permite operaciones como agregar elementos, atender (eliminar) elementos y visualizar la cola.

## Estructura del Proyecto

- **Node.cs**: Define la clase `Node`, que representa un nodo en la cola.
- **Queue.cs**: Implementa la clase `Queue`, que maneja la estructura de la cola y sus operaciones.
- **Menu.cs**: Contiene la lógica de interacción con el usuario, permitiendo la manipulación de la cola.
- **Program.cs**: Punto de entrada principal del programa.

## Implementación

### Node.cs
Cada nodo contiene:
- Un valor (`data`).
- Un puntero al siguiente nodo (`next`).

### Queue.cs
La clase `Queue` maneja la estructura de la cola e implementa los siguientes métodos:

- `Enqueue(object data)`: Agrega un nodo al final de la cola.
- `Dequeue()`: Elimina el primer nodo de la cola y devuelve su valor.
- `Peek()`: Devuelve el primer elemento de la cola sin eliminarlo.
- `Rear()`: Devuelve el último elemento de la cola sin eliminarlo.
- `Size()`: Retorna el tamaño actual de la cola.
- `Print()`: Imprime los elementos de la cola en orden.
- `IsEmpty()`: Verifica si la cola está vacía.

### Menu.cs
Este archivo proporciona una interfaz de consola para interactuar con la cola. Permite al usuario:

- Agregar clientes a la cola.
- Atender al cliente actual (eliminar el primero en la cola).
- Mostrar el estado actual de la cola.

### Program.cs
Archivo principal que ejecuta el programa e inicia la interacción con el usuario.

## Ejemplo de Uso

Al ejecutar el programa, se mostrará el siguiente flujo:

```
Sistema De Atencion De Clientes

¿Que accion desea realizar?
1. Agregar Un Cliente A La Cola
2. Atender Al Cliente Actual
3. Mostrar El Estado Actual De La Cola
4. Salir Del Programa
> 1

Introduzca el nombre del cliente
> Juan

Lista De Clientes
Juan

¿Que accion desea realizar?
> 1
Introduzca el nombre del cliente
> Maria

Lista De Clientes
Juan
Maria

¿Que accion desea realizar?
> 2
Se atendio al cliente Juan

Lista De Clientes
Maria

¿Que accion desea realizar?
> 3
Lista De Clientes
Maria
Primero en la fila: Maria
Ultimo en la fila: Maria

¿Que accion desea realizar?
> 4
Gracias Por Usar El Programa!
```

