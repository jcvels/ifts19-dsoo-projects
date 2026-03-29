# Practica Formativa #1
En un peque�o departamento en la ciudad, Facundo y Camila son compa�eros de piso y comparten un televisor. Ambos son amantes de las pel�culas y programas de televisi�n, y disfrutan relajarse juntos despu�s de un largo d�a de trabajo. Para facilitar su entretenimiento, han decidido crear un programa simple en C# para administrar su televisor y controlar los canales que ven.

Un televisor cuenta con varios atributos como ser:
- Marca (del tipo string)
- Modelo (del tipo string)
- Cantidad de pulgadas (del tipo entero)
- Estado (prendido o apagado) (del tipo booleano)
- N�mero del canal que se est� reproduciendo actualmente. (valor desde 1 a 150) (del tipo entero)


De la persona due�a del televisor se sabe:
- nombre (del tipo string)
- domicilio

Del domicilio conocemos:
- calle
- numero
- barrio

## Hacer:
Con el objetivo de programar una experiencia de visualizaci�n �ptima, se han definido una serie de operaciones que se pueden realizar en el televisor. Estas operaciones incluyen:
- `obtenerCanalActual(): int` Devuelve un valor entero con el n�mero de canal que esta visualiz�ndose en ese momento.
- `cambiarCanal(int): bool` Cambia el canal al n�mero de canal que reciba por par�metro
- `cambiarCanal(): bool` Cambia el canal incrementando en uno al que se est� reproduciendo actualmente. Si llega al tope de 150, debe comenzar por el primero.
- `verPrendido():bool` Informa con un verdadero si el televisor est� encendido o falso en caso contrario.
- `cambiarEstado():void` Si el televisor se encontraba encendido entonces se debe apagar, y viceversa.

## Se pide:
- Model� la soluci�n en UML
- Realiz� la implementaci�n de cada m�todo en c#. 
- Tambi�n realiz� los constructores de las siguientes clases:
	- Persona.
	- Televisor.
	- Domicilio.
- El m�todo Main de la clase Test que instancie lo siguiente y luego lo muestre:
	- Un televisor que le pertenece a Facundo y a Camila
	- Ambos viven juntos en Jonte 5299, Monte Castro
	- Que tanto Facundo como Camila, en distintos momentos, puedan realizar diferentes operaciones sobre mismo televisor (tener siempre en cuenta el estado del televisor por ejemplo, no se puede cambiar de canal si se encuentra apagado).
