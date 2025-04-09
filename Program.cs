using SummerNummerne;
using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        var myObj = new MatematiskClass();

        Console.Write("Indtast et tal: ");
        int input = Convert.ToInt32(Console.ReadLine());

        myObj.SumBeregner(input);

        Console.WriteLine("Summen af de to tal er: " + myObj.SumBeregner(input));
    }


}

