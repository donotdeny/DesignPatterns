using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    // more flexible than factory method by define interface and implement them
    public interface ICreator
    {
        IProductAmisPlatform CreateAmisPlatformProduct();
        IProductWebsite CreateWebsiteProduct();
    }

    public class ConcreteCreatorCluster1 : ICreator
    {
        public IProductAmisPlatform CreateAmisPlatformProduct()
        {
            return new ConcreteProductMily();
        }

        public IProductWebsite CreateWebsiteProduct()
        {
            return new ConcreteProductCommunity();
        }
    }

    public class ConcreteCreatorCluster2 : ICreator
    {
        public IProductAmisPlatform CreateAmisPlatformProduct()
        {
            return new ConcreteProductEducation();
        }

        public IProductWebsite CreateWebsiteProduct()
        {
            return new ConcreteProductForum();
        }
    }

    public interface IProductAmisPlatform
    {
        string OperationCICD();
    }

    public class ConcreteProductMily : IProductAmisPlatform
    {
        public string OperationCICD()
        {
            return "Mily project is continue CI/CD flow...";
        }
    }

    public class ConcreteProductEducation : IProductAmisPlatform
    {
        public string OperationCICD()
        {
            return "Education project is continue CI/CD flow...";
        }
    }

    public interface IProductWebsite
    {
        string BuildNormal();
    }

    public class ConcreteProductCommunity : IProductWebsite
    {
        public string BuildNormal()
        {
            return "Community project is running with normal build...";
        }
    }

    public class ConcreteProductForum : IProductWebsite
    {
        public string BuildNormal()
        {
            return "Forum project is running with normal build...";
        }
    }
}
