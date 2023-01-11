using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
   
    public class Insert_40_UC8
    {

        public Node head;
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;

        }
        public void insertAfter(Node prev_node, int new_data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("The given previous" + "node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;

        }

        public void printList()
        {
            Node tnode = head;
            while(tnode != null) 
            {
                Console.WriteLine(tnode.data + " ");
                tnode = tnode.next;

            }
        }
    }
}
