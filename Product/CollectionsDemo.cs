using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    internal class CollectionsDemo
    {
        static void Main()
        {
            int[] num = new int[10];
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            //for(int i =0;i<list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            list.Insert(1, 100);
            list.Remove(3);
            list.RemoveAt(0);
            list.Add("Ajay");
            list.Add(.90F);

            Console.WriteLine("ELements after ins / del ");

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Stack stack= new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);


            Console.WriteLine("ELements are ");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            stack.Pop();


            Queue queue= new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);

            queue.Dequeue();

            Hashtable hashtable= new Hashtable();
            hashtable["Ajay"] = 90;
            hashtable["Deepak"] = 89;

            Console.WriteLine(hashtable["Deepak"]);

            foreach(string key in hashtable.Keys)
            {
                Console.WriteLine(key + " = " + hashtable[key]);
            }
            


            //ArrayList >> List

            List<int> list1 = new List<int>();

            list1.Add(10);

            Stack<string> stack1 = new Stack<string>();
            Queue<int>  queue1= new Queue<int>();

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            dictionary[1] = 100;



         
        }
    }
}
