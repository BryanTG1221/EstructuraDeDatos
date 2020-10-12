# Como hacer una lista Doble by __Bryan Turrubiates__:

## Estructura a Seguir
* Clase Verde (Clase de Lista Personalizada)
* Clase Azul (Clase respectiva al Nodo)
* Clase Roja (Clase respectiva al Objeto)

# Que debe contener la Clase VERDE? (Lista Personalizada)

* Contructor que inicialice los Nodos a "null"
* Atributo y Propiedad de Nodo Inicial, parametrizado a "Tipo"
* Atributo y Propiedad de Nodo Final, parametrizado a "Tipo"
* Atributo y Propiedad del Nodo Previo parametrizado a "Tipo"
* Propiedad para detectar si la Lista esta vacia
* Metodo de Agregar Nodo
* Metodo de Eliminar Nodo
* Metodo para Buscar Nodo
* Metodo para Vaciar
* Propiedad para ir Hacia Adelante de tipo "IEnumerable"
* Propuedad para ir Hacia Atras de tipo "IEnumerable"
* Destructor 

# Importante:
Agregar una herencia de la interface: __IEquatable__
# __Que debe contener la clase AZUL? (Nodo)__

* Atributo y Propiedad respectiva de __ObjetoConDatos__
* Atributo y Propiedad respectiva del apuntador __Siguiente__
* Atributo y Propiedad respectiva del apuntador __Anterior__

# Como Hacer el metodo __Agregar Nodo__ en una lista desordenada?

## __Hay que tener en cuenta lo siguiente:__

* **Verificar si la Lista esta Vacia**

Si la lista esta vacia haremos una __Alta al Principio__.

1- Creamos un nodo __AZUL__ llamado __nodoNuevo__.

2- Insertamos el objeto __ROJO__ en el __nodoNuevo__.

3- El __nodoNuevo__ apuntara a __null__ en la propiedad __"Siguiente"__ y __"Anterior"__.

4- El __nodoInicial__ y el __nodoFinal__ seran el __nodoNuevo__.

## __Si la lista NO esta Vacia se hara lo siguente:__

* __Se implementara una Alta Al Final__

### __Verificar si el dato no esta duplicado si se desea.__
Esto se logra mediante el metodo __Equals__ el cual codificaremos a nuestras necesidades.

Ya que se logro verificar que no esta duplicado el __Objeto__ se debera hacer lo siguiente:

* Creamos un nodo llamado __nodoActual__.
* Insertamos el __Objeto__ en el __nodoActual__.
* El __nodoPrevio.Siguiente__ apuntara a __nodoActual__
* El __nodoActual.Siguiente__ apuntara a __null__
* El __nodoFinal__ apuntara a el __nodoNuevo__






