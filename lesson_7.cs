using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    	// task 47
    	
        int m = 5;
        int n = 6;
        int[,] array = new int[m, n];
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                array[i, j] = new Random().Next(1, 11);
        }
        
        //---------------------------------------------
        
        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                 for (int j = 0; j < matrix.GetLength(1); j++)
            		Console.Write($"{matrix[i,j]} \t");
            	Console.WriteLine();
            }
            
        }
        
        //--------------------------
        
        Console.WriteLine("Матрица 1: ");
        PrintMatrix(array);
        Console.WriteLine();
        
        //----------------------------
        
        // task 50
        
        void Position (int[,] matrix, int m1, int n1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (m1 == i && n1 == j)
                        Console.WriteLine(matrix[m1,n1]);
                }
            }
            
            if (m1 > matrix.GetLength(0) || m1 < matrix.GetLength(0) || n1 > matrix.GetLength(1) || n1 < matrix.GetLength(1)) 
                Console.WriteLine("Нет такой позиции");
        }
        
        //-------------------
        
        Position(array, 4, 4);
        Console.WriteLine();
        Position(array, 7, 5);
        
        //-------------------
        
        // task 52
        
        void TwoSumms(int[,] matrix)
        {
        int sum_1 = 0, sum_2 = 0;
       
            for (int t_1 = 0; t_1 < matrix.GetLength(0); t_1++)
            {
            	sum_1 = sum_1 + t_1;
                for (int t_2 = 0; t_2 < matrix.GetLength(1); t_2++)
                {
                    sum_2 = sum_2 + t_2;
                }
            }
            Console.WriteLine("Сумма элементов m: " +sum_1);
            Console.WriteLine("Сумма элементов n: " +sum_2);
        }
        
        //----------------
        
        TwoSumms(array);
        
    }
}
