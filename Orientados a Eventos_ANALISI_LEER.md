#Analisis de comportamintos de los programas orientados a eventos 
1. Comportamiento Observado: Al presionar el botón, el sistema ejecuta ambos métodos en cadena. El botón no contiene la lógica de inventario, solo notifica que la venta ocurrió.
2. Comportamiento Observado de los ejericicios 2 y 3: Mientras la temperatura es baja, solo cambian los números. Al cruzar el umbral de 35°C, se "dispara" un nuevo comportamiento (color rojo y mensajes de alerta), demostrando una reacción condicional a un suceso.
3. Comportamiento Observado: El módulo de pagos es independiente; si se desconecta el suscriptor de "Notificar", el pago sigue funcionando, lo que prueba la flexibilidad del diseño orientado a eventos
4. Comportamiento Observado: El sistema reacciona creando una secuencia de pasos lógicos (reservar -> procesar) de forma automática tras el suceso inicial, manteniendo el orden jerárquico de la operación.

