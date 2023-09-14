using PrototypePattern;

Person originalPerson = new()
{
    Name = "Steve Doe",
    Age = 22,
    Address = new Address
    {
        Street = "123 Main St.",
        City = "Anytown",
        State = "AB"
    }
};

Person clonePerson = originalPerson.ShallowClone();
clonePerson.Name = "Steve";
clonePerson.Address.Street = "231 Dinh Cong Thuong";
Person cloneDeepPerson = (Person) originalPerson.Clone();
cloneDeepPerson.Name = "Doe";
cloneDeepPerson.Address.Street = "86 Phu Do";
Console.WriteLine(originalPerson);
Console.WriteLine(clonePerson);
Console.WriteLine(cloneDeepPerson);