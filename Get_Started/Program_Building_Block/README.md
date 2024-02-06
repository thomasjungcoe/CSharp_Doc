# Program Building Blocks

* Members
* Fields
* Methods
* Other function members
* Expressions
* Statements


Members
    The members of a class are either static members or instance members.
        Static members belong to classes , and instaence members belong to objects (instances of classes).
            * Constants
            * Fields
            * Methods
            * Properties
            * Indexers
            * Events
            * Operators
            * Constructors
            * Finalizers
            * Types

Accessibility
    Each member has associated accessability
        * public
        * private
        * protected
        * internal: access is limited to the current assembly (.exe or .dll)
        * protected internal: access is limited to this class, classes derived from this class, or classes within the same assembly.
        * private protected: Access is limited to this class or classes derived from this type within the same assembly

Fields
    A field is a variable that is associated with a class or with an instance of a class

    A field declared with the staic modifier defines a static field. 
        A static field identifies exactly one storage location.
        No matter how many instances of a class are created, there's only ever one copy of a static field.
    
C# requires a local variable to be "definitely assigned" before its value can be obtained.
    ex.) if no value is assigned on "i" <-- error occurs (for forloop)


Static and instance method
    a method declared with a static modifier is a static method.
        A static method doesn't operate on a specific instance and can only directly access static members.

    a method declared without a static modifier is an instance method.
        An instance method operates on a specific instance and can access both static and instance members. (using this)


Virtual, override, and abstract methods
    A virtual method is one declared and implemented in a base class where any derived class may provide a more specific implementation
    An override method is a method implented in a derived class that modifies the behavior of the base class' implementation
    An abstract method is a method declared in a base class that must be overriden in all derived classes

    Method calls to instance methods may resolve to either base class or derived class implementations.
    The type of a variable determines its compil-tiome type, which is the type the compiler uses to determine its members.
    However, a variable may be assigned to an instance of any type derived from its compile-time type.
    The run-time type is the type of the actual instance a variable refers to.

    A virtual method can be overridden in a derived class. 
    An abstract method is a virtual method with no implementation.


Other function members
    Members that contain executable code are collectively known as the function members of a class.
        such as method, contructors, properties, indexers, events, operators, and finalizers.

Constructors
    C# supports both instance and static constructors.
        An instance constructor is a memeber that implements the actions erquired to initialize an instance of a calss.
        A static constructor is a member that implements the actions required to initialize a class itself when it's first loaded.

Properties
    Properties are a natursal extensions of fields. However unlike fields, properties don't denot storage locations.
        Instead, properties have accessors that specify the statements executed when their values are read or written (get and set accessors)

Indexers
    An indexer is a member that enables obj to be indexed in the same way as an array via 'this' followed by [].

