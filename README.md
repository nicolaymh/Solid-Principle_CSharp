# Proyecto Principios SOLID en C#

Este proyecto ilustra la implementación práctica de los cinco principios SOLID en C#, donde cada principio es ejemplificado con un caso de uso específico dentro de su propio subdirectorio.

## 📂 Estructura del Directorio

Cada principio SOLID tiene su propio directorio que contiene un ejemplo concreto que lo representa:

- `01-SRP` - Single Responsibility Principle
- `02-OCP` - Open/Closed Principle
- `03-LSP` - Liskov Substitution Principle
- `04-ISP` - Interface Segregation Principle
- `05-DIP` - Dependency Inversion Principle

## 📘 Principios SOLID

### 1. Single Responsibility Principle (SRP)
📌 *Una clase debe tener una sola razón para cambiar.*
Este principio sugiere que una clase debe ocuparse de una sola parte de la funcionalidad proporcionada por el software, y esta responsabilidad debe ser completamente encapsulada por la clase. Esto ayuda a hacer el sistema más predecible y fácil de entender, además de facilitar las pruebas y el mantenimiento del código.
- **Ejemplo:** Ver `01-SRP`

### 2. Open/Closed Principle (OCP)
🔓 *Las entidades deben estar abiertas para extensión, pero cerradas para modificación.*
Este principio promueve el diseño de módulos que nunca cambian. Cuando los requisitos del software cambian, deberías poder extender el comportamiento de estos módulos sin modificarlos. Esto se logra usando abstracciones y polimorfismo, permitiendo que los nuevos comportamientos se agreguen fácilmente.
- **Ejemplo:** Ver `02-OCP`

### 3. Liskov Substitution Principle (LSP)
🔄 *Los objetos de un programa deberían ser intercambiables con instancias de sus subtipos sin alterar el funcionamiento correcto del programa.*
Este principio define que los objetos de una superclase deberían poder ser reemplazados con objetos de sus subclases sin afectar la correcta ejecución del programa. Esto asegura que una subclase pueda asumir el lugar de su superclase sin errores o resultados incorrectos.
- **Ejemplo:** Ver `03-LSP`

### 4. Interface Segregation Principle (ISP)
🔗 *No se debe forzar a los clientes a implementar interfaces que no usan.*
ISP aboga por crear interfaces más específicas que no obliguen a las implementaciones a depender de métodos que no utilizan. Esto mejora la cohesión del código y ayuda a mantener sistemas más limpios y separados, facilitando el entendimiento y la reducción de interdependencias.
- **Ejemplo:** Ver `04-ISP`

### 5. Dependency Inversion Principle (DIP)
🔝 *Depende de abstracciones, no de concreciones.*
Este principio enfatiza la importancia de la flexibilidad del código al invertir las dependencias convencionales; los módulos de alto nivel no deben depender de módulos de bajo nivel, sino de abstracciones. DIP es fundamental para la arquitectura de software, permitiendo que los cambios en las implementaciones concretas no afecten a los módulos que las utilizan.
- **Ejemplo:** Ver `05-DIP`

## 🚀 Cómo Contribuir

Si deseas contribuir al proyecto:
1. Haz un fork del repositorio.
2. Crea una nueva rama para tus cambios.
3. Añade tus modificaciones.
4. Envía un pull request.

## 📄 Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo `LICENSE` para obtener más detalles.

---