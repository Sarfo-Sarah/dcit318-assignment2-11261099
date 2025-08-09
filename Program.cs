// See https://aka.ms/new-console-template for more information

using System;

// Base class Animal
public class Animal
{
    // Virtual method that can be overridden by derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
public class Dog : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
public class Cat : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Abstract class Shape
public abstract class Shape
{
    // Abstract method that must be implemented by derived classes
    public abstract double GetArea();
}

// Derived class Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implement the abstract GetArea method
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implement the abstract GetArea method
    public override double GetArea()
    {
        return Width * Height;
    }
}

// Interface for movable objects
public interface IMovable
{
    void Move();
}

// Car class implementing IMovable
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle class implementing IMovable
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Animal Sounds ===");
        // Create instances of each animal class
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call MakeSound on each animal instance
        Console.WriteLine("\nAnimal says: ");
        genericAnimal.MakeSound();

        Console.WriteLine("\nDog says: ");
        dog.MakeSound();

        Console.WriteLine("\nCat says: ");
        cat.MakeSound();

        Console.WriteLine("\n=== Shape Areas ===");
        // Create instances of shapes
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        // Display areas
        Console.WriteLine($"\nArea of circle with radius {circle.Radius}: {circle.GetArea():F2}");
        Console.WriteLine($"Area of rectangle {rectangle.Width}x{rectangle.Height}: {rectangle.GetArea():F2}");

        Console.WriteLine("\n=== Moving Objects ===");
        // Create instances of movable objects
        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();

        // Call Move on each movable object
        Console.WriteLine("\nCar movement: ");
        myCar.Move();

        Console.WriteLine("\nBicycle movement: ");
        myBicycle.Move();

        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
