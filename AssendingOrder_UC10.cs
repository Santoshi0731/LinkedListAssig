using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class AssendingOrder_UC10
    {
        public Node head=null;

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;

        }


        public void AseendingOrder()
        {
            Node tnode = head, index = null;
            int temp;

            if (head == null)
            {
                return;

            }
            else
            {
                while (tnode != null)
                {
                    index = tnode.next;


                    while (index != null)
                    {
                        if (tnode.data > index.data)
                        {
                            temp = tnode.data;
                            tnode.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    tnode = tnode.next;
                }

            }
        }

        public void printList()
        {
            Node tnode = head;
            
            if(head==null)
            {
                Console.WriteLine("List Is Empty");
                return;
            }
            while (tnode != null)
            {
                Console.WriteLine(tnode.data + " ");
                tnode = tnode.next;

            }
            Console.WriteLine();
        }
    }
}
