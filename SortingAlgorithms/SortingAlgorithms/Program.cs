using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
      internal class Program
    {
        //Insertion Sort
        /*
         *time Complecity - O(n^2)
         *space complecity - O(1)
         *Best case - O(n)
         *worst case -O(n^2)

         */
        static void InsertionSort(ref int[] arr)
        {

            int j;
            for(int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                 for(j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > key)
                    {
                        arr[j+1] = arr[j];
                    }
                    else
                    {
                        break;
                    }
                       

                }
                arr[j + 1] = key;

            }


        }


         


        //Quick Sort
        //partitioning 
        static int Partition(ref int[] arr , int s,int e)
        {
            int pivat = arr[s];
            int count = 0;
            for(int i = s; i <= e; i++)
            {
                if (arr[i] < pivat) { count++; }
            }
            //Console.WriteLine($"this is pivot{arr[s]} and count {count}");
            int corectPositionIndex =s+count;
            //swap to correct position
            int temp = arr[s];
            arr[s] = arr[corectPositionIndex];
            arr[corectPositionIndex] = temp;
            //adjest left and right values

            while (s < corectPositionIndex && e>corectPositionIndex)
            {
                while (arr[s] < pivat) { s++; }
                while (arr[e] > pivat) { e--; }
                if(s < corectPositionIndex && e > corectPositionIndex)
                {
                int tp = arr[s];
                arr[s] = arr[e];
                arr[e] = tp;
                    s++;
                    e--;

                }
            }
           


            //returning corret poisition
            return corectPositionIndex;
        }
                            
        static void Quicsort(ref int[] arr ,int s,int e)
        {
            //bASE CASE
            if (s >= e)
            {
                return;
            }
            
            int p = Partition(ref arr, s, e);
            //left sort
            Quicsort(ref arr ,s,p-1);
            //right sort
            Quicsort(ref arr ,p+1,e);
           

        }




        //Heap Sort





        //create two new SortedDictionary array and merge
        
        static void merge(ref int[] arr, int s, int e)
        {
            int mid = (s + e) / 2;
            int len1 = mid - s + 1;
            int len2 = e - mid;
            int[] first = new int[len1];
            int[] second = new int[len2];
            int k = s;
            // k is Main array index
            //add element in first and second array
            for (int i = 0; i < len1; i++)
            {
                first[i] = arr[k++];
            }
            k = mid + 1;
            for (int i = 0; i < len2; i++)
            {
                second[i] = arr[k++];
            }
            // merge2 soeterd array
            int index1 = 0;
            int index2 = 0;
            k = s;
            while (index1 < len1 && index2 < len2)
            {
                if (first[index1] < second[index2])
                {
                    arr[k++] = first[index1++];
                }
                else
                {
                    arr[k++]= second[index2++];
                }
                
            }
            while (index1 < len1) 
            {
                arr[k++]  = first[index1++];

            }
            while (index2 < len2)
            {
                arr[k++] = second[index2++];

            }

        }
        
        static void Mergesort(ref int[] arr,int s, int e)
        {
            if (s >= e)
            {
                return;
            }
            
            //mid
            int mid = (s+e)/ 2;
            //left sort
            Mergesort(ref arr, s, mid);

            //right sort
            Mergesort( ref arr, mid+1, e);
            merge(ref arr, s, e);
            
        }
        //selection sort
        static int[] SelectionSort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //fins min index
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                    
                }
                //swap element
                int temp = arr[i];
                arr[i] = arr[min_index];
                arr[min_index] = temp;
            }
            return arr;

        }
        //Bubble sort
        static int[] BubbleSort(int[] arr)
        {
            bool swaped;
            for(int i = 0; i < arr.Length-1; i++)
            {
                swaped = false;

                for(int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swaped = true;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                if (swaped==false)
                {
                    break;
                }
            }
            return arr;
        } 
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 9, 4, 3, 0, 1, 2, 6, 8 };
            foreach (int i in arr)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            //selection sort
            arr = SelectionSort(arr);
            Console.Write("this is with selection sort :");
            foreach (int i in arr)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            //bubble sort
            arr =new int[] { 5, 7, 9, 4, 3, 0, 1, 2, 6, 8 };
            arr = BubbleSort(arr);
            Console.Write("this is with bubble sort :");
            foreach (int i in arr)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            //merge sort
            arr = new int[] { 5, 7, 9, 4, 3, 0, 1, 2, 6, 8 };
            Console.Write("this is with merge sort :");
            Mergesort(ref arr,0,10-1);
            foreach (int i in arr)
            {
                Console.Write(i + " ");

            }

            Console.WriteLine();
            //Insertion sort
            arr = new int[] { 5, 7, 9, 4, 3, 0, 1, 2, 6, 8 };
            Console.Write("this is with insertion sort :");
            InsertionSort(ref arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            //Quick sort
            arr = new int[] { 5, 7, 9, 4, 3, 0, 1, 2, 6, 8 };
            Console.Write("this is with Quick sort :");
            Quicsort(ref arr,0,arr.Length-1);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }


        }
    }
}
