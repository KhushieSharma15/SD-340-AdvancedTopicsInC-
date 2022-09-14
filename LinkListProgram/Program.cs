using System;
using System.Collections.Generic;

namespace LinkListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> MyList = new LinkedList<int>();

            //Add three elements at the start of the list.
            MyList.AddFirst(10);
            MyList.AddFirst(20);
            MyList.AddFirst(30);
            foreach (int str in MyList)
            {
                Console.WriteLine(str);
            }
            //MyList.PrintList();
            Console.ReadKey();
        }
    }
}
