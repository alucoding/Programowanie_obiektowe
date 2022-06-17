using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01
{
    public class Garage
    {
        private string _address;
        private int _carsCount;
        private int _capacity;
        private Car[] _cars;

        public string Address { get { return _address; } set { _address = value; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; _cars = new Car[value]; } }


        public Garage()
        {
            _address = "nieznany";
            _carsCount = 0;
            _capacity = 0;
            _cars = null;
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            _carsCount = capacity;
        }
    }
}
