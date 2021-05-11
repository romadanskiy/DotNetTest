using System;
using System.Collections;
using System.Collections.Generic;

namespace DotNetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ExampleCollection();
            collection.AddItem("foo");
            collection.AddItem("bar");
            collection.AddItem("a");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}