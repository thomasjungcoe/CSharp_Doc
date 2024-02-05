// Creating obj for Point
var p1 = new Point(0, 0);
var p2 = new Point(10, 20);

// Running PointFactory
var factory = new PointFactory(10);
foreach (var point in factory.CreatePoints())
{
    Console.WriteLine($"({point.X}, {point.Y})");
}

// Type Param (Generics) -> constructed type
var pair = new Pair<int, string>(1,"two");
int i = pair.First;
string s = pair.Second;

// Base Class
Point a = new(10,20);
Point b = new Point3D(10,20,30);

// Inheritance
EditBox editBox = new();
IControl control = editBox;
IDataBound dataBound = editBox;

// Enum
var turnip = SomeRootVegetable.Turnip;

var spring = Seasons.Spring;
var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
var theYear = Seasons.All;