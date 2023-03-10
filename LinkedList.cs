using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {

            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;

            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }

            Console.WriteLine("{0} Added into linked list", node.data);

        }
         public void Push (int data) { }
        public void Append(int data)
        {

            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;

            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }

            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        

        

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;

            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
