var (_,_,_, pop1, _,pop2) = QueryCityDataForYears("New York City", 1960, 2010);

Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");

static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2) {
    int population1 = 0, population2 = 0;
    double area = 0;

    if (name == "New York City") {
        area = 468.9;
        if (year1 == 1960) {
            population1 = 7781984;
        }
        if (year2 == 2010) {
            population2 = 8175133;
        }
        return (name area, year1, population1, year2, population2);
    }

    return ("", 0, 0, 0, 0, 0);
}

// the example displays the follow output:
//    Population change, 1960 to 2010: 393,149

object?[] objects = [CultureInfo.CurrentCulture, 
                        CultureInfo.CurrentCulture.DateTimeFormat, 
                        CultureInfo.CurrentCulture.NumberFormat, 
                        new ArgumentException(), 
                        null];

foreach (var obj in object)
    ProvidesformatInfo(obj);

static void ProvidesformatInfo(object? obj) => 
    Console.WriteLine(obj switch
    {
        IFormatProvider fmt => $"{fmt.GetType()} object",
        null => "A null obj reference: ITs use could result in a NullReferenceException",
        _ => "An object of a type that does not implement IFormatProvider"
    });

// The example displays the following output:
//    System.Globalization.CultureInfo object
//    System.Globalization.DateTimeFormatInfo object
//    System.Globalization.NumberFormatInfo object
//    Some object type without format information
//    A null object reference: Its use could result in a NullReferenceException


string[] dateStrings = ["05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
                    "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                    "5/01/2018 14:57:32.80 -07:00",
                    "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                    "Fri, 15 May 2018 20:10:57 GMT"];

foreach (string dateString in dateStrings) {
    if (DateTime.TryParse(dateString, out _)) {
        Console.WriteLine($"'{dateString}': valid");
    } else {
        Console.WriteLine($"'{dateString}': invalid");
    }
// The example displays output like the following:
//       '05/01/2018 14:57:32.8': valid
//       '2018-05-01 14:57:32.8': valid
//       '2018-05-01T14:57:32.8375298-04:00': valid
//       '5/01/2018': valid
//       '5/01/2018 14:57:32.80 -07:00': valid
//       '1 May 2018 2:57:32.8 PM': valid
//       '16-05-2018 1:00:32 PM': invalid
//       'Fri, 15 May 2018 20:10:57 GMT': invalid

// A standalone discard
public static void Method(string arg) {
    _ = arg ?? throw new ArgumentNullException(paramName: nameof(arg), message: "arg can't be null");

    // Do work with arg
}

private static async Task ExecuteAsyncMethod() {
    Console.WriteLine("About to launch a task...");
    _ = Task.Run(() => {
        var iterations = 0;
        for (int ctr = 0; ctr <= int.MaxValue; ctr++) {
            iterations++;
        }
        Console.WriteLine("Completed looping operation...");
        throw new InvalidOperationException();
    });
    await Task.Delay(5000);
    Console.WriteLine("Exiting after 5 second delay...");
}
// The example displays output like the following:
//       About to launch a task...
//       Completed looping operation...
//       Exiting after 5 second delay




