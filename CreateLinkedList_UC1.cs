using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class CreateLinkedList_UC1
    {
        public Node head;

        public void CreateLinklist()
        {
            int[] num = { 56, 30, 70 };
            LinkedList<int> myList = new LinkedList<int>(num);

            foreach (var n in myList)
            {
                Console.WriteLine(n);
            }
            

        }
}
}
