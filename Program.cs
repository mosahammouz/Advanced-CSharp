using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp6;

class Program
{
    delegate void ProgressChanged(int percentage);

    static void Main()
    {
        Person nick = new Person("mousa's nick", new DateOnly(2004,10,1));
        Person nick2 = new Person("mousa's nick", new DateOnly(2000,1,1));
        Console.WriteLine(nick == nick2);

        var leg = nick with { DateOfBirth = new DateOnly(2000,1,1) };
        Console.WriteLine(leg);
        Console.WriteLine(leg == nick2 );
        

        /*  Console.WriteLine("Hello, World!");
          Action<string, int> D = Test;  // D is a ref. on Test() ,, so u can treat D as a Test like a nickname man :))
          D("Mousa", 22);
          Download(ShowProgress);
          Do(Squared);
          NamesWithO(WithOs);

          Account a = new Account();
          List<int> data = new() { 1, 6, 3, 5 };
         a.Sort(data,l=>l.OrderBy(item=>item).ToList());// (list , operation )

         Func<int, int> triple = x => x * x * x;
         Func<int,int> doubled = x => x * x;
         Func<string,string> capitalize = str => str.ToUpper();
         Console.WriteLine(Doo(triple));
         Console.WriteLine(Foo(capitalize));*/
        /*  Stock s = new Stock();
          s.AddKV("FR",222);
          s.AddKV("Mousa",900);
          s.CancelAnItem("AAPL");
          s.ListItems();
          s.EditK("Mousa","Ahmad");
          s.ListItems();
          s.Search("FR");
          Console.WriteLine(s.BiggestVal());
          Console.WriteLine(s.GetQuantity("FR"));*/
    }

    static string Foo(Func<string,string> operation)
    {
        return operation("Mousa Hammouz");
    }

    static int Doo(Func<int, int> operation)
    {
        return operation(2);
    }

    static List<string> WithOs(List<string> strs)
    {
      return  strs.Where(str => str.Contains("o")).ToList();
    }
  
    static void NamesWithO(Func<List<string>, List<string>> operation)// HOF  
    {
        List<string> l = new List<string>() { "mousa", "ahmad", "soha" };
        List<string> result = operation(l);

        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
    }

    static void Test(string name = "Unknown", int age = 0)
    {
        Console.WriteLine($"Hi {name} and ur age is {age}, test for Delegate !");
    }

    static void ShowProgress(int percentage)
    {
        Console.WriteLine($"Downloaded {percentage}%");
    }

    static void Download(ProgressChanged callback)
    {
        for (int i = 0; i < 100; i += 25)
        {
            callback(i);
        }
    }

    static List<int> Doubled(List<int> l)
    {
        return l.Select(x => x * 2).ToList();
    }

    static List<int> Squared(List<int> l)
    {
        return l.Select(x => x * x).ToList();
    }

   
    static void Do(Func<List<int>, List<int>> operation)  // // this is a HOF cuz it takes a Func<> or Action<> as a parameter
    {
        List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        List<int> res = operation(myList);

        foreach (var i in res)
        {
            Console.Write(i+" ");
        }

        Console.WriteLine();
    }
}