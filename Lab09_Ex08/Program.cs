// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Circle.PrintCircleArea(100);
   class Circle
   {
    const double PI = 3.14159;
    public static void PrintCircleArea(double radius)
    {
        const double PI = 3.14159265359; 
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
     }
   }
