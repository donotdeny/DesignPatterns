using AbstractFactory;

ICreator creator = new ConcreteCreatorCluster1();
IProductAmisPlatform mily = creator.CreateAmisPlatformProduct();
IProductWebsite community = creator.CreateWebsiteProduct();  
Console.WriteLine(mily.OperationCICD());
Console.WriteLine(community.BuildNormal());

Console.WriteLine("-----------------------------");

ICreator creator2 = new ConcreteCreatorCluster2();
IProductAmisPlatform education = creator2.CreateAmisPlatformProduct();
IProductWebsite forum = creator2.CreateWebsiteProduct();
Console.WriteLine(education.OperationCICD());
Console.WriteLine(forum.BuildNormal());
