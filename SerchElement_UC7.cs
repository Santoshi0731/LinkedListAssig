using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class SerchElement_UC7
    {
        
        public Node head;
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        public bool SearchElemet( Node head,int key) 
        {
            Node current = head;

            while (current != null) 
            {
                if(current.data == key)
                {
                     return true;

                }
                current = current.next;
            }
            return false;
                       
        }

    }
}
