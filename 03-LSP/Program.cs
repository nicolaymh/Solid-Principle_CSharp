//Instanciando Not-LSP:
using _03_LSP.Applying_LSP;
//using _03_LSP.Not_LSP;

//List<object> vehicles = new List<object>();
//vehicles.Add(new Tesla(5));
//vehicles.Add(new Audi(4));
//vehicles.Add(new Toyota(7));
//vehicles.Add(new Honda(6));

//// Imprimir el número de asientos de cada vehículo si es necesario
//foreach (object vehicle in vehicles)
//{
//    if (vehicle is Tesla)
//        Console.WriteLine("Tesla Seats: " + ((Tesla)vehicle).GetNumberOfSeats());
//    else if (vehicle is Audi)
//        Console.WriteLine("Audi Seats: " + ((Audi)vehicle).GetNumberOfSeats());
//    else if (vehicle is Toyota)
//        Console.WriteLine("Toyota Seats: " + ((Toyota)vehicle).GetNumberOfSeats());
//    else if (vehicle is Honda)
//        Console.WriteLine("Honda Seats: " + ((Honda)vehicle).GetNumberOfSeats());
//}

/*
 * El código viola el Principio de Sustitución de Liskov (LSP) porque no permite que los objetos de las clases derivadas (Tesla, Audi, Toyota, Honda) sean utilizados de manera intercambiable a través de una interfaz común sin necesidad de verificar explícitamente sus tipos. En lugar de tratar a todos los vehículos de manera uniforme, se requiere un manejo específico para cada tipo de vehículo para acceder a su funcionalidad, lo que impide la sustitución directa y viola el LSP.
*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Instanciando Applying-LSP:
List<IVehicle> list = new List<IVehicle>();
list.Add(new Tesla(5));
list.Add(new Audi(4));
list.Add(new Toyota(7));
list.Add(new Honda(6));

foreach (var car in list)
{
    Console.WriteLine($"{car.GetType().Name} Seats: {car.GetNumberOfSeats()}");
}

/*
 * este código no viola el Principio de Sustitución de Liskov porque cada clase derivada puede ser sustituida por cualquier otra que implemente IVehicle sin que se afecte la ejecución del programa. El método GetNumberOfSeats() se comporta de manera coherente en todas las implementaciones, cumpliendo con el contrato establecido por la interfaz IVehicle. Esto facilita la escalabilidad y la mantenibilidad del código al adherirse a buenos principios de diseño orientado a objetos.
*/