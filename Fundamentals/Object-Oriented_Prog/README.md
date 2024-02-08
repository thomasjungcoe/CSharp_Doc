Object-Oriented Programming

Encapsulation 
    A class or struct can specify how accessible each of tis members is to code outside of hte class or struct.
    Methods and variables that aren't intended to be used from outside of the class or assembly can be hidden to limit the potential for coding errors or malicious exploits.

Inheritance
    Inheritance enables you to create new classes that reuse, extend, and modify the behavior defined in other classes.
        the calss whose members are inherited is called the base class.
        Conceptionally, a derived class is a specialization of the base class
            ex.) Animal -> Mammal and Reptile.
        When you drive from antoher class, the derived class implicitly gains all the members of the base class, except for its constructor and finalizers.
        When a base class declares a method as virtual, a derived class can override the method with its own implementation. If a base class declares a member as abstract, that method must be overridden in any non-abstract class that directly inherits from that class.
        An interface is a reference type that defines a set of members.
        Interfaces are used to define specific capabilities for classes that don't necessarily have an "is a" relationship.

Polymorphism
    * At run time, objects of a derived class may be treated as obj of a base class in places such as method parameters and collections or arrays.
        When this polym occurs, the obj declared type is no longer identical to its runtime type.
    * Base classes may define and implement virtual methods, and dervied classes can override them, which means they provide their own def. and implementation.
        At run-time, when client code calls the method, the CLR looks up the run-time type of the object, and invokes that override of the virtual method.