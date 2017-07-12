using System;
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

            a.AddtoEnd(55);
            a.AddtoEnd(22);
            a.AddtoEnd(11);

            /*foreach(var item in a)
            {
                Console.WriteLine(a);
            } */
            Console.WriteLine(a);
            Console.WriteLine("eh?");
            Console.ReadKey();
        }

        public IEnumerator<int> GetListEnumerator(LinkedList<int> list)
        {
            var current = list.First;
            if (current == null)
            {
                yield break;
            }
            yield return current.Value;
            current = current.Next;
            while (current != list.First)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public List<int> GetTimes(LinkedList<int> list)
        {
            List<int> items = new List<int>();
            var current = list.First;
            if (current == null)
            {
                return items;
            }
            items.Add(current.Value);
            current = current.Next;
            while (current != list.First)
            {
                items.Add(current.Value);
                current = current.Next;
            }
            return items;
        }
    }
}
