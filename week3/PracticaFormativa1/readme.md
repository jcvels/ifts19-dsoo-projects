# Practica Formativa #1
En un pequeño departamento en la ciudad, Facundo y Camila son compañeros de piso y comparten un televisor. Ambos son amantes de las películas y programas de televisión, y disfrutan relajarse juntos después de un largo día de trabajo. Para facilitar su entretenimiento, han decidido crear un programa simple en C# para administrar su televisor y controlar los canales que ven.

Un televisor cuenta con varios atributos como ser:
- Marca (del tipo string)
- Modelo (del tipo string)
- Cantidad de pulgadas (del tipo entero)
- Estado (prendido o apagado) (del tipo booleano)
- Número del canal que se está reproduciendo actualmente. (valor desde 1 a 150) (del tipo entero)


De la persona dueña del televisor se sabe:
- nombre (del tipo string)
- domicilio

Del domicilio conocemos:
- calle
- número
- barrio

## Hacer:
Con el objetivo de programar una experiencia de visualización óptima, se han definido una serie de operaciones que se pueden realizar en el televisor. Estas operaciones incluyen:
- `obtenerCanalActual(): int` Devuelve un valor entero con el número de canal que esta visualizándose en ese momento.
- `cambiarCanal(int): bool` Cambia el canal al número de canal que reciba por parámetro
- `cambiarCanal(): bool` Cambia el canal incrementando en uno al que se está reproduciendo actualmente. Si llega al tope de 150, debe comenzar por el primero.
- `verPrendido():bool` Informa con un verdadero si el televisor está encendido o falso en caso contrario.
- `cambiarEstado():void` Si el televisor se encontraba encendido entonces se debe apagar, y viceversa.

## Se pide:
- [X] Modelar la soluciȯn en UML
- [X] Realizar la implementación de cada método en c#. 
- [X] Realizar los constructores de las siguientes clases:
	- [X] Persona.
	- [X] Televisor.
	- [X] Domicilio.
- [ ] El método Main de la clase Test que instancie lo siguiente y luego lo muestre:
	- Un televisor que le pertenece a Facundo y a Camila
	- Ambos viven juntos en Jonte 5299, Monte Castro
	- Que tanto Facundo como Camila, en distintos momentos, puedan realizar diferentes operaciones sobre mismo televisor (tener siempre en cuenta el estado del televisor por ejemplo, no se puede cambiar de canal si se encuentra apagado).
