using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Введите числа A и B: ");
        int A = int.Parse(Console.ReadLine()!);
        int B = int.Parse(Console.ReadLine()!);
        int result = B*(A * A);
        Console.WriteLine("Результат возведения числа A в степень B: " +result);
        
// ------------------------------------------------------------

	Console.WriteLine ("Введите цифру: ");
        int n1 = int.Parse(Console.ReadLine()!);
        int sum = 0;
        
        while (n1 != 0)
        {
            if ((n1 % 10) % 2 == 0)
                sum += n1 % 10;  
            n1 /= 10;
        }
        
        Console.WriteLine(sum);
    }
}
