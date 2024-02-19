public class Tuples {
    public static void Main() {
        var result = QueryCityData("New York City");

        var city = result.Item1;
        var pop = result.Item2;
        var size = result.Item3;

        // Do something with the data

    }

    public static (string, int, double) QueryCityData(string name) {
        if (name == "New York City") {
            return (name, 8175133, 468.9);
        }
        return ("", 0, 0);
    }
}

public class ExampleDiscard {
    public static void Main() {
        var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

        Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");
    }

    public static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2) {
        int population1 = 0, population2 = 0;
        double area = 0;

        if (name == "New York City") {
            area = 468.48;
            if (year1 == 1960) {
                population1 = 7781984;
            }
            if (year2 == 2010) {
                population2 = 8175133;
            }
            return (name, area, year1, population1, year2, population2);
        }
        return ("", 0, 0, 0, 0, 0);
    }
}
// The example displays the following output:
//      Population change, 1960 to 2010: 393,149