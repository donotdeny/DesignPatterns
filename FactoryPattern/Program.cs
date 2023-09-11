using FactoryPattern;

Creator creator = new ConcreteCreatorMily();
IProduct mily = creator.FactoryMethod();
Console.WriteLine(mily.Operation());
Console.WriteLine("-------------------");
creator = new ConcreteCreatorCommunity();
IProduct community = creator.FactoryMethod();
Console.WriteLine(community.Operation());