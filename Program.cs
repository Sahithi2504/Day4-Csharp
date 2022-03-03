using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------dictionary------


            var weeks = new Dictionary<string, string>();
            weeks.Add("sun", "sunday");
            weeks.Add("mon", "monday");
            weeks.Add("tus", "tuesday");
            weeks.Add("wed", "wednesday");
            weeks.Add("thur", "thursday");
            weeks.Add("fri", "friday");
            weeks.Add("sat", "saturday");
            Console.WriteLine("Keys present in the dictionary:");
            var key = new List<string>(weeks.Keys);
            foreach (string k in key)
            {
                Console.WriteLine("{0}", k);
            }
            Console.WriteLine("Values present in the dictionary:");
            var value = new List<string>(weeks.Values);
            foreach (string val in value)
            {
                Console.WriteLine("{0}", val);
            }
            Console.ReadLine();


            //---Stack program----

            Stack mystack = new Stack();
            mystack.Push(10);
            mystack.Push(20);
            mystack.Push(30);
            Console.WriteLine("{0} items in the stack", mystack.Count);
            Console.WriteLine(mystack.Peek());
            mystack.Pop();
            Console.WriteLine(mystack.Peek());
            mystack.Clear();
            Console.WriteLine("{0} items in the stack", mystack.Count);
            Console.ReadLine();



            //-------Queue program----

            var value = new Queue<string>();
            value.Enqueue("Item 1");
            value.Enqueue("Item 2");
            value.Enqueue("Item 3");

            Console.WriteLine(value.Dequeue());
            Console.WriteLine(value.Peek());
            Console.WriteLine("{0} items in queue", value.Count);
            foreach (var item in value)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            //--------------HashTable---------------
            Hashtable ht = new Hashtable();

            ht.Add("001", "Sahithi");
            ht.Add("002", "Sruthi");
            ht.Add("003", "Sravya");

            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadLine();


            //---------Nullable-------
            int? n1 = null;
            Console.WriteLine(n1.GetValueOrDefault());

            int? n2 = 50;
            Console.WriteLine(n2.GetValueOrDefault());
            Console.ReadLine();


            //---------- Null Coalescing Operator ----------
            int? num1 = null;
            int? num2 = 3;
            int num3;

            num3 = num1 ?? 5;
            Console.WriteLine(" Value of num3: {0}", num3);

            num3 = num2 ?? 5;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}
