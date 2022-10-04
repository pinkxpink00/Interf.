using System;
using System.Security.Cryptography;

namespace MyNamespace;
public interface IComparable
{
    int CompareTo(object? o);
}
class Program 
{
    static void Main()
    {
      CW cW = new CW();
        CW.P1();

        Person person = new Person();
        person.CompareTo();
    }
   
}
class CW : Arraus
{
    Arraus arraus = new Arraus();
    public static void AR()
    {
        Arraus.P1();
    }
}
class Arraus
{
    public static void P1()
    {
        int[] numbers = new int[] { 1, 4, 5, 7, 3, 2, 6};
        Array.Sort(numbers);

        foreach(int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
class Person :IComparable
{
    public string Name { get; }
    public int Age { get; set; }
    public Person (string Name,int Age)
    {
        Name = Name;
        Age = Age;
    }
    public int CompareTo(object? o)
    {
        if (o is Person person)
            return Name.CompareTo(person.Name);
        else
            throw new ArgumentException("Error");
    }

}