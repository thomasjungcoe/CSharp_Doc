public class Point3D : Point3D 
{
    public int Z { get; set; }

    public Point3D(int x, int y, int z) : base(x, y) => Z = z;
}
