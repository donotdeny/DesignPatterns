using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // Director chịu trách nhiệm thực hiện các bước build theo một trình tự xác định cụ thể 
    // Lớp này là tùy chọn vì client có thể tự build cũng được
    public class Director
    {
        private ICarBuilder _builder = default!;

        public ICarBuilder Builder 
        { 
            set { _builder = value; } 
        }

        public void BuildSedanCar()
        {
            _builder.Reset();
            _builder.SetModel("Mercedes C300 AMG");
            _builder.SetSeats(4);
            _builder.SetEngine("I4");
        }

        public void BuildSuperCar()
        {
            _builder.Reset();
            _builder.SetModel("Vinfas Lux A2.0");
            _builder.SetSeats(4);
            _builder.SetEngine("I4");
            _builder.SetTurbo();
        }
    }
}
