﻿

using System;
using System.Reflection;

class Task1
{
    static void Main(string[] args)
    {


        Assembly assembly = Assembly.LoadFrom(@"C:\Wipro\Dotnet\Dotnet pratice\Day15_Task1\Day15_Task1\bin\Debug\net8.0\Day15.dll");

        Type[] types = assembly.GetTypes();


        foreach (Type type in types)
        {
            Console.WriteLine($"Type Name: {type.FullName}");


            if (type.BaseType != null)
            {
                Console.WriteLine($"  Base Type: {type.BaseType.FullName}");
            }


            GetInterfaces(type);

            Console.WriteLine();
        }
    }

    public static void GetInterfaces(Type type)
    {
        if (type != null)
        {

            Type[] interfaces = type.GetInterfaces();
            if (interfaces.Length > 0)
            {
                Console.WriteLine("  Implemented Interfaces:");
                foreach (Type iface in interfaces)
                {
                    Console.WriteLine($"    - {iface.FullName}");

                    MethodInfo[] methods = iface.GetMethods();
                    foreach (MethodInfo method in methods)
                    {
                        Console.WriteLine($"      Method Name: {method.Name}");
                        ParameterInfo[] parameters = method.GetParameters();
                        foreach (ParameterInfo param in parameters)
                        {
                            Console.WriteLine($" Parameter Name: {param.Name}, Type: {param.ParameterType.Name}");
                        }
                    }
                }
            }
        }
    }

}

















