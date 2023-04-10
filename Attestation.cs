using System;

public class Project
{
    public static void Main(string[] args)
    {
    	// task 66
    	
    	int C = 12, D = 50;
    	
    	Console.Write("Число M = " +C+ "\n Число N = " +D+ "\n");
        
        void Summary(int M, int N)
        {
            int sum = 0;
            for (int i = M; i < N; i++ )
                sum += i;
            Console.WriteLine("Сумма всех элементов от M до N = " +sum);
        }
        
        Summary(C, D);
    
    
    //--------------------------------------------------------------
    	Console.WriteLine();
    	// task 68
    
    	int AckermanFunc(int n, int m)
        {
            if (n == 0) return m + 1;
            if (n != 0 && m == 0) return AckermanFunc(n - 1, 1);
            if (n > 0 && m > 0) return AckermanFunc(n - 1, AckermanFunc(n, m - 1));
            return AckermanFunc(n, m);
        }
        
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine(AckermanFunc(a, b));
    //--------------------------------------------------------------
    
    	Console.WriteLine();
    
    	// task 64
    	
        int N = 18;
        
        int thing(int i_1)
        {
            if (i_1 > 0)
                Console.Write(i_1+ " ");
            i_1--;
            return thing(i_1);
        }
        
        thing(N);
        
    }
}
