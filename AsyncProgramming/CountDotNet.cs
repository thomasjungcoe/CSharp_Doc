


class Button {
    public Func<object, object, Task>? Clicked {
        get;
        internal set;
    }
}

class DamageResult {
    public int Damage {
        get { return 0; }
    }
}

class User {
    public bool isEnabled { get; set; }
    public int id { get; set; }
}

public class Program {
    private static readonly Button s_downloadButton = new();
    private static readonly Button s_calculateButton = new();
    private static readonly HttpClient s_httpsClient = new();

    private static readonly IEnumerable<string> s_urlList = new string[] {
            "https://learn.microsoft.com",
            "https://learn.microsoft.com/aspnet/core",
            "https://learn.microsoft.com/azure",
            "https://learn.microsoft.com/azure/devops",
            "https://learn.microsoft.com/dotnet",
            "https://learn.microsoft.com/dotnet/desktop/wpf/get-started/create-app-visual-studio",
            "https://learn.microsoft.com/education",
            "https://learn.microsoft.com/shows/net-core-101/what-is-net",
            "https://learn.microsoft.com/enterprise-mobility-security",
            "https://learn.microsoft.com/gaming",
            "https://learn.microsoft.com/graph",
            "https://learn.microsoft.com/microsoft-365",
            "https://learn.microsoft.com/office",
            "https://learn.microsoft.com/powershell",
            "https://learn.microsoft.com/sql",
            "https://learn.microsoft.com/surface",
            "https://dotnetfoundation.org",
            "https://learn.microsoft.com/visualstudio",
            "https://learn.microsoft.com/windows",
            "https://learn.microsoft.com/xamarin"
    };

    private static void Calculate() {
        // <PerformGameCalculation>
        static DamageResult CalculateDamageDone() {
            return new DamageResult() {
                // Code ommited:
                //
                // Does an expensive calc and returns
                // the result of that cal
            };
        }

        s_calculateButton.Clicked += async (o, e) => {
            // This line will yield control to the UI while CalculateDamageDone()
            // performs its work. The UI thread is free to perform other work.
            var DamageResult = await Task.Run(() => CalculateDamageDone());
            DisplayDamage(DamageResult);
        };
        // </PerformGameCalculation>
    }

    private static void DisplayDamage(DamageResult damage) {
        Console.WriteLine(damage.Damage);
    }

    private static void Download(string URL) {
        // <UnblockingDownload>
        s_downloadButton.Clicked += async (o, e) => {
            // This line will yield control to the UI while the request from the web service is happening.
            // The UI thread is now free to perform other work.
            var stringData = await s_httpsClient.GetStringAsync(URL);
            DoSomethingWithData(stringData);
        };
        // </UnblockingDownload>
    }

    private static void DoSomethingWithData(object stringData) {
        Console.WriteLine("Displaying data: " + stringData);
    }
    
    private static async Task<IEnumerable<User>> GetUserAsync(int userId) {
        // Code ommited:
        // 
        // Given a user Id {userId}, retrieves a User Obj corresponding to the entry in the database with {userId} as its Id.
        return await Task.WhenAll(getUserTasks);
    }

    private static async Task<User[]> GetUsersAsyncByLINQ(IEnumerable<int> userIds) {
        var getUserTasks = userIds.Select(id => GetUserAsync(id)).ToArray();
        return await Task.WhenAll(getUserTasks);
    }

    // <ExtractDataFromNetwork>
    [HttpGet, Route("DotNetCount")]
    static public async Task<int> GetDotNetCount() {
        // Suspends GetDotNetCount() to allow the caller (the web server) to accept another request, rather than blocking on this one
        var html = await s_httpsClient.GetStringAsync(URL);
        return Regex.Matches(html, @"\.NET").Count;
    }
    // </ExtractDataFromNetwork>

    static async Task Main()  {
        Console.WriteLine("Application started.");

        Console.WriteLine("Counting '.NET' phrase in websites...");
        int total = 0;
        foreach (string url in s_urlList) {
            var result = await GetDotNetCount(url);
            Console.WriteLine($"{url}: {result}");
            total += result;
        }
        Console.WriteLine("Total: " + total);

        Console.WriteLine("Retrieving User objects with list of IDs...");
        IEnumerable<int> ids = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        var users = await GetUsersAsync(ids);
        foreach (User? user in users) {
            Console.WriteLine($"{user?.id}: isEnabled={user.isEnabled}");
        }

        Console.WriteLine("Application finished.");
    }
}