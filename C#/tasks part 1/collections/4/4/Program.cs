using System;
using System.Collections.Generic;
using System.Collections;
namespace _4
{
     class Program
     {
        static void Main()
        {
            List<string> m1 = new List<string> { "песня1, песня2, песня3" };
            HashTable_ n1 = new HashTable_("испл1", "aaaaaa");// m1);
            n1.PlayList();
            Console.ReadLine();
        }
     }    
}
