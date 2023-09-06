using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // Concrete builder triển khai chi tiết các bước
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new();

        public CarBuilder()
        {
            Reset();
        }

        public Car GetResult()
        {
            return _car;
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetModel(string model)
        {
            _car.Model = model;
        }

        public void SetSeats(int seats)
        {
            _car.NumberOfSeat = seats;
        }

        public void SetTurbo()
        {
            throw new NotImplementedException();
        }
    }

    public class SuperCarBuilder : ICarBuilder
    {
        private Car _car = new();

        public SuperCarBuilder()
        {
            Reset();
        }

        public Car GetResult()
        {
            return _car;
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetModel(string model)
        {
            _car.Model = model;
        }

        public void SetSeats(int seats)
        {
            _car.NumberOfSeat = seats;
        }

        public void SetTurbo()
        {
            _car.Turbo = true;
        }
    }
}
