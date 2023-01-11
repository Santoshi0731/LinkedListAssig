using System.Collections;
using System.Collections.Generic;

namespace LinkedListDemo
{

    class Program
    {

        public static void Main(string[] args)
        {
            //Console.WriteLine("------------------UC2--------------");
            //Console.WriteLine("The Adding Element is : ");
            //AddEle_UC2 Add = new AddEle_UC2();
            //Add.push(56);
            //Add.push(30);
            //Add.push(70);

            //Add.printList();




            //Console.WriteLine("------------------UC1--------------");
            //Console.WriteLine("The Created Link List is :");
            //CreateLinkedList_UC1 link=new CreateLinkedList_UC1();
            //link.CreateLinklist();

            //Console.WriteLine("--------------UC10----------------");
            //AssendingOrder_UC10 assending = new AssendingOrder_UC10();
            //assending.push(56);
            //assending.push(30);
            //assending.push(76);

            //assending.printList();
            //Console.WriteLine("After Assending Nodes : ");
            //assending.AseendingOrder();
            //assending.printList();



            //Console.WriteLine("------------------UC9--------------");

            //Console.WriteLine("Linked List is :");
            //DeleteNode_UC9 search = new DeleteNode_UC9();
            //search.push(70);
            //search.push(40);
            //search.push(30);
            //search.push(56);

            //search.printList();

            //Console.WriteLine("after deleting");
            //search.DeleteNode(40);
            //search.printList();







            //Console.WriteLine("--------------UC8----------------");

            //Insert_40_UC8 search = new Insert_40_UC8();
            //search.push(70);
            //search.push(30);
            //search.push(56);

            //search.insertAfter(search.head.next,40);
            //Console.WriteLine("Created Linkedlist is :");
            //search.printList();

            //Console.WriteLine("--------------UC7----------------");

            //  SerchElement_UC7 Search = new SerchElement_UC7();
            //  Search.push(56);
            //  Search.push(30);
            //  Search.push(70);

            //if (Search.SearchElemet(Search.head, 30))
            //  {
            //      Console.WriteLine("yes");
            //  }
            //else
            //  {
            //      Console.WriteLine("no");
            //  }

            //Console.WriteLine("--------------UC6----------------");
            //DeleteLastEle_UC6 lastEle = new DeleteLastEle_UC6();
            //lastEle.DeleteLastEle();


            //Console.WriteLine("--------------UC5----------------");
            //DeleteFirstEle_UC5 deleteEle = new DeleteFirstEle_UC5();
            //deleteEle.DeleteEle();

            //LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);

            //Console.WriteLine("--------------UC4----------------");
            InsertedNode_UC4 insertion =new InsertedNode_UC4();
            insertion.push(56);
            insertion.push(70);

            insertion.Insert(30);
            Console.WriteLine("Created Link List is : ");
            insertion.PrintList();


            // linkedList.Append(56);
            ////linkedList.Append(30);
            // linkedList.Append(70);

            //linkedList.Display();
        }
    }
}

