using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine()!);
        int m = 0;
        while (n > 0)
        {
            m = m*10+n%10;
            n /= 10;
        }
    
        Console.WriteLine(m == n);
// -----------------------------------------------------
	Console.WriteLine();
	
	Console.Write("Enter first coordinates: ");
        int q1 = int.Parse(Console.ReadLine()!);
        int q2 = int.Parse(Console.ReadLine()!);
        int q3 = int.Parse(Console.ReadLine()!);
        
        Console.Write("Enter second coordinates: ");
        int q4 = int.Parse(Console.ReadLine()!);
        int q5 = int.Parse(Console.ReadLine()!);
        int q6 = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine();
        
        int P1 = (q1 - q4)*(q1 - q4) + (q2 - q5)*(q2 - q5) + (q3 - q6)*(q3 - q6);
        
        Console.WriteLine("The distance between coordinates is " +P1);
            
// -----------------------------------------------------

	Console.WriteLine();
	
	Console.Write("Enter another number: ");
        int N = int.Parse(Console.ReadLine()!);
        int n1 = 2;
        
        while (n1*n1*n1 < N)
        {
            Console.WriteLine(n1*n1*n1);
            n1++;
        }

	
    }
}
