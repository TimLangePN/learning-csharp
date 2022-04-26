/*
C# Is managed code, meaning that its managed by runtime and compiled down to machine code.



while loop vs do while loop:
A "While" Loop is used to repeat a specific block of code an unknown number of times, until a condition is met.
The do...while loop executes at least once i.e. the first iteration runs without checking the condition.

Access modifiers:
- public:       The code is accessible for all classes
- private:      The code is only accessible within the same class
- protected:    The code is accessible within the same class, or in a class that is inherited from that class.
- internal:     The code is only accessible within its own assembly, but not from another assembly.

Classes and objects:

public class Person -> class 
A class is a user-defined blueprint or prototype from which objects are created.

Person person2 = new Person(); -> Instances of an object
An object that is created using a class is said to be an instance of that class.

public class SuperPerson : Person -> Inheritance
Inheritance enables you to create new classes that reuse, extend, and modify the behavior defined in other classes.

public void Fly() -> method
A function is directly called by its name, whereas a method includes a code that is called by the object's name.
me.Fly(); -> method

Access modifier - return type - method name - parameters
public string GetFullName(string Firstname, string Lastname)

void
The void keyword is used in method signatures to declar that it doesn't return a value.

Fields vs properties
Properties expose fields. Fields should (almost always) be kept private to a class and accessed via get and set properties.

public int Lives { get; set; } -> auto property.

get and set:
The get method returns a value.
The set method assigns a value.

Abstraction:
"Shows" only essential attributes and "hides" unnecessary information.

Inheritance:
Inheritance enables you to create new classes that reuse, extend, and modify the behavior defined in other classes.

Encapsulation:
The concept of wrapping data into a single unit.

Polymorphism:
The concept that you can access objects of different types through the same interface.

SOLID:

Single Responsibility Principle (SRP):
A class should have only one reason to change.

Open Closed Principle (OCP)
An entity (class, method, etc) should be easily extended but it shouldn't be needed to change its core implementations by doing so.

Liskov Substitution Principle (LSP)
Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.

Interface Segregation Principle (ISP)
No client should be forced to implement methods which it does not use.

Dependency Inversion Principle (DIP)
The Dependency Inversion Principle (DIP) states that high-level modules should not depend on low-level modules.
Both should depend on abstractions. W
Abstractions should not depend on details, details should depend upon abstractions.

Constructors:
A constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created.

Overloading:
Multiple methods with the same name but different signatures (or arguments).

Static:
A static member can only be referenced through the type name and not through an instance of the type. 
Static cannot be used with a destructor, indexer or any type other than class

Variable scope:
The part of the application where that variable is being used and outside of that scope being disposed by the garbage collector.

Garbage collector:
The garbage collector frees up memory which was allocated but is no longer in use.

Value types: (bool, decimal, int, float, double) -> stack 
A value type stores it value within its own memory location.
When passing a value type through a method it creates a separate copy.
Passing a value type through a method will not affect the original value outside of that method.
The value type gets cleaned up together with the instance it resides in.
Local variables in methods get cleaned up upon method leave.

Reference types: (String(immutable), class, array) -> heap
Holds a memory address of a value not the value itself.
When passing a reference variable to a method it can change the original value
-- Garbage collector


 */