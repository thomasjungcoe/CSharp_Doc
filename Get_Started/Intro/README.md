Program Structure

The organizational concepts in C# are programs, namespaces, types, members, and assemblies.

Programs decalre teypes, which contain members and can be organized into namespaces.
    * Classes, structs, and interfaces are examples of types.
    * Fields, methods, properties, and events are examples of members.

When C# programs are compiled, they're physically packaged into assemblies, which typically have extension .exe or .dll 
    depending on whether they implement applications or libraries, respectively

Assemblies contain executable code in the form of Intermediate Language (IL) instructions, and symbolic information in the form of metadata.
    Before it's executed, the Just-In-Time(JIT) compiler of .NET Common Language Runtime converts the IL code in an assembly to processor-specific code.

Because an assembly is a self-describing unit of functionality containing both code and metadata, there's no need for "#include" directives and header files in C#.
    The public types and members contained in a particular assembly are made available in C# program simply by referencing that assembly when compilling the program
        ex.) this program uses the Acme.Collections.Stack class from the acme.dll assembly