using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private string _RegistrationNumber;
        private static int _carCount = 0;
        private double consump;
        private double cost;

        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int DoorCount { get { return _doorCount; } set { _doorCount = value;} }
        public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value;} }
        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }
        public string RegistrationNumber { get { return _RegistrationNumber; } set { _RegistrationNumber = value; } }

        public Car()
        {
            _brand = "nieznany";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0;
            AvgConsump = 0.0;
            _carCount++;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string RegistrationNumber)
        {
           _brand =brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _RegistrationNumber = RegistrationNumber;
            _carCount++;
        }
        public double CalculateConsump(double roadLength)
        {
            return consump = (AvgConsump * roadLength) / 100;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            return cost = consump * petrolCost;
        }


        public override string ToString()
        {
            return $" Car | Brand: {_brand}, Model: {_model}, DoorCount: {_doorCount}, EngineVolume: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: {_RegistrationNumber}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }
    }
}
