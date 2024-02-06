class Program
{
    static void Main(string[] args)
    {
        // static and instance methods
        Entity.SetNextSerialNo(1000);
        Entity e1 = new Entity();
        Entity e2 = new Entity();

        Console.WriteLine(e1.GetSerialNo); // 1000
        Console.WriteLine(e2.GetSerialNo); // 1001
        Console.WriteLine(Entity.GetNextSerialNo()); // 1002

        // Abstract, override, and abstract methods
        Expression e_plus = new Operation(
            new VariableReference("x"),
            '+',
            new Constant(3));

        Expression e_multiply = new Operation(
            new VariableReference("x"),
            '*',
            new Operation(
                new VariableReference("y"),
                '+',
                new Constant(2)
            )
        );

        Dictionary<string, object> vars = new();
        vars["x"] = 3;
        vars["y"] = 5;
        Console.WriteLine(e_plus.Evaluate(vars)); // 6
        Console.WriteLine(e_multiply.Evaluate(vars)); // 21

        // Property
        MyList<string> names = new();
        names.Capacity = 100;   // Invokes set accessor
        int i = names.Count;    // Invokes get accessor
        int j = names.Capacity; // Invokes get accessor

        // Indexer
        MyList<string> names = new();
        names.Add("Liz");
        names.Add("Martha");
        names.Add("Beth");
        for (int i= 0; i < names.Count; i++)
        {
            string s = names[i];
            names[i]= s.ToUpper();
        }
    }
}

