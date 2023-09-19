using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // inteface tương thích với client code
    public interface ITarget
    {
        string GetRequest();
    }

    // interface chứa các method không tương thích với client code
    public interface IAdaptee
    {
        string GetSpecificRequest();
    }

    class Adaptee : IAdaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    class Adapter : ITarget
    {
        private readonly IAdaptee iAdaptee;

        public Adapter(IAdaptee adaptee)
        {
            iAdaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{iAdaptee.GetSpecificRequest()}'";
        }
    }
}
