using EmployeeAndManager;

internal class Program
{
  
    private static void Main(string[] args)
    {
        PrintName(new Manager("Giannis"));
        PrintName(new Employee("Basilis"));
        Console.ReadLine();
    }

    public static void PrintName(IPerson person)
    {
        Console.WriteLine($"Hi i am {person.Name}" );
    }
}