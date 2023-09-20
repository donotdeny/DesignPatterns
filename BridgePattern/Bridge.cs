using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // Lớp trừu tượng định nghĩa giao diện chung cho tất cả các lớp concrete.
    // Nó cũng có một tham chiếu đến một đối tượng của lớp Implementor.
    public abstract class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public abstract void Operation();
    }

    // Lớp refined abstraction mở rộng lớp Abstraction
    // và cung cấp các phương thức thực hiện cụ thể cho một nhóm lớp concrete khác.
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override void Operation()
        {
            _implementation.OperationImplementation();
        }
    }

    // Interface implementor định nghĩa giao diện cụ thể cho một nhóm lớp concrete.
    // Nó cũng cung cấp các phương thức thực hiện cho các chức năng được định nghĩa trong lớp Abstraction.
    public interface IImplementation
    {
        void OperationImplementation();
    }

    // Lớp concrete implementor mở rộng lớp Implementor và cung cấp các phương thức thực hiện cụ thể cho
    // một nhóm lớp concrete nhất định.
    public class ConcreteImplementationA : IImplementation
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ConcreteImplementationA: The result in platform A.\n");
        }
    }

    public class ConcreteImplementationB : IImplementation
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ConcreteImplementationB: The result in platform B.\n");
        }
    }
}
