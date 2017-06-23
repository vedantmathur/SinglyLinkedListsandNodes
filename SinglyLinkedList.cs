﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_SinglyLinkedList
{
    class SinglyLinkedList<T>
    {
        SinglyLinkedNode<T> head;

        public SinglyLinkedList()
        {
            head = null;

        }

        void AddtoEnd(T value)
        {
            SinglyLinkedNode<T> nodeToSee = head;

            if (head == null)
            {
                head = new SinglyLinkedNode<T>(value);
            }
            else
            {
                while (nodeToSee.Next != null)
                {
                    nodeToSee = nodeToSee.Next;
                }
                nodeToSee.Next = new SinglyLinkedNode<T>(value);
            }

        }

        void AddtoFront(T value)
        {
            SinglyLinkedNode<T> tempNode = new SinglyLinkedNode<T>(value);
            tempNode.Next = head;
            head = tempNode;
        }

        bool RemoveFromFront()
        {
            if (head == null)
            {
                return false;
            }
            else
            {
                head = head.Next;
                return true;
            }
        }

        bool RemoveFromEnd()
        {
            SinglyLinkedNode<T> nodeToSee = head;
            if(head == null)
            {
                return false;
            }
            while(true)
            {
                if (nodeToSee.Next != null)
                {
                    nodeToSee = nodeToSee.Next;
                }
                else
                {
                    nodeToSee = null;
                    break;
                }
            }


            return true;  
        }




        // SinglyLinkedList()	Create an empty singly linked list

        // void	AddToEnd(T value)	Add a node to the end of the list

        // void	AddToFront(T value)	Add a node to the front of the list

        // bool	RemoveFromFront()	Remove a node from the front of the list

        // bool	RemoveFromEnd()	Remove a node from the end of the list

        // bool	RemoveAt(int position)	Remove a node at the given position

        // bool	IsEmpty()	Determine if list is empty

        // string ToString()	Return the values of the nodes

        // int	Count	Return the number of nodes in the list



    }
}
