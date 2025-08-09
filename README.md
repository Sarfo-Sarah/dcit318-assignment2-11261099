# C# Object-Oriented Programming Demo

This repository contains a C# console application that demonstrates key object-oriented programming concepts including inheritance, abstract classes, and interfaces.

## Features

### 1. Inheritance
- Base class `Animal` with virtual method `MakeSound()`
- Derived classes `Dog` and `Cat` that override the `MakeSound()` method
- Demonstrates method overriding and polymorphism

### 2. Abstract Classes
- Abstract class `Shape` with abstract method `GetArea()`
- Concrete implementations:
  - `Circle` - calculates area using πr²
  - `Rectangle` - calculates area using width × height

### 3. Interfaces
- `IMovable` interface with `Move()` method
- Implementations:
  - `Car` - implements `Move()` to print "Car is moving"
  - `Bicycle` - implements `Move()` to print "Bicycle is moving"

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
- A code editor (Visual Studio, VS Code, or JetBrains Rider recommended)

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/techpepson/dcit318-assignment2-11335214.git
   cd dcit318-assignment2-11335214
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

## Expected Output

```
=== Animal Sounds ===

Animal says: 
Some generic sound

Dog says: 
Bark

Cat says: 
Meow

=== Shape Areas ===

Area of circle with radius 5: 78.54
Area of rectangle 4x6: 24.00

=== Moving Objects ===

Car movement: 
Car is moving

Bicycle movement: 
Bicycle is moving

Press any key to exit...
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
