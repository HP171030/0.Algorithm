using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace list_test1
{
    internal class JosephusTest
    {
        static void Main3()
        {
            List<int> Answer = new List<int>();

            Console.WriteLine("입력1");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("입력2");
            int K = int.Parse(Console.ReadLine());

            LinkedList<int> CircleList = new LinkedList<int>();
           LinkedListNode<int> node = CircleList.First;
                                                            //노드가 첫번째
            for(int i = 0; i < K-1; i++)                        // k번 까지
            {                                                      // 노드를 한칸씩 뒤로 이동 
                 node = node.Next;
            }

            foreach(int num in Answer)
            {
                Console.WriteLine(num);
            }
            
        }
    }
    
}
