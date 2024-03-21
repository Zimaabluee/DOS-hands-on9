using System;

// Define the animal interface
public interface IAnimal
{
    void Speak();
}

// Define concrete animal classes
public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("woof");
    }
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("meow");
    }
}

// Define the animal factory interface
public interface IAnimalFactory
{
    IAnimal CreateAnimal();
}

// Implement concrete animal factories
public class DogFactory : IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Dog();
    }
}

public class CatFactory : IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Cat();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Use the dog factory to create a dog object
        IAnimalFactory dogFactory = new DogFactory();
        IAnimal dog = dogFactory.CreateAnimal();
        dog.Speak(); // Output: woof

        // Use the cat factory to create a cat object
        IAnimalFactory catFactory = new CatFactory();
        IAnimal cat = catFactory.CreateAnimal();
        cat.Speak(); // Output: meow
    }
}
