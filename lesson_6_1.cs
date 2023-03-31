	int count = 0;
        
        int Numbers(int count1)
        {
            Console.WriteLine("Enter number: ");
            int a = int.Parse(Console.ReadLine()!);
            if (a > 0)
            count = count + 1;
            Console.WriteLine("The amount of numbers that's bigger than zero: " +count);
            Console.WriteLine("Thejwiuwifwi: " +count);
            return Numbers(count1);
        }
        
        Numbers(count);
