

class Loops
{
    public static void Forloop()
    {
       for( int i = 1 ; i <= 10; i ++)
       {
            Console.WriteLine(" Interation : " + i);
       }
    }
    public static void Evenloop()
    {
        for( int i = 1; i<=20; i ++ )
        {
            if( i % 2 == 0 )
            {
                 Console.WriteLine(i);
            }
           
        }
    }
    public static void whileloop()
    {
        int health = 100;
        while(health > 0)
        {
            Console.WriteLine(" player is alive with health :" + health );
            health -= 10;
        }
    }
    public static void Pool()
    {
         int water = 0;
         while(water > 0)
         {
            Console.WriteLine( " water level :" + water) ;
            water +=10;
         }
    }
}