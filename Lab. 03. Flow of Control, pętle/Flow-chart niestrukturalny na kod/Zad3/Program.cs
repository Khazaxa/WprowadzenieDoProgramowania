using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            // Twój kod
            
    
    
            var Data = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int x = int.Parse(Data[0]);
            int y = int.Parse(Data[1]);
            int z = int.Parse(Data[2]);

            if(x>0){
            for(int i = x; i>0; i--){

                if(y>0){
                        x--;
                        y--;
                        Console.Write("C");
                    }
                    else{
                            x=0;
                            if(y<=0) {
                                Console.Write("D");
                                
                            
                            
                        
                        
                            if(z>0){                      
                                Console.Write("");
                            }   
                            else{                 
                                
                                    Console.Write("G");
                                    Console.Write("");
                                      
                                
                            }
                            return;
                            }
                            return;
                        }
                        
            }
            Console.Write("E");
            Console.Write("G");
            }
            else if(x==0 && y==0 && z==0){
                Console.Write("E");
                Console.Write("G");
            }
            else if(x<0){
            for(int a = x; a<0; a++){

                if(a<0){
                    if(y>0){
                        x--;
                        y--;
                        Console.Write("C");
                    }
                    else{
                            x=0;
                            if(y<0) {
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
                    
                        
                }
                
                
            }
            Console.Write("E");
            Console.Write("G");
            }
        }
    }
}