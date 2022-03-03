using System;
using System.Collections.Generic;
using System.Linq;
using Interoperability.FSharp;
public class Program
{
    public static void Main(string[] args)
        {
            Console.WriteLine(Testirovanie.getShapeWidth(Testirovanie.Shape.NewRectangle(12, 10)));
        }
}