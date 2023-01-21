using System;
namespace PCd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Test1();
            Test2();
            Test3();
            Test4(); 
            Test5();
            Test6();
            Test7();
            Test10();
        }

        static void Test1()
        {
            /* Test: poprawne tworzenie obiektu Person, dane poprawne */
            try
            {
                Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Test2()
        {
            /* Test: poprawne tworzenie obiektu Person, 
   błędne imię lub nazwisko, pierwsza duża pozostałe małe */
            try
            {
                Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Test3()
        {
            /* Test: poprawne tworzenie obiektu Person, 
   błędne imię lub nazwisko, niewłaściwy wiek */
            try
            {
                Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: -18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Test4()
        {
            /* Test: modyfikacja obiektu */
            try
            {
                Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
                p.modifyFirstName(" Ja n");
                p.modifyFamilyName("kolenda ");
                p.modifyAge(35);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Test5()
        {
            /* Test: tworzenie obiektu Child */
            try
            {
                Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
                Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
                Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 10,
                                    mother: m, father: o);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Test6()
        {
            /* Test: tworzenie obiektu Child 
   brak rodziców */
            try
            {
                Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14);

                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Test7()
        {
            /* Test: tworzenie obiektu Child 
   brak jednego z rodziców */
            try
            {
                Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
                Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
                Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, father: o);
                Console.WriteLine(d);
                d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, mother: m);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Test10()
        {
            /* Test: poprawne tworzenie obiektu Person,
   błędne imię lub nazwisko, spacje w środku*/
            try
            {
                Person p = new Person(familyName: "Molen  da", firstName: "Krzysztof", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       
    }
}