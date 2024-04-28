using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ISP.Applying_ISP
{
    // Interfaz IFlyer: Define la capacidad de volar.
    public interface IFlyer
    {
        void Fly();
    }

    // Interfaz IEater: Define la capacidad de comer.
    public interface IEater
    {
        void Eat();
    }

    // Interfaz IRunner: Define la capacidad de correr.
    public interface IRunner
    {
        void Run();
    }

    // Interfaz ISwimmer: Define la capacidad de nadar.
    public interface ISwimmer
    {
        void Swim();
    }

    // Clase Toucan implementa las capacidades de volar, comer y correr.
    public class Toucan : IFlyer, IEater, IRunner
    {
        public void Fly() => Console.WriteLine("Fly");
        public void Eat() => Console.WriteLine("Eat");
        public void Run() => Console.WriteLine("Run");
    }

    // Clase Hummingbird implementa las capacidades de volar y comer.
    public class Hummingbird : IFlyer, IEater
    {
        public void Fly() => Console.WriteLine("Fly");
        public void Eat() => Console.WriteLine("Eat");
    }

    // Clase Ostrich implementa las capacidades de comer, correr y nadar.
    public class Ostrich : IEater, IRunner, ISwimmer
    {
        public void Eat() => Console.WriteLine("Eat");
        public void Run() => Console.WriteLine("Run");
        public void Swim() => Console.WriteLine("Swim");
    }

    // Clase Penguin implementa las capacidades de comer, correr y nadar.
    public class Penguin : IEater, IRunner, ISwimmer
    {
        public void Eat() => Console.WriteLine("Eat");
        public void Run() => Console.WriteLine("Run");
        public void Swim() => Console.WriteLine("Swim");
    }
}
