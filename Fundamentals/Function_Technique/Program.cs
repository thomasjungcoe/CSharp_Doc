// using System;

// namespace TJ.CSharp_Doc.Fundamental.Function_Technique
// {
//     class Program
//     {
//         // TYPE tests
//         public static T MidPoint<T>(IEnumerable<T> sequence) {
//             if (sequence is IList<T> list) {
//                 return list[list.Count / 2];
//             } else if (sequence is null) {
//                 throw new ArgumentException(nameof(sequence), "The sequence is null");
//             } else {
//                 int halfLength = sequence.Count() / 2 - 1;
//                 if (halfLength < 0) { halfLength = 0; }
//                 return sequence.Skip(halfLength).First();         
//             }
//         }       

//         static void Main(string[] args)
//         {
//             // NULL CHECK
//             // declaration pattern
//             int? maybe = 12;

//             if (maybe is int number) {
//                 Console.WriteLine($"The variable 'maybe' is an integer with the value {number}");
//             } else {
//                 Console.WriteLine("The variable 'maybe' is not an integer");
//             }

//             string? message = "This is not the null string";

//             if (message is not null) {
//                 Console.WriteLine(message);
//             }

//             MidPoint(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            



//         }
//     }
// }