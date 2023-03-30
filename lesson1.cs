using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число a: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите число b: ");
        int b = int.Parse(Console.ReadLine()!);
        
        if (a > b)
            Console.WriteLine("A больше чем b")
;
        else if (a < b)
            Console.WriteLine("B больше чем a")
;        
        else
            Console.WriteLine("Числа одинаковы");
    
       // -------------------------------------------
       
        Console.WriteLine();
        Console.WriteLine("Введите 3 числа: ");
       
        int max = 0;
        int c = int.Parse(Console.ReadLine()!);
        Console.WriteLine(", ");
        int d = int.Parse(Console.ReadLine()!);
        Console.WriteLine(", ");
        int h = int.Parse(Console.ReadLine()!);
        
        if (c > d)
            max = c;
        else if (d > c)
            max = d;
            
        if (max < h)
            max = h;
        
        Console.WriteLine("Максимальное значение трех чисел: " +max);
       
        // -------------------------------------------
       
        Console.WriteLine();
        Console.WriteLine("Введите еще одно число: ");
        int g = int.Parse(Console.ReadLine()!);
       
        if (g % 2 == 0)
             Console.WriteLine("Число четное");
        else
             Console.WriteLine("Число нечетное");
            
       // -------------------------------------------
       
       Console.WriteLine();
       Console.WriteLine("Введите еще одно число снова: ");
       int N = int.Parse(Console.ReadLine()!);
       
       for (int k = 0; k < N; k++)
       {
           if (k % 2 == 0)
           {
               Console.Write(k);
               Console.Write(" ");
           }
       }
       
       Console.WriteLine(N);

        }
