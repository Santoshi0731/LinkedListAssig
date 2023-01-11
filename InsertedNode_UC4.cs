using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class InsertedNode_UC4
    {
        public Node head;

        public void Linkedlist()
        {
            head = null;
        }
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;

        }

        public void Insert(int new_data)
        {
           

            //if(prev_node == null)
            //{
            //    Console.WriteLine("The Given Previous node" + "cannot be null");
            //    //head = new_Node;

            //}
            //else
            //{
            //    Node temp = new Node();
            //    temp = head;
            //    while(temp.next != null) 
            //    {
            //        temp = temp.next;
            //        temp.next =new_Node;
            //    }
            //}

            Node new_node = new Node(new_data); 
            new_node.data = new_data;
            new_node.next = head;
            head= new_node;
                
        }
        //public void append(int new_data)
        //{
        //    Node new_node = new Node(new_data);
        //    if(head == null)
        //    {
        //        head= new Node(new_data);
        //    }
        //    new_node.next = null;
        //    Node last = head;
        //    while(last.next != null) 
        //    {
        //        last = last.next;
        //    }
        //    last.next = new_node;
        //    return;
        //}

        public void PrintList()
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
        
    
