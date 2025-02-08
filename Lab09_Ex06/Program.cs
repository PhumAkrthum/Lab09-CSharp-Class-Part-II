// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Circle.PrintCircleArea(100);

class Circle
{
  const double PI =3.14159;
  public static void PrintCircleArea(double radius)
{
     System.Console.WriteLine($"Reduis = {radius},Area = {PI*radius*radius}");
}

}