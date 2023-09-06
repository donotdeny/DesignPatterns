using BuilderPattern;

CarBuilder carBuilder = new();
Director director = new()
{
    Builder = carBuilder
};

director.BuildSedanCar();

Console.WriteLine(carBuilder.GetResult());

SuperCarBuilder superCarBuilder = new();
director = new()
{
    Builder = superCarBuilder
};
director.BuildSuperCar();

Console.WriteLine(superCarBuilder.GetResult());