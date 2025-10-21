## Caso de Estudio 1: Pilas – Control de Operaciones en un Sistema de Versionado
En un entorno de desarrollo colaborativo, los programadores de una empresa utilizan un
sistema de control de versiones para gestionar los cambios en el código fuente. Cada
vez que un desarrollador realiza una modificación, esta se registra como una “acción”
en una pila, lo que permite aplicar la lógica LIFO (Last In, First Out). El sistema debe
permitir agregar nuevas acciones, visualizar la última modificación y deshacer el último
cambio (simulando la función Undo).
El caso plantea la necesidad de modelar esta funcionalidad en C#, utilizando una pila
para registrar acciones como “Agregar función”, “Eliminar clase” o “Modificar variable”.
Al desapilar, se elimina la acción más reciente, reflejando el comportamiento de revertir
el último cambio. Este caso permite a los estudiantes comprender cómo las pilas se
aplican en sistemas de control de versiones, editores de texto o entornos de
programación integrados (IDE), donde la secuencia de operaciones recientes se
gestiona mediante estructuras dinámicas.
