Pattern Matching Overview
    Pattern matching is a tech where you test an expression to dteermine if it has certain characteristics.
        * "is expression"
        * "switch expression"

    Null checks
        constant pattern such as comapring the variable to null
        logical pattern that matches the gnegated pattern doesn't match using "not"
    
    Type tests
        _ <-- discard pattern that matches all value>

    Multiple Input
        positoinal pattern is where the properties are deconstructed for the expression.

    List patterns
        list pattern provies a means to apply a pattern to any elements of a sequence.
            you can apply discrd pattern  (_) to match any elements, 
            or apply a slice pattern to match zero or more elements
        

Discards - C# Fundamentals
    Discards are placeholder variables that are intntionally unused in application code, which are equivalent to unassigned variables; they don't have a value.
    You indicate that a variable is a discard by assignning it the underscore (_) as its name
        ex.) (_,_, area) = city.GetCityInformation(cityName);

    Tuple and obj deconstruction
        You can use discards when you're interested in working with only a subset of the deconstructed values

    Pattern matching with switch
        The "discard pattern" can be used in pattern matching with the switch expression

    Calls to methods with out parameters
        When calling the Deconstruct method to deconstruct a user-defined type (an instance of a calss, struct, or interface), you can discrad the values of individual "out" arguments. But you can also discard the value of "out" args when calling any method with an "out" parameter.

    A standalone discard
        You can use a standlone discard to indicate any varible that you choose to ignore.

    * _ is also a valid identifier. When used outside of a supported context, _ is treated not as a discard but as a valid variable.


Deconstructing tuples and other types
    A tupule provides a lightweight way to retrieve multiple values from a method call.
    You can retrieve multiple elements from a tuple or retrieve multiple field, property, and computed values from an object in a single deconstruct operation. 

    Tuple elements with discards
        Often when deconstructing a tuple, you're interested in the values of only some elements. 
        You can take advantage of C#'s support for discards, which are write-only variables whose values you've chosen to ignore. 

    User-defined types
        C# doesn't offer built-in support for deconstructing non-tuple types other than the record and DictionaryEntry types. 
        However, as the author of a class, a strcut, or  an interface, you can allow instances of the type to be deconstructed by implementing one
            or more Deconstruct methods.        
        The method returns void, and each value to be deconstructed is indeicated by an "out" parameter in the method signature.
            ex.)
                public void Deconstrut(out string fname, out string mname, out string lname)

    Extension methods for user-defined types
        If you didn't author a class, struct, or interface, you can still deconstrcut objects of that type by implementing one or more Deconstrcut extension methods to return the values in which you're interested.
