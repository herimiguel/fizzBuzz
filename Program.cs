using System;

namespace C_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<= 255; i++){
                Console.WriteLine(i);
            }

            for(int x = 1; x <= 100; x++){
                if( ((x % 3) == 0) && ((x % 5) == 0) )
                {
                   Console.WriteLine("FizzBuzz");
                }
                // else if( x % 15 == 0){
                //     Console.WriteLine("FizzBuzz");
                // }

                else if((x % 3) == 0){
                    Console.WriteLine("Fizz");
                }
                else if((x % 5)== 0){
                    Console.WriteLine("Buzz");
                }

            }
        
        }

    }
}
