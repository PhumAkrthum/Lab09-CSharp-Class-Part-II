// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Person.name="Phum Akrthum";
System.Console.WriteLine(Person.Getname());

static class Person
{
     static public  string? name;
     static public string Getname()
    {
        return $"Hello from {name}"; 
    }
}