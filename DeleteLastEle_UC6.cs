using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class DeleteLastEle_UC6
    {
        public void DeleteLastEle()
        {
            int[] num = { 56, 30, 70 };
            LinkedList<int> myList = new LinkedList<int>(num);

            foreach (var n in myList)
            {
                Console.WriteLine(n);
            }

            myList.RemoveLast();
            Console.WriteLine("Linked after removing the first node");

            foreach (var n in myList)
            {
                Console.WriteLine(n);
            }
        }
    }
}
