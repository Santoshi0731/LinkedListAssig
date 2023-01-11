using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class AddEle_UC2
    {
        public Node head;

        
            public void push(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = head;
                head = new_node;

            }

            public void printList()
            {
                Node tnode = head;
                while (tnode != null)
                {
                    Console.WriteLine(tnode.data + " ");
                    tnode = tnode.next;

                }
            }
        
    }
}
