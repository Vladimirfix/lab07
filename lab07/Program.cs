using System;
using System.Collections.Generic;

struct Engineer
{
    public string LastName;
    public int YearOfBirth;
    public string Position;
    public decimal Salary;
    public string Education;

    public Engineer(string lastName, int yearOfBirth, string position, decimal salary, string education)
    {
        LastName = lastName;
        YearOfBirth = yearOfBirth;
        Position = position;
        Salary = salary;
        Education = education;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Engineer> engineers = new List<Engineer>();
        Console.WriteLine("Введите количество работников-инженеров:");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите данные для инженера #{i + 1}:");

            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();

            Console.Write("Год рождения: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Должность: ");
            string position = Console.ReadLine();

            Console.Write("Зарплата: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Образование: ");
            string education = Console.ReadLine();

            engineers.Add(new Engineer(lastName, yearOfBirth, position, salary, education));
        }

        Console.WriteLine("\nСведения о работниках-инженерах:");
        foreach (var engineer in engineers)
        {
            Console.WriteLine($"Фамилия: {engineer.LastName}, Год рождения: {engineer.YearOfBirth}, " +
                              $"Должность: {engineer.Position}, Зарплата: {engineer.Salary}, " +
                              $"Образование: {engineer.Education}");
        }
    }
}
