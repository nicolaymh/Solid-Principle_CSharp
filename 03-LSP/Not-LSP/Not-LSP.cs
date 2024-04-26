using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LSP.Not_LSP
{
    public class Tesla
    {
        private int _numberOfSeats;

        public Tesla(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }


    public class Audi
    {
        private int _numberOfSeats;

        public Audi(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }


    public class Toyota
    {
        private int _numberOfSeats;

        public Toyota(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }


    public class Honda
    {
        private int _numberOfSeats;

        public Honda(int numberOfSeats) => _numberOfSeats = numberOfSeats;

        public int GetNumberOfSeats() => _numberOfSeats;
    }
}
