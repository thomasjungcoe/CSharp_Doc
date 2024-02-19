// example of deconstructing tutples and other types using discards.
using System;
using Discard;

namespace Discard
{
    class Person 
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Person(string first, string middle, string last, string city, string state) {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
            City = city;
            State = state;
        }
    }

    // Return the first and last name
    public void Deconstruct(out string fname, out string lname) {
        fname = FirstName;
        lname = LastName;
    }

    public void Deconstruct(out string fname, out string mname, out string lname) {
        fname = FirstName;
        mname = MiddleName;
        lname = LastName;
    }

    public void Deconstruct(out string fname, out string lname, out string city, out string state) {
        fname = FirstName;
        lname = LastName;
        city = City;
        state = State;
    }
}

class Example {
    public static void Main() {
        var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

        // Desconstruct the person object
        var (fName, _, city, _) = p;
        Console.WriteLine($"Hello {fName} of {city}!");
        // The example displays the following output:
        //    Hello John of Boston!
    }
}