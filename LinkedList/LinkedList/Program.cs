using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
          
            list.Add(4);
            list.Add(11);
            list.Add(15);
            list.Add(18);
            list.Add(28);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(list.GetItemAt(i));
            //}
            Console.WriteLine($"The list has {list.Count()} elements");
            list.RemoveAt(4);
            Console.WriteLine($"The list has {list.Count()} elements");
            Console.ReadKey(true);
        }
    }
}
