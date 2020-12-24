using System;

namespace BuilderPattern
{
    public class CarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            _car = new Car();
        }

        public CarBuilder Brand(string brand)
        {
            _car.Brand = brand;
            return this;
        }
        public CarBuilder Model(string model)
        {
            _car.Model = model;
            return this;
        }
        public CarBuilder Km(int km)
        {
            _car.Km = km;
            return this;
        }
        public CarBuilder Gear(bool gear)
        {
            _car.Gear = gear;
            return this;
        }

        public Car build()
        {
            Car result = this._car;
            Reset();
            return result;
        }
    }
}