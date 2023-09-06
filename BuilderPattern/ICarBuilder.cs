using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // Builder interface định nghĩa các bước chung để build một object nào đó
    public interface ICarBuilder
    {
        void Reset();
        void SetModel(string model);
        void SetSeats(int seats);
        void SetEngine(string engine);
        void SetTurbo();
    }
}
