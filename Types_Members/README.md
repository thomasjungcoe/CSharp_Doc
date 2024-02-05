# concepts notes

C# types and members

As an OOL, C# supports the concepts of encapsulation, inheritance, and polymorphism.

A class may inherit directly from one parent class, and it may implement any number of interfaces.

Methods that override virtual methods in a parent class require the "override" keyword as a way to avoid accidental redefition.

In C#, a struct is like a lightwieght class;
    It's a stack-allocated type that can implement interfaces but doesn't supporet inheritance.

C# provide record class and record strcut types, which are types whose purpose is primarily storing data values.

All types are initialized through constructor, a method responsoible for initializeing an instance.
    Two contructor declarations have unique behavior:
        * a parameterless constructor, which initializes all fields to their default value.
        * a primary constructor, which declares the rquired parameters for an instance of that type.


Classe and Obj

Classes are the most fundamental of C#'s types.
    A class is a data structure that combines state (fields) and actions (methods and other functio memebers) in a single unit.
    A class provides a definition for instances of the class, also known as objects
    Classes suport inheritance and polymorphism, mechanisms whereby derived classes can extend and specialize base classes.

    instances of classes are created using the "new" operator, which allocates memory for a new instance


Type Parameters

Generic classes define type parameters, which are a list of type parameter names enclosed in angle braskets
The type parameters can then be used in the body of the class declarations to define the members of the class.

A class type that is declared to take type parameters is called a generic class type.
    Strcut, Interface, and delegate types can also be generic.
    When generic class is used, type arg must be provided for each of the type param.


Structs

Classes define types that support inheritance and polymorphism. They enable you to creat esophisticated behaviors based on hierarchies of derived classes.
By constrast, strcut types are simpler types whose primary purpose is to store data values.
    Structs can't declare a base type; they implicitly derive from System.ValueType.
    You can't derive other struct types from a struct type. The are implicitly sealed.

Interfaces

An interface defines a contract that can be inmplemented by classes and structs.
An interface can contain methods, properties, events, and indexers. It typically doesn't provide implementations of the members it defines - 
    it merely specifies the members that must be supplied by classes or structs that implement the interface.
Interfaces may employ multiple inheritance.
    ex.) "IComboBox" inherits from both "ITextBox" and "IListBox".


Enums

AN Enum type defines a set of constant values.
You can define an enum to be used in combination as flags.


Nullable types

Variables of any type may be decalred as non-nullable or nullable, which can hold additional "null" value, indicating no value. (represented by System.Nullable<T>)
    ex.) int? optionalInt = default;
         optionalInt = 5;
         string? optionalText = default;
         optionalText = "Hello World.";

Tuples

C# supports tuples, which provides concise syntax to group muliple data elements in a lightweight data structure.
    ex.) (double Sum, int Count) t2 = (4.5, 3);
         Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
         // Output:
         // Sum of 3 elemetns is 4.5.