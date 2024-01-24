using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_test1
{
    
    internal class Linkedlist1
    {
        

        static void Mai1n()
        {
            LinkedList<int> llist = new LinkedList<int>();
            while (true)
            {

                Console.Clear();
                Console.WriteLine("수를 입력");
                try { 
                int input = int.Parse(Console.ReadLine());
                    if (input > 0)
                    {
                        llist.AddLast(input);
                    }
                    else if (input < 0)
                    {
                        llist.AddFirst(input);
                    }
                    else if (input == 0)
                    {
                        Console.WriteLine("0은 음수도 양수도 아니니까 제외하자");
                        Console.ReadLine();
                    }
                    foreach (int i in llist)
                    {

                        Console.Write($"{i}, ");

                    }
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("정확한 값을 다시 입력");
                    Console.ReadLine();
                }
            }
        }
    }
   
}

