using System;

namespace TJ.CSharp_Doc.Fundamental.Function_Technique
{
    class PatternMatching
    {
        // TYPE tests
        public static T MidPoint<T>(IEnumerable<T> sequence) {
            if (sequence is IList<T> list) {
                return list[list.Count / 2];
            } else if (sequence is null) {
                throw new ArgumentException(nameof(sequence), "The sequence is null");
            } else {
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0) { halfLength = 0; }
                return sequence.Skip(halfLength).First();         
            }
        }

        // test a value against all possible values declared in an enumeration
        public State PerformOperation(Operation command) => {
            command switch {
                Operation.SystemTest => RunDiagnostics(),
                Operation.Start => StartSystem(),
                Operation.Stop => StopSystem(),
                Operation.Reset => ResetToReady(),
                _ => throw new ArgumentException("Invalid operation", nameof(command))
            }
        }
        public State PerformOperation2(ReadOnlySpan<char> command) =>
            command switch
            {
                "SystemTest" => RunDiagnostics(),
                "Start" => StartSystem(),
                "Stop" => StopSystem(),
                "Reset" => ResetToReady(),
                _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
            };       
        }

        string WaterStrate(int tempIntFahrenheit) {
            tempIntFahrenheit switch {
                (>32) and (<212) => "Liquid",
                < 32 => "solid",
                >212 => "gas",
                32 => "solid/liquid transition",
                212 => "liq/gas transition",
            }
        }

        // positional pattern where properties are decontucted for the expression
        public decimal CalculateDiscount(Order order) =>
            order switch
            {
                ( > 10,  > 1000.00m) => 0.10m,
                ( > 5, > 50.00m) => 0.05m,
                { Cost: > 250.00m } => 0.02m,
                null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
                var someObject => 0m,
            };
        }



        static void Main(string[] args)
        {
            // NULL CHECK
            // declaration pattern
            int? maybe = 12;

            if (maybe is int number) {
                Console.WriteLine($"The variable 'maybe' is an integer with the value {number}");
            } else {
                Console.WriteLine("The variable 'maybe' is not an integer");
            }

            string? message = "This is not the null string";

            if (message is not null) {
                Console.WriteLine(message);
            }

            MidPoint(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

                    
            decimal balance = 0m;
            foreach (string[] transaction in ReadRecords())
            {
                balance += transaction switch
                {
                    [_, "DEPOSIT", _, var amount]     => decimal.Parse(amount),
                    [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
                    [_, "INTEREST", var amount]       => decimal.Parse(amount),
                    [_, "FEE", var fee]               => -decimal.Parse(fee),
                    _                                 => throw new InvalidOperationException($"Record {string.Join(", ", transaction)} is not in the expected format!"),
                };
                Console.WriteLine($"Record: {string.Join(", ", transaction)}, New balance: {balance:C}");
            }


        }
    }
}