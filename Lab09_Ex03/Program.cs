// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Person.name = "Phum Akrthum"; 
System.Console.WriteLine(Person.Getname());
var student = new Student();
Student.name = "Phum Akrthum";
System.Console.WriteLine(student.Getname());

static class Person
{
    static public string? name;
    static public string Getname()
    {
        return $"Hello from {name}"; 
    }
}

class Student
{
    public static string? name; 
    public string Getname()
    {
        return $"Hello from {name}"; 
    }
}
