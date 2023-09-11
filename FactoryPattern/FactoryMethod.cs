using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // factory method is more flexible than factory (use abstract class and return abstract product)
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    public class ConcreteCreatorMily : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductMily();
        }
    }

    public class ConcreteCreatorCommunity : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductCommunity();
        }
    }

    public interface IProduct
    {
        string Operation();
    }

    public class ConcreteProductMily : IProduct
    {
        public string Operation()
        {
            return "Mily project is running...";
        }
    }

    public class ConcreteProductCommunity : IProduct
    {
        public string Operation()
        {
            return "Community project is running...";
        }
    }
}
