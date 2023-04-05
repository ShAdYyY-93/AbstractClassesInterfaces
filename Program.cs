
using Homework___1.Entities;

Cat roki = new Cat("Roki", 11, true, false, "Skopje");
Dog barni = new Dog
{
    Age = 4,
    Name = "Barni",
    Inside = true,
    City = "Skopje",
};

Console.WriteLine(roki.Name);
Console.WriteLine(roki.Age);

roki.Eat("Tuna");
barni.Bark();

Console.WriteLine("========");

roki.PrintAnimal();
barni.PrintAnimal();






