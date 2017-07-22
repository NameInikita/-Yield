using System;
using System.Collections;

namespace ConsoleApplication1
{
    class User
    {
        public static IEnumerable Method()
        {
          //while (true)//бесконечно. MoveNext безусловно возвращает true 
            yield return "Hello";
          //yield break;// возвращается пустая коллекция(пустой итератор)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (var elem in User.Method())
                Console.WriteLine(elem);

            Console.WriteLine(new string('=',5));

            foreach (string elem in User.Method())
                Console.WriteLine(elem);

            Console.ReadKey();
        }
    }
}
