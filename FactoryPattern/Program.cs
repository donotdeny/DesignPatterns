using FactoryPattern;

var test = new Person.PersonFactory();
Person person1 = test.CreatePerson("An");
Person person2 = test.CreatePerson("Bao");
Person person3 = test.CreatePerson("Nguyen");
Console.WriteLine(person1);
Console.WriteLine(person2);
Console.WriteLine(person3);
