using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class DeleteNode_UC9
    {
        public Node head;

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;

        }

        public void DeleteNode(int key)
        {
            Node temp = head, prev = null;

            if(temp != null && temp.data == key) 
            {
                head = temp.next;
                return;
            }
            while(temp != null && temp.data != key)
            {
                prev = temp; 
                temp=temp.next;
            }
            if(temp== null)
            {
                return;
            }
            prev.next = temp.next;
                
        
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
