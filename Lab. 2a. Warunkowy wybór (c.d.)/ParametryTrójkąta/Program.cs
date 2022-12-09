using System;
using System.Globalization;

namespace Zadanie_ParametryTrojkata
{
  class Program
  {
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        
        var Dane = Console.ReadLine().Trim().Split("; ", StringSplitOptions.RemoveEmptyEntries);
        double a = double.Parse(Dane[0]);
        double b = double.Parse(Dane[1]);
        double c = double.Parse(Dane[2]);

        //obsługa błędów
        if(a<=0 || b<=0 || c<=0) {
            Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
            return;
        }
        else if (a+b<c || a+c<b || b+c<a) {
            Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
            return;
        }
        else
        {
            double Heron = (a+b+c)/2;
            double obwod = Math.Round(a+b+c, 2) ;
            double pole = Math.Round(Math.Sqrt(Heron*(Heron-a)*(Heron-b)*(Heron-c)), 2);
            string typ = ""; 

            //pętla wybierająca typ
            if(a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a){
                typ= "prostokątny";
            }
            else if(a*a + b*b < c*c || a*a + c*c < b*b || b*b + c*c < a*a) {
                typ="rozwartokątny";
            }
            else if(a*a + b*b > c*c || a*a + c*c > b*b || b*b + c*c > a*a){
                typ="ostrokątny";
            }
            else {
                return;
            }

            //pętla przypisująca .00
            if(obwod == (int)obwod){
                Console.WriteLine($"obwód = {obwod}"+".00");
            }
            else{
                Console.WriteLine($"obwód = {obwod}");
            }
            if(pole==(int)pole){
                Console.WriteLine($"pole = {pole}"+".00");
            }
            else{
                Console.WriteLine($"pole = {pole}");
            }
            
            Console.WriteLine($"trójkąt jest {typ}");
        }

        //pętla sprawdzająca zaleznosci bokow
        if(a==b && b==a && a==c && c==a && b==c && c==b){
            Console.WriteLine("trójkąt równoboczny");
        }
        else if(a==b || b==a || a==c || c==a || b==c || c==b){
            Console.WriteLine("trójkąt równoramienny");
        }
        else{
            return;
        }
    }
  }
}