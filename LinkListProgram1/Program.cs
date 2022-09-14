using System;
using System.Collections.Generic;

namespace LinkListProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> MyList = new LinkedList<string>();

            //Add three elements at the start of the list.
            MyList.AddFirst("ABC");
            MyList.AddFirst("XYZ");
            MyList.AddFirst("IJK");

            foreach (string str in MyList)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
