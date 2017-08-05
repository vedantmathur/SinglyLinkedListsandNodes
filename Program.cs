﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace V_SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            list.AddtoEnd(55);
            list.AddtoEnd(22);
            list.AddtoEnd(11);

            Console.WriteLine(list.ToString());
            Console.WriteLine("eh?");
            Console.WriteLine(list.Count());
            list.RemoveAt(0);
            Console.WriteLine(list.ToString());
            Console.ReadKey();
        }

    }
}
