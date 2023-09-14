using System;

class Program
{
    static void Main()
    {
        Person person = new Person("Иван", "Петров", 30);
        person.DisplayInfo();
        person.Age = 22;
        person.DisplayInfo();
        Console.ReadLine();
    }
}

class Person
{
    private string firstName;
    private string lastName;
    private int age;
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {firstName}");
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine();
    }
}