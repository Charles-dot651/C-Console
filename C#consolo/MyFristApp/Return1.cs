

class Return1
{
    public static void PrintSpuare(int number)
    {
        Console.WriteLine(number * number);
    }
     public static void CheckEvenOdd(int number)
     {
        if(number % 2 == 0)
        {
            Console.WriteLine(number + "is even");
        }
        else
        {
            Console.WriteLine(number + "is odd");
        }


    }   
    public static int AddNumber(int num1, int num2)
    {
        return num1 + num2;
    }
    public static void Forloop()
    {
       for( int i = 1 ; i <= 10; i ++)
       {
            Console.WriteLine(" Interation : " + i);
            for(int j = 0; j <= 10; j++);
            {
                Console.WriteLine(" Interation : j " + j );
            }
            for(int k = 0; k <= 10; k++);
            {
                Console.WriteLine(" Interation : k " + k );
            }
       }
    }
}
