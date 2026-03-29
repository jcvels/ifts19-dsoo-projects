# Proyectos de Desarrollo de Software Orientado a Objetos

## Semana #1
- [Ejercicio 1](./week1/exercise1/Program.cs)
- [Ejercicio 2](./week1/exercise2/Program.cs)
- [Ejercicio 3](./week1/exercise3/Program.cs)
- [Ejercicio 4](./week1/exercise4/Program.cs)
- [Ejercicio 5](./week1/exercise5/Program.cs)
- [Ejercicio 6](./week1/exercise6/Program.cs)

## Semana #2
### Super Heroes
En una galaxia lejana habitan muchos superhéroes con habilidades extraordinarias, estos han decidido realizar una competencia entre ellos comparando sus distintos atributos. Para ello, necesitamos crear la clase "SuperHeroe" que nos permita representar a estos poderosos personajes con los atributos nombre (String), fuerza (int), resistencia (int) y
superpoderes (int).
Todos los atributos numéricos deberán aceptar valores entre 0 y 100; en caso que el setter correspondiente reciba un valor fuera de rango deberá setear el valor límite  correspondiente (si recibe un valor negativo asignar cero, si recibe uno superior a cien, asignar cien).
El constructor de la clase recibirá todos los valores de sus atributos por parámetro y usará los setters (todos privados) para validar el rango correcto de los poderes del superhéroe.
Se deberá crear un método competir() el cual recibirá otro superhéroe como parámetro y, comparando los  poderes de él mismo contra el otro recibido por  parámetro, devolverá TRIUNFO, EMPATE o  DERROTA, dependiendo del resultado. 
Para triunfar un superhéroe debe superar al otro en al menos 2 de los 3 ítems.
- [Solucion](./week2/Superheroes)