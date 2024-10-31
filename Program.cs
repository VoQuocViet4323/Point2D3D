public class Program
{
    private static void Main(string[] args)
    {
        // Kiểm thử lớp Point2D
        Point2D point2D = new Point2D(2.5f, 3.5f);
        Console.WriteLine("Point2D:");
        Console.WriteLine($"ToString: {point2D.ToString()}");
        
        // Kiểm thử lớp Point3D
        Point3D point3D = new Point3D(1.5f, 2.5f, 3.5f);
        Console.WriteLine("\nPoint3D:");
        Console.WriteLine($"ToString: {point3D.ToString()}"); 
        
        point3D.SetXYZ(4.5f, 5.5f, 6.5f);
        Console.WriteLine($"Updated Point3D: {point3D.ToString()}");
    }
}