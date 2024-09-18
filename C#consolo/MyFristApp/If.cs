

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class If
{
    public static void IfElsa(int number)
    {
        //int number = 5;

      if(number > 0)
      {
        Console.WriteLine( "The number is positive");
      }
      else if (number < 0)
      {
        Console.WriteLine("The number is negative");
      }

      else
      {
        Console.WriteLine("The number is 0");
      }
    }
    public static void Health( int HP)
    {
        if (HP > 75)
        {
            Console.WriteLine(" in greate condition ");
        }
        else if ( HP > 50)
        {
            Console.WriteLine( "in good condition  ");
        }
        else if (HP > 1 )
       {
         Console.WriteLine( " The player is in danger");
       }

       else 
       {
         Console.WriteLine( " game over");
       }
    }

}
