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
            LinkedList<int> list = new LinkedList<int>();

            foreach(var item in list)
            {

            }    
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
