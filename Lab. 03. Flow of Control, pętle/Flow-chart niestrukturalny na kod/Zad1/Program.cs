using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
    
            var Data = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int x = int.Parse(Data[0]);
            int y = int.Parse(Data[1]);
            int z = int.Parse(Data[2]);

            warunekx:
            if( x>0){
                if(y>0){
                    x--;
                    y--;
                    Console.Write("C");
                    goto warunekx;
                }
                else{
                    Console.Write("D");
                    if(z>0){                      
                        Console.Write("");
                    }   
                    else{                       
                        Console.Write("G");
                        Console.Write("");
                    }
                }
            }
            else{
                Console.Write("E");
                Console.Write("G");
            }

            
        }
    }
}