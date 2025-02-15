# Implementación de una Cola en C#

Este proyecto implementa una **estructura de datos tipo Cola (Queue)** en C# utilizando una **lista enlazada**. La cola sigue el principio **FIFO (First In, First Out)**, donde el primer elemento en ingresar es el primero en salir.

## Archivos del Proyecto

### 1. `node.cs`
Define la estructura del nodo que se utilizará en la cola.
- Cada nodo contiene un dato (**`data`**) y una referencia al siguiente nodo (**`next`**).

### 2. `queue.cs`
Implementa la clase `queue`, que define la estructura de la cola y sus operaciones principales.

- **Atributos:**
  - `head`: Apunta al primer elemento de la cola.
  - `tail`: Apunta al último elemento de la cola.
  - `length`: Almacena la cantidad de elementos en la cola.

- **Métodos:**
  - `enqueue(data)`: Agrega un elemento al final de la cola.
  - `dequeue()`: Elimina y devuelve el primer elemento de la cola.
  - `peek()`: Muestra el primer elemento sin eliminarlo.
  - `rear()`: Muestra el último elemento sin eliminarlo.
  - `size()`: Muestra la cantidad de elementos en la cola.
  - `show()`: Imprime todos los elementos de la cola.

### 3. `Program.cs`
Contiene el programa principal que gestiona el menú y las operaciones con la cola.

- **Funciones principales:**
  - `Menu(ref short option)`: Muestra el menú de opciones.
  - `Operations(queue fila, short option)`: Ejecuta la operación seleccionada por el usuario.
  - `Main()`: Controla el flujo del programa.

## Ejemplo de Uso

1. **Agregar un cliente a la cola:**
   ```plaintext
   Introduzca el nombre del cliente: Juan
   ```

2. **Atender al cliente actual (el primero en la cola):**
   ```plaintext
   Se ha atendido al cliente Juan.
   ```

3. **Mostrar el estado actual de la cola:**
   ```plaintext
   Estado actual de la cola:
   - Pedro
   - Maria
   ```

4. **Salir del programa:**
   ```plaintext
   Gracias por usar el programa!
   ```

## Conclusión
Esta implementación de colas es útil para gestionar procesos en orden de llegada, como la atención de clientes o la administración de tareas en un sistema. Se puede extender fácilmente para incluir operaciones adicionales según sea necesario.

