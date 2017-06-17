using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_SinglyLinkedList
{
    class SinglyLinkedNode<T>
    {
        public T Item { get; set; }
        public SinglyLinkedNode<T> Next { get; set; }

        /// <summary>
        /// Constructor, initializes node
        /// </summary>
        /// <param name="itemToStore">Value of this node</param>
        /// <param name="next">Next Node</param>
        public SinglyLinkedNode(T itemToStore, SinglyLinkedNode<T> next = null )
        {
            Item = itemToStore;
            Next = next;

        }

        /// <summary>
        /// Adding a node after the current node. Not at the end.
        /// </summary>
        /// <param name="itemToStore">Generic item to store</param>
        /// <returns>Next Node</returns>
        public SinglyLinkedNode<T> AddAfter(T itemToStore)
        {
            SinglyLinkedNode<T> node = new SinglyLinkedNode<T>(itemToStore);
            node.Next = Next;
            Next = node;
            return node;
        }


        public SinglyLinkedNode<T> RemoveAfter()
        {


            return;
        }

    }
}
