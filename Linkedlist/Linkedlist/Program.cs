using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    internal class Program
    {
        public class Node
        {
           public int data;
           public Node next;

           public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public static void InsertAtHead(ref Node Head , int d)
        {
            //creat new node
            Node temp = new Node(d);
            temp.next = Head;
            Head = temp;
        }
        public static void print(ref Node Head)
        {
            Node temp = Head;
            while(temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        //Insert data at tell
        public static void InsertAtTell(ref Node tell, int d)
        {
            //create new node
            Node temp = new Node(d);
            tell.next = temp;
            tell = temp;
        }
        //Insert at midile
        public static void InsertAtMidile(ref Node Head ,ref Node tell,int position ,int d)
        {
            //insert at start 
            if (position == 1)
            {
                InsertAtHead(ref Head , d );
                return;
            }
            Node temp = Head;
            int cnt = 1;
            while (cnt < position - 1)
            {
                temp = temp.next;
                cnt++;
            }
            // inserting at last
            if(temp.next == null)
            {
                InsertAtTell(ref tell, d);
                return;
            }
            //creting node for d
            Node nodeToInsert = new Node(d);
            nodeToInsert.next = temp.next;
            temp.next = nodeToInsert;
            
            


        }
        static void Main(string[] args)
        {
            //create new node
            Node node1 = new Node(10);
            
            //Head point to node1
            Node Head = node1;
            Node tell = node1;
            print(ref Head);
            //Insert element at head
            InsertAtHead(ref Head, 12);
            print(ref Head);
            InsertAtHead(ref Head, 13);
            print(ref Head);
            //insert element at tell
            InsertAtTell(ref tell , 11);
            print(ref Head);
            InsertAtTell(ref tell, 13);
            print(ref Head);
            InsertAtTell(ref tell, 14);
            print(ref Head);
            //indert element at position or in midile of linked list
            InsertAtMidile(ref Head,ref tell, 1, 134);
            print(ref Head);
            InsertAtMidile(ref Head, ref tell, 6, 0);
            print(ref Head);
            print(ref tell);
        }
    }
}
