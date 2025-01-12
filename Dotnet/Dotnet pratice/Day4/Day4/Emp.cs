﻿using System;

class Employee
{

    public string Name { get; set; }
    public string Title { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public decimal BaseSalary { get; set; }


    public Employee(string name, string title, string gender, int age, decimal baseSalary)
    {
        Name = name;
        Title = title;
        Gender = gender;
        Age = age;
        BaseSalary = baseSalary;
    }

    public virtual decimal CalculateBonus()
    {
        return 0;
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Base Salary: {BaseSalary}");
    }
}

class Manager : Employee
{

    public Manager(string name, string title, string gender, int age, decimal baseSalary)
        : base(name, title, gender, age, baseSalary)
    {
    }

    public override decimal CalculateBonus()
    {
        return 0.1m * BaseSalary;
    }


    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Manager Bonus: {CalculateBonus()}");
    }
}

class DeliveryPartner : Employee
{

    public DeliveryPartner(string name, string title, string gender, int age, decimal baseSalary)
        : base(name, title, gender, age, baseSalary)
    {
    }


    public override decimal CalculateBonus()
    {
        return 0.2m * BaseSalary;
    }


    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Delivery Partner Bonus:{CalculateBonus()}");
    }
}

class Emp
{
    static void Main()
    {
        var manager = new Manager("yashasree", "Manager", "Female", 25, 80000);
        var deliveryPartner = new DeliveryPartner("Sree", "Delivery Partner", "Female", 28, 60000);

        // Console.WriteLine("Manager Details:");
        manager.DisplayDetails();

        // Console.WriteLine("\nDelivery Partner Details:");
        deliveryPartner.DisplayDetails();
    }
}
