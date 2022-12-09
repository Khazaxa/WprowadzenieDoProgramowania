using System;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
                //string wejscie = Console.ReadLine();
                //int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod

            
            var Dane = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int a = short.Parse(Dane[0]);
            int b = short.Parse(Dane[1]);
            int c = short.Parse(Dane[2]);

            int zakres = (b-a)-1;           
            int pierw3 = a+3*c;
            int ost2 = b-2*c;
            int ost1 = b-c;

            
            

            
            if(c<=0){
                Console.WriteLine("ERROR");
            }
            else{
                int wieksza = 0;
                if(a>b){
                    wieksza = a;
                }
                else if(b>a){
                    wieksza = b;
                }


                if(c>wieksza){
                    Console.WriteLine("empty");
                }
                else{   
                    //dla a<b 
                    //dziala                
                    if(a<b){
                        if(a==0 && b==1){
                            Console.Write("empty");
                            return;
                        }
                        if(a<0){
                             for(int i = a; i<(b-1); i++){
                                a++;
                                if(a%c==0){
                                    if(a<(b-c)){
                                        Console.Write($"{a}, ");
                                    }
                                    else if(a>=(b-c)){
                                        Console.Write($"{a}");
                                    }                               
                                }   
                            }
                        }
                        if(zakres>10){
                            //dziala
                            for(int i=a; i<(b-1); i++){
                                a++;
                                if(a<=pierw3){
                                    if(a%c==0){
                                        if(a<ost2){
                                            Console.Write($"{a}, ");
                                        }                           
                                    }
                                }                           
                            }
                            
                            a = short.Parse(Dane[0]);
                            Console.Write("..., ");

                            
                            for(int i=a; i<(b-1); i++){
                                a++;
                                if(a%c==0){
                                    if(a>=ost2 && a<ost1){
                                        Console.Write($"{a}, ");
                                    }
                                    else if(a>=ost1){
                                        break;
                                    }                                
                                }                                                                                                                                                                                                                                                 
                            }
                            Console.Write($"{a}");
                        }
                        else if(zakres==10){
                            for(int i = a; i<(b-1); i++){
                                a++;
                                if(a%c==0){
                                    if(a<(b-c)){
                                        Console.Write($"{a}, ");
                                    }
                                    else if(a>=(b-c)){
                                        Console.Write($"{a}");
                                    }                               
                                }   
                            }
                        }
                        else{
                            for(int i = a; i<(b-1); i++){
                                a++;
                                if(a%c==0){
                                    if(a<(b-3)){
                                        Console.Write($"{a}, ");
                                    }
                                    else if(a>=(b-c)){
                                        Console.Write($"{a}");
                                    }                               
                                }   
                            }
                        }
                    }
                    else if(a>b){

                    int Bzakres = (a-b)-1;
                    int Bpierw3 = b+3*c;
                    int Bost1 = a-c;
                    
                    if(b<0){
                        for(int i = b; i<(a-1); i++){
                            b++;
                            if(b<Bost1)
                            {
                                if(b%c==0){
                                    Console.Write($"{b}, ");
                                }
                            }                           
                       }     
                        b= short.Parse(Dane[1]);
                        for(int i=b; i<(a-1); i++)
                        {
                            b++;
                            if(b>=a-c){
                                if(b%c==0){                                                              
                                    Console.Write($"{b}");                                   
                                }                                
                            }                             
                        }
                      return;      
                    }

                    if(Bzakres<=10){
                       for(int i = b; i<(a-1); i++){
                            b++;
                            if(b<Bost1)
                            {
                                if(b%c==0){
                                    Console.Write($"{b}, ");
                                }
                            }                           
                       }     
                        b= short.Parse(Dane[1]);
                        for(int i=b; i<(a-1); i++)
                        {
                            b++;
                            if(b>=a-c){
                                if(b%c==0){                                                              
                                    Console.Write($"{b}");                                   
                                }                                
                            }                             
                        }    
                    }
                    if(Bzakres>10){
                        for(int i = b; i<(a-1); i++){
                            b++;
                            if(b%c==0){
                                if(b<=Bpierw3){
                                    Console.Write($"{b}, ");
                                }
                                                             
                            }  
                             
                        }
                        Console.Write("..., ");
                        b= short.Parse(Dane[1]);

                        for(int i=b; i<(a-1); i++)
                        {
                            b++;
                            if(b>=a-2*c && b<a-c){
                                if(b%c==0){                                                              
                                    Console.Write($"{b}, ");
                                    
                                } 
                                
                            }
                              
                        }

                        b= short.Parse(Dane[1]);
                        for(int i=b; i<(a-1); i++)
                        {
                            b++;
                            if(b>=a-c){
                                if(b%c==0){                                                              
                                    Console.Write($"{b}");
                                    
                                } 
                                
                            }
                              
                        }
                        
                    }    
                    
                    
                    }
                    else{
                        for(int i = b; i<(a-1); i++){
                            b++;
                            if(b%c==0){
                                if(b<(a-c)){
                                    Console.Write($"{b}, ");
                                }
                                else if(b>=(a-c)){
                                    Console.Write($"{b}");
                                }                               
                            }   
                        }
                    }
                }  
            }                              
        }
    }
}

