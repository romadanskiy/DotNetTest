using System;
using System.Collections;
using System.Collections.Generic;

namespace DotNetTest
{
    class Program
    {
        public static ExampleCollection AlphabeticalOrderSort(ExampleCollection collection)
        {
            string temp;
            for (var i = 0; i < collection.Length; i++)
            {
                for (var j = i + 1; j < collection.Length; j++)
                {
                    if (collection[i].ToCharArray()[0] > collection[j].ToCharArray()[0])
                    {
                        temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }
                }
            }

            return collection;
        }
        
        static void Main(string[] args)
        {
            var collection = new ExampleCollection();
            collection.AddItem("foo");
            collection.AddItem("bar");
            collection.AddItem("a");

            var sorted = AlphabeticalOrderSort(collection);
            
        }
    }
}