using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ASS06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            //    Console.WriteLine("Enter coordinates for Point 1:");
            //    Point3D p1 = ReadPoint();
            //    Console.WriteLine("Enter coordinates for Point 2:");
            //    Point3D p2 = ReadPoint();

            //    Console.WriteLine(p1.ToString());
            //    Console.WriteLine(p2.ToString());
            //    Console.WriteLine($"Are P1 and P2 equal? {p1.Equals(p2)}");

            //    Point3D[] points = { new Point3D(5, 2, 1), new Point3D(1, 3, 4), new Point3D(3, 1, 7) };
            //    Array.Sort(points);
            //    Console.WriteLine("Sorted Points:");
            //    foreach (var point in points) Console.WriteLine(point);

            //    Point3D clone = (Point3D)p1.Clone();
            //    Console.WriteLine($"Cloned Point: {clone}");
            //
            //    private static Point3D ReadPoint()
            //{
            //    int x = ReadInt("X");
            //    int y = ReadInt("Y");
            //    int z = ReadInt("Z");
            //    return new Point3D(x, y, z);
            //}

            //private static int ReadInt(string name)
            //{
            //    int value;
            //    Console.Write($"Enter {name}: ");
            //    while (!int.TryParse(Console.ReadLine(), out value))
            //    {
            //        Console.WriteLine("Invalid input. Try again.");
            //    }
            //    return value; 
            #endregion

            #region part2
            //Console.WriteLine($"Add: {Add(10, 5)}");
            //Console.WriteLine($"Subtract: {Subtract(10, 5)}");
            //Console.WriteLine($"Multiply: {Multiply(10, 5)}");
            //Console.WriteLine($"Divide: {Divide(10, 5)}"); 
            #endregion

            #region part3
            //Console.WriteLine("Enter user type (Regular, Premium, Guest):");
            //string userType = Console.ReadLine();

            //User user = userType switch
            //{
            //    "Regular" => new RegularUser { Name = "Regular User" },
            //    "Premium" => new PremiumUser { Name = "Premium User" },
            //    "Guest" => new GuestUser { Name = "Guest User" },
            //    _ => throw new ArgumentException("Invalid user type.")
            //};

            //Console.WriteLine("Enter product price:");
            //decimal price = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter product quantity:");
            //int quantity = int.Parse(Console.ReadLine());

            //var discount = user.GetDiscount();
            //decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            //decimal finalPrice = price * quantity - discountAmount;

            //Console.WriteLine($"User: {user.Name}");
            //Console.WriteLine($"Discount Applied: {discount?.Name ?? "No Discount"}");
            //Console.WriteLine($"Total Discount: {discountAmount:C}");
            //Console.WriteLine($"Final Price: {finalPrice:C}");

            #endregion
        }



    }

}

