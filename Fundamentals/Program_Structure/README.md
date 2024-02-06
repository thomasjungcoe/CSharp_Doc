General Structure of a C# Program

    C# -> files -> namespaces -> classes, structs, interfaces, enumerations, and delegates, other namepaces.
    Can be top-level or using static method named Main as the program's entry point.

    "Main" signatures
        public static void Main() { }
        public static int Main() { }
        public static void Main(string[] args) { }
        public static int Main(string[] args) { }
        public static async Task Main() { }
        public static async Task<int> Main() { }
        public static async Task Main(string[] args) { }
        public static async Task<int> Main(string[] args) { }

    The advantage of declaring Main as async is that the compiler always generates the corect code.


Command-Line Arguments

    * you can also use envinronmental.commandline or Environment.GetCommandLineARgs to access the command-line args from any point in a console or Windows Forms applications.
    The args array can't be null. So it's safe to access the Length property w/o null checking

    ex.)
        long num = Int64.Parse(args[0]);
        long num = long.Parse(args[0]);
        long num = Convert.ToInt64(s);


Top-level statements - programs without Main methods
    You don't have to explicitly include a Main method in a console app proj. Instead, you can use the top-level statements feature to minimize the code you have to write.
    Top-Level statements let you write simple programs for small utilities such as Azure Functions and GitHub Actions.
    Application should have only one entry point. Same for the top-level.

    Top-level statements are implicitly in the global namespace.