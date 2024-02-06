Arrays, collections, LINQ
    C# and .NET provide many different collection types.
        Arrays have syntax defined by the language.
        Generic collection types are listed in the Sytem.Collections.Generic namespace
        specialized collecitons include System.Span<T> for accessing continuous memory on the stack frame
        System.Memory<T> for accessing continous memory on the manged heap.

        All collections, cluding arrays, Span<T>, and Memory<T> share a unifying principle for iteration.
            You use the System.Collections.Generic.IEnumerable<T> interface, which means LINQ queries and other algo can be on those. (IEnumerable<T>)

Arrays
    single-dimentional, multi-dimentional... the number of dimensions of an array type is konwn as rank of the array type (1 + # of comma).
    jagged array are the ones with unqual lengths of the elements mong the arrays.

String interpolation
    C# string interpolation enables you to format strings by defining expressions whose results are placed in a format string.
        An interpolated string is declared using the $ token.

Pattern matching
    The C# lagunage provide pattern matching expressions to query the state of an object and execute code based on that state.
        "switch" expression is the primary expression for pattern matching

Delegates and lambda expressions
    A delegate type represents references to methods with a particular parameter list and return type.
    Delegates make it possible to treat methods as entities that can be assigned to variables and passed as parameters.
    simliar to fucntion pointer but unlike it, delegates are Obj-oriented and type-safe.

Async / await
    C# supporst asynchronous programs with two keywords: async and await.
        The async keyword and await operator provide a language-level abstraction over lower-level primitives that support asynchrnous operations.
        The compiler and library might rely on network interrupts, OS events, hardware interrupts, or other prmitives to trigger the completion of an asynch operations.
        The compiler generates code to upsdate the state of any Task obj and transfer control to code that should execute when the awaited task completes.

Attributes
    public, protected, internal, private, HelpAttribute (can be placed on program entities to provide links to their associated doc)

    