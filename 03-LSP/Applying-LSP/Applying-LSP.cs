using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LSP.Applying_LSP
{

    public interface IVehicle
    {
        public int GetNumberOfSeats();
    }


    public class Tesla : IVehicle
    {
        private int _numberOfSeats;

        public Tesla(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }


    public class Audi : IVehicle
    {
        private int _numberOfSeats;

        public Audi(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }


    public class Toyota : IVehicle
    {
        private int _numberOfSeats;

        public Toyota(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }


    public class Honda : IVehicle
    {
        private int _numberOfSeats;

        public Honda(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }
}
