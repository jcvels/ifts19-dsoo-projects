# Proyectos de Desarrollo de Software Orientado a Objetos

## Semana #1

### Ejercicio #1
El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio, por lo tanto, el algoritmo debe calcular el precio final a abonar por un cliente. Se ingresa el precio del producto y como resultado muestra el precio de venta.

[ver código](./week1/exercise1/)

### Ejercicio #2
En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos. El algoritmo pide el nombre de cada participante y la puntuación de los 3 jurados. Debe mostrar el nombre y el puntaje total de cada participante.
> Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa.

[ver código](./week1/exercise2/)

### Ejercicio #3
Modifica la salida de la resolución del punto 2. Se pide mostrar un mensaje que indique si cada participante llegó a la última etapa o no.

[ver código](./week1/exercise3/)

### Ejercicio #4
Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos. Por ejemplo, la suma de los dígitos del 3433 es 13.  Para darle un poco más de emoción, el programa no se limitará a escribir el resultado de la suma, sino que también escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.

[ver código](./week1/exercise4/)

### Ejercicio #5
Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos, es decir, puede ser un número de dos dígitos como un número de 6 dígitos. Tomá la codificación anterior e introducí los cambios que sean necesarios.

[ver código](./week1/exercise5/)

### Ejercicio #6
Tres personas aportan diferente capital a una sociedad y desean saber el valor total aportado y qué porcentaje aportó cada una (indicando nombre y porcentaje). Para ello, solicitar la carga por teclado del nombre de cada socio, su capital aportado y a partir de esto calcular e informar lo requerido previamente .

[ver código](./week1/exercise6/)

## Semana #2

### Super Heroes
En una galaxia lejana habitan muchos superhéroes con habilidades extraordinarias, estos han decidido realizar una competencia entre ellos comparando sus distintos atributos. Para ello, necesitamos crear la clase "SuperHeroe" que nos permita representar a estos poderosos personajes con los atributos nombre (String), fuerza (int), resistencia (int) y superpoderes (int).

Todos los atributos numéricos deberán aceptar valores entre 0 y 100; en caso que el setter correspondiente reciba un valor fuera de rango deberá setear el valor límite  correspondiente (si recibe un valor negativo asignar cero, si recibe uno superior a cien, asignar cien).

El constructor de la clase recibirá todos los valores de sus atributos por parámetro y usará los setters (todos privados) para validar el rango correcto de los poderes del superhéroe.
Se deberá crear un método competir() el cual recibirá otro superhéroe como parámetro y, comparando los  poderes de él mismo contra el otro recibido por  parámetro, devolverá TRIUNFO, EMPATE o  DERROTA, dependiendo del resultado. 

Para triunfar un superhéroe debe superar al otro en al menos 2 de los 3 ítems.

[ver código](./week2/Superheroes)

### Primer Proyecto en entorno visual
Teniendo en cuenta la tabla que se detalla a continuación, construí la primera Solución en el entorno visual. El nombre de la Solución es PrimerProyecto.

| Control    | Prefijo| Propiedad     | Valor                    |
|------------|--------|---------------|--------------------------|
| Formulario | frm    | Name          | frmPrincipal             |
|  |     | Text          | PRIMER PROYECTO          |
|  |     | StartPosition | CenterScreen             |
|  |     | BackColor     | 192; 255; 192 (verde claro) |
| Label1     | lbl    | Name          | lblNombre                |
|      |     | Text          | Nombre                   |
| Label2     | lbl    | Name          | lblApellido              |
|      |     | Text          | Apellido                 |
| Label3     | lbl    | Name          | lblDocumento             |
|      |     | Text          | Documento                |
| TextBox1   | txt    | Name          | txtNombre                |
|    |     | Text          | vacío                    |
| TextBox2   | txt    | Name          | txtApellido              |
|    |     | Text          | vacío                    |
| TextBox3   | txt    | Name          | txtDocumento             |
|    |     | Text          | vacío                    |
| Button1    | btn    | Name          | btnIngresar              |
|     |     | Text          | INGRESAR                 |
| Button2    | btn    | Name          | btnLimpiar               |
|     |     | Text          | LIMPIAR                  |

[ver código](./week2/PrimerProyecto)

### Ingreso de datos
Ingresar los datos desde los textBox y mostrarlos en cuadro de dialogo. Usar el botón “Aceptar”.
Tomar el ejercicio 1, pero los datos deben ser ingresados también en un cuadro de diálogo.

Usando el botón “Cálculo” solicitar con un cuadro de diálogo el ingreso de dos números (es un cuadro de dialogo para cada dato) y mostrar cuál es el número más grande.  La forma de declaración, lectura de datos numéricos y uso de condicional lo viste en la semana 1 y lo ejercitaste desde el modo consola. Simplemente debes adaptarlo a este nuevo modo.

[ver código](./week2/IngresoDatos)
