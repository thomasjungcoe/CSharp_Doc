The C# type system
    C# is a strongly typed language.
    The .NET class library defines built-in numberic types and complex types that represent a wide variety of construct.
        These clude file system, network connections, collections, and arrays of objects, and dates.
        The compiler uses type information to make sure all operations that are performed in your code are type safe.
        After you declare a variable, you can't redeclare it with a new type, and you can't assign a value not compatible with its declared type.
        However, you can use a type conversion that doesn't cause data loss is performed automatically by the compiler.
            A conversion that might cause a data loss requires a "cast" in the source code.
        
Custom types
    You use the struct, class, interface, enum and record contructs to create your own custom types.

    A class, strcut, or record declaration is like a blueprint that is used to create instance or objects at run time.
        A class is a reference type.
            when an object reference is assigned to a new variable, the new variable refers to the original obj. 
            Changes made through one variable are reflected in the other variable becuase they both refer to the same data
        A struct is a value type.
            When created, the vriable to which the strcut is assigned hold the struct's actual data.
            Whenn assgiend to the different variable, it's copied. The new variable and the old variables therefore contain two separate copies of the same data, 
            and changes don't reflect on each other.
        Record types may be either ref type or val type.
            Record types contain methods that support value-equality.

Value types
    Value types hold their own value and built inline the code. Thus, there is no separate heap allocation or garbage collection overhead for value-type variable.
        Two categories of value types: struct and enum

Generic type
    a type can be declraed with one or more type parameters that serve as a placeholder for the actual type (the concrete type)
    The client code provides the concrete type when it creates an instance of the type.


Compile-time type and Run-time type
    A variable can have different comepile-time and run-time types.
        The compile-time types is the declared or inferred type of the variable in the source code.
        The run-time type is the type of the instance referred to by that variable.
    
    Where these two apply?
        The compile-time type determines all the actions taken by the compiler. These compiler actions include method call resuloution, overload resolutions, and available implicit and explicit casts.
        The run-time type determines all actions that are resolved at run time. These run-time actions include dispatching virtual method calls, evaluating is and switch expression, and otyher type testing APIs.



Intro to Classes

Reference types
    A type that is defined as a class is a reference type.
        The variable defined as a reference type contains the value null until you explicitly create an instance of the calass by using new operator (at declaration) or assign it an obj of a compatible type that may have been created elsewhere.
    .... pretty basic stuffs for me to write about honestly ...


Introduction to record types in C#
    A record in C# is a class orstrcut that provides special syntasx and behaviior for working with data models. The "record" modifier instructs the compiler to synthesize members that are useful
        for types whose primary roles in storing data.
    When to use records?
        * You want to define data meodel that depends on "value equality"
        * You want to define a type for which objects are immutable.
    