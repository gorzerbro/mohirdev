using System;

class Program
{
    static void Main()
    {
        Console.Write("Radiusni kiriting: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double S = Math.PI * Math.Pow(radius, 2);
        double L = 2 * Math.PI * radius;

        Console.WriteLine($"S = {S}, L = {L}");
    }
}
