using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace list_test1
{
    internal class SortTest
    {
        static StringBuilder sb = new StringBuilder();
        public static void SelectSort(IList<int> list, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j <= end; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(list, minIndex, i);
            }
        }
        public static void InsertSort(IList<int> list,int start ,int end)
        {
            for(int i = start+1; i <= end; i++)
            {
                for (int j = i; j >=1 ; j--)
                {
                    if (list[j] > list[j-1])
                    {
                        break;
                    }
                    Swap(list, j, j-1);
                }
            }
        }
        public static void HeapSort(IList<int> list,int start, int end)
        {
            
        }
        public static void MergeSort(IList<int> list,int start, int end)
        {
            if(start == end) return;
            int mid = (start+end)/2;


            MergeSort(list, start, mid);
            MergeSort(list, mid+1, end);
            Merge(list, start, mid, end);
        }
        public static void Merge(IList<int> list,int start,int mid,int end)
        {
            List<int> list2 = new List<int>();
            int leftIndex = start;
            int rightIndex = mid + 1;
            while(leftIndex<=mid &&rightIndex<=end)
            {
                if(list[leftIndex]<list[rightIndex])
                {
                    list2.Add(list[leftIndex++]);
                }
                else
                {
                    list2.Add(list[rightIndex++]);  
                }
            }
            if (leftIndex > mid)
            {
                for(int i=rightIndex;  i <= end; i++)
                {
                    list2.Add(list[i]);
                }
            }
            else
            {
                for (int i=leftIndex;i <=mid; i++)
                {
                    list2.Add(list[i]);
                }
            }
            for(int i = 0; i < list2.Count; i++)
            {
                list[start + i] = list2[i];
            }
        }
        public static void BubbleSort(IList<int> list,int start, int end)
        {
            for(int i= start; i < end; i++)
            {
               for (int j =0; j< end - start; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        Swap(list,j,j+1);
                    }
                }
            }

        }
        public static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;

        }
        static void M1ain(string[] args)
        {
            
            Random random = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int R = random.Next(0, 100);
                list.Add(R);
            }

            sb.AppendLine("랜덤요소 :");
            foreach (int i in list)
            {
                sb.Append($"{i,3}");
            }
            string result = sb.ToString();
            Console.WriteLine(result);
            sb.Clear();
            SelectSort(list, 0, list.Count - 1);
            Console.WriteLine("선택정렬 : ");
            foreach (int i in list)
            {
                sb.Append($"{i,3}");
            }
            result = sb.ToString();
            Console.WriteLine(result);
            sb.Clear();

            InsertSort(list, 0, list.Count - 1);
            Console.WriteLine("삽입정렬 : ");
            foreach (int i in list)
            {
                sb.Append($"{i,3}");
            }
            result = sb.ToString();
            Console.WriteLine(result);
            sb.Clear();

            MergeSort(list, 0, list.Count - 1);
            Console.WriteLine("병합정렬 : ");
            foreach(int i in list)
            {
                sb.Append($"{i,3}");
            }
            result = sb.ToString() ;
            Console.WriteLine(result);
            sb.Clear();
            BubbleSort(list, 0, list.Count - 1);
            Console.WriteLine("버블정렬 : ");
            foreach (int i in list)
            {
                sb.Append($"{i,3}");
            }
            result = sb.ToString();
            Console.WriteLine(result);
            sb.Clear();

            BubbleSort(list, 0, list.Count - 1);
            Console.WriteLine("힙정렬 : ");
            foreach (int i in list)
            {
                sb.Append($"{i,3}");
            }
            result = sb.ToString();
            Console.WriteLine(result);
            sb.Clear();
        }
    }
}
