
public class Program
{
    public static void Main()
    {
        // Inheritance example
        var item = new WorkItem("Fix Bugs", "Fix all bugs in my code", new TimeSpan(3, 4, 0, 0));
        var change  = new ChangeRequest("Change Design", "Change the design of the project", new TimeSpan(4, 0, 0, 0), 1);

        Console.WriteLine(item.ToString());

        change.Update("Change the Design", new TimeSpan(4, 0, 0, 0));
        Console.WriteLine(change.ToString());

        // Polymorphism example
        var shapes = new List<Shape> {
            new Rectangle(),
            new Circle(),
            new Triangle()
        };

        foreach (var shape in shapes) {
            shape.Draw();
        }
    }
}
