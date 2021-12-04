# MartianRobots_minimum
.NET - Martian Robots - Minimum requirements

El problema

La superficie de Marte se puede modelar mediante una cuadrícula rectangular alrededor de la cual los robots pueden moverse de acuerdo con las instrucciones proporcionadas desde la Tierra. Debe escribir un programa que determine cada secuencia de posiciones del robot e informe la posición final del robot.

La posición de un robot consta de una coordenada de cuadrícula (un par de números enteros: coordenada x seguida de coordenada y) y una orientación (N, S, E, W para norte, sur, este y oeste). Una instrucción de robot es una cadena de letras "L", "R" y "F" que representan, respectivamente, las instrucciones:

● Izquierda: el robot gira a la izquierda 90 grados y permanece en el punto de cuadrícula actual.

● Derecha: el robot gira a la derecha 90 grados y permanece en el punto de cuadrícula actual.

● Adelante: el robot avanza un punto de la cuadrícula en la dirección de la orientación actual y mantiene la misma orientación.


La dirección Norte corresponde a la dirección desde el punto de la cuadrícula (x, y) al punto de la cuadrícula (x, y + 1).

También existe la posibilidad de que se requieran tipos de comando adicionales en el futuro y se deben tomar las medidas necesarias para ello.

Dado que la cuadrícula es rectangular y delimitada (... sí, Marte es un planeta extraño), un robot que se mueve "fuera" de un borde de la cuadrícula se pierde para siempre. Sin embargo, los robots perdidos dejan un "olor" de robot que prohíbe a los futuros robots dejar el mundo en el mismo punto de la cuadrícula.
El aroma se deja en la última posición de la cuadrícula que ocupó el robot antes de desaparecer por el borde. El robot actual simplemente ignora una instrucción para moverse "fuera" del mundo desde un punto de la cuadrícula desde el cual se ha perdido previamente un robot.

La entrada
La primera línea de entrada son las coordenadas superior derecha del mundo rectangular, se supone que las coordenadas inferiores izquierda son 0, 0.

La entrada restante consta de una secuencia de posiciones e instrucciones del robot (dos líneas por robot). Una posición consta de dos números enteros que especifican las coordenadas iniciales del robot y una orientación (N, S, E, W), todos separados por espacios en blanco en una línea.
Una instrucción de robot es una cadena de letras "L", "R" y "F" en una línea.

Cada robot se procesa secuencialmente, es decir, termina de ejecutar las instrucciones del robot antes de que el siguiente robot comience a ejecutarse.
El valor máximo para cualquier coordenada es 50.
Todas las cadenas de instrucciones tendrán menos de 100 caracteres de longitud.

La salida
Para cada posición / instrucción del robot en la entrada, la salida debe indicar la posición final de la cuadrícula y la orientación del robot. Si un robot se cae del borde de la cuadrícula, la palabra "PERDIDO" debe imprimirse después de la posición y orientación.

Entrada de muestra

5 3

1 1 E

RFRFRFRF

3 2 N

FRRFLLFFRRFLL

0 3 W

LLFFFRFLFL


Salida de muestra

1 1 E

3 3 N PERDIDO

4 2 N

