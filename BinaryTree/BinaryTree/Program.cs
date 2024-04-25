using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        /*
         Create node 
         */
        public class Node
        {
            public  int data;
            public Node left;
            public Node right;
           public  Node(int d)
            {
                this.data = d;
                this.left = null;
                this.right = null;
            }
        }
        /*
         Build trees
        get data for current node 
        goto left and build tree
        got to right and build tree


         */
        static Node Buildtree(ref Node root)
        {
            Console.WriteLine("Enter the data root node :");
            int data = Convert.ToInt32(Console.ReadLine());
            //base case
            if(data == -1)
            {
                return null;
            }
            //create new node 
            root = new Node(data);
            //recursive call for left
            Console.WriteLine($"Enter the data root node for left {data} :");
            root.left = Buildtree(ref root.left);
            //recursive call for right node
            Console.WriteLine($"Enter the data root node for right {data} :");
            
            root.right = Buildtree(ref root.right);

            return root;

        }
        /*preorder(NLR)
        N- print the node
        L- got to left 
        R- roto right
         */
        static void PreorderPrint( Node root)
        {
           if(root== null)
            {
                return;
            }
            Console.Write(root.data);
            PreorderPrint(root.left);
            Console.WriteLine();
            PreorderPrint(root.right);

        }

        static void PostorderPrint( Node root)
        {
            if(root== null)
            {
                return ;
            }
            PostorderPrint(root.left);
            PostorderPrint(root.right);
            Console.WriteLine(root.data);
        }


        static void InorderPrint(Node root)
        {
            if(root == null)
            {
                return;
            }

            InorderPrint(root.left);
            Console.WriteLine(root.data);
            InorderPrint(root.right);

        }






       
       //BFS
       //print level of tree


       public static void printLevel(Node root, int level ) {


            /*
             time compacity : O(N^2)
             */
            //base case
            if (root.data == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.data);
            }
            else 
            {
                printLevel(root.left, level - 1);
                printLevel(root.right, level - 1);
            }

        

        }
        // level order traversal using queue
        public static  void levelOrderTravarsal(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            //enter the seprater 
            q.Enqueue(null);
            while (q.Count!=0)
            {
            
                Node tempnode = q.Dequeue();
                
               
                if(tempnode == null)
                {//puranalevel compit travars ho chuka hai 
                    Console.WriteLine();
                    if (q.Count != 0)
                    {//queue has some child node
                        q.Enqueue(null);
                    }
                }

                else
                {
                    Console.Write(tempnode.data + " ");
                    if (tempnode.left != null)
                    {
                        q.Enqueue(tempnode.left);

                    }
                    if (tempnode.right != null)
                    {
                        q.Enqueue(tempnode.right);

                    }
                }

            }


            }


       



        static void Main(string[] args)
        {
            Node root = null;

            //build tree
            Console.WriteLine("Make the tree ");
            Buildtree(ref root);
            Console.WriteLine();
            


            //preorder
            Console.WriteLine("DFS:-this is pre order travarsal");
            PreorderPrint(root);
            Console.WriteLine();
            //in order travarsal
            Console.WriteLine("DFS:-this is Inorder order travarsal");
            InorderPrint(root);
            Console.WriteLine();

            //post order 
            Console.WriteLine("DFS:-this is Post order travarsal");
            PostorderPrint(root);
            Console.WriteLine();


            //BFS
            //print level by level time compacity : O(N^2)
            Console.WriteLine("BFS:-Print Level by Level time compacity : O(N^2)");
            for (int i = 1; i < 3; i++)
            {
                printLevel(root, i);
                Console.WriteLine();
            }


           
            //level order travarsal by queue
            Console.WriteLine("BFS:- LEVEL ORDER TRAVARSAL BY QUEUE ");
            levelOrderTravarsal (root);


            //ReversLevelOrderTravarsal(ref root);

            






        }
    }
}
