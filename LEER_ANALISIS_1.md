# Paradigma-Logico
Análisis y Explicación

Ejercicio 1: Mayoría de Edad
Hecho: La edad ingresada por el usuario (ej. 19 años).
Regla: Si edad >= 18 -> Puede Votar.
Comportamiento Observado: El sistema actúa como un filtro binario. Si el hecho cumple con la restricción de la regla, el resultado es verdadero. Es la forma más básica de inferencia lógica.

Ejercicio 2: Inferencia de Crédito
Hechos: Poseer empleo (Booleano) y el nivel de ingresos (Numérico).
Regla: Si (Empleo == True) Y (Ingresos > Mínimo) -> Crédito Aprobado.
Comportamiento Observado: Aquí aplicamos una conjunción lógica (Operador AND). La inferencia falla si cualquiera de los dos hechos es falso, demostrando cómo un sistema experto valida múltiples premisas antes de emitir una conclusión

Ejercicios 3 y 4: Reglas Dinámicas y Reutilización
Hechos: Estado del clima (Lluvia) y posesión de un objeto (Paraguas).
Regla: Si (NO Llueve) O (Tiene Paraguas) -> Puede Salir.
Comportamiento Observado: Se utiliza una disyunción lógica (Operador OR). El comportamiento cambia dinámicamente; por ejemplo, aunque el hecho "Lluvia" sea verdadero, el hecho "Paraguas" puede validar la salida. Al ser una función reutilizable, esta lógica puede ser llamada por otros módulos sin necesidad de ser redefinida

Ejercicio 5: Sistema Experto (Fiebre)
Hecho: Temperatura corporal.
Regla (Base de Conocimiento): * Temp > 37.5 -> Fiebre.
35.0 <= Temp <= 37.5 -> Normal.
Comportamiento Observado: El sistema simula el razonamiento de un experto médico. A diferencia de un simple "Sí/No", este comportamiento permite categorizar el hecho dentro de rangos predefinidos para dar un diagnóstico específico basado en reglas preestablecidas.
