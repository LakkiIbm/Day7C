using System;
public class InvalidAgeException : Exception
{
    public InvalidAgeException(String msg) : base(msg)
    {
        Console.WriteLine("Invalid Age exception");
    }
}
public class TestUserDefinedException
{
    static void validate(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Sorry, Age must be greater than 18");
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the age: ");
        int age = int.Parse(Console.ReadLine());
        try
        {
            validate(age);
        }
        catch (InvalidAgeException e) { Console.WriteLine(e); }
        Console.WriteLine("Rest of the code");
        Console.ReadLine();
    }
}