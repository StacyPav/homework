using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] three = new int[] {};
        for (int i = 0; i < three.Length; i++)
                three[i] = new Random().Next(100, 999);
        int count1 = 0;
        
        Console.Write("Массив: ");
        Console.WriteLine($"[{string.Join(", ", three)}]"); //
        
        for (int t = 0; t < three.Length; t++)
        {
            if (three[t] % 2 == 0)
                count1++;
        }
        
        Console.WriteLine ("Количество четных чисел в массиве: " +count1);
        
        //------------------------------------------------------
        Console.WriteLine();
        
        float[] what = new float[] { 1.23213f, 1.5325f, -1.72737f, 2.21347f, 1.273f };  
                
        Console.Write("Массив: ");
        Console.WriteLine($"[{string.Join(", ", what)}]"); //  
                
        float max = what[0];
        float min = what[4];
        for (int k = 0; k < what.Length; k++)
        {
            if (what[k] > max)
                max = what[k];
        }
        for (int r = 0; r < what.Length; r++)
        {
            if (what[r] < min)
                min = what[r];
        }

        Console.Write ("Разница между max и min: ");
        Console.WriteLine(max - min);
    }
}
