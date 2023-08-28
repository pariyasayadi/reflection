using System;
using System.Reflection;

class MyClass
{
    public void MyMethod()
    {
        Console.WriteLine("Hello from MyMethod!");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(MyClass);
        object instance = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod("MyMethod");
        method.Invoke(instance, null);
    }
}