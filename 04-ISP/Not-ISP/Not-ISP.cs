using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ISP.Not_ISP
{
    // La interfaz Bird obliga a todas las clases que la implementan a definir métodos 
    // que no necesariamente son relevantes o posibles para todos los tipos de aves.
    // Esto viola el principio de segregación de interfaz (ISP) que sugiere que las 
    // interfaces deben ser específicas en lugar de generales, y que las clases no deben 
    // ser forzadas a implementar interfaces que no utilizan en su totalidad.
    public interface Bird
    {
        void Fly();
        void Eat();
        void Run();
        void Swim();
    }

    // Clase Tucan es forzada a implementar el método Swim, el cual no es relevante para un tucán.
    // Esto resulta en la necesidad de lanzar una NotImplementedException, indicando un diseño inadecuado.
    public class Tucan : Bird
    {
        public void Fly() => Console.WriteLine("Fly");
        public void Eat() => Console.WriteLine("Eat");
        public void Run() => Console.WriteLine("Run");
        public void Swim() => throw new NotImplementedException("Tucans cannot swim.");
    }

    // Clase Hummingbird también es forzada a implementar Run y Swim, que no son capacidades típicas de los colibríes.
    public class Hummingbird : Bird
    {
        public void Fly() => Console.WriteLine("Fly");
        public void Eat() => Console.WriteLine("Eat");
        public void Run() => throw new NotImplementedException("Hummingbirds do not run.");
        public void Swim() => throw new NotImplementedException("Hummingbirds cannot swim.");
    }

    // Clase Ostrich no puede volar, pero debe implementar Fly. También muestra cómo Ostrich es capaz de nadar,
    // un comportamiento no común en todas las aves, que justifica una interfaz separada.
    public class Ostrich : Bird
    {
        public void Fly() => throw new NotImplementedException("Ostriches cannot fly.");
        public void Eat() => Console.WriteLine("Eat");
        public void Run() => Console.WriteLine("Run");
        public void Swim() => Console.WriteLine("Swim");
    }

    // Clase Penguin es otro ejemplo de cómo la necesidad de implementar Fly es irrelevante,
    // y cómo la interfaz general puede llevar a implementaciones inadecuadas.
    public class Penguin : Bird
    {
        public void Fly() => throw new NotImplementedException("Penguins cannot fly.");
        public void Eat() => Console.WriteLine("Eat");
        public void Run() => Console.WriteLine("Run");
        public void Swim() => Console.WriteLine("Swim");
    }

}
