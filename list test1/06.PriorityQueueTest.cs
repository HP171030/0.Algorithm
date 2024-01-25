using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_test1
{

    public class Boj13904
    {
        static void Mai1n(String[] args)
        {
            Console.Write("과제를 몇일동안 해야하는지 : ");
            int n = Convert.ToInt32(Console.ReadLine()); //과제일수 지정

            Homework[] works = new Homework[n];         //배열이름 : work homework를 따름 배열 수는 과제일수
            PriorityQueue<Homework, int> queue = new PriorityQueue<Homework, int>();
            for (int i = 0; i < n; i++)             //과제 일수 전까지 반복
            {
                string[] arr = (Console.ReadLine().Split()) ;
                works[i] = new Homework((Convert.ToInt32(arr[0])), Convert.ToInt32(arr[1]));                  
                 
            }
            int index = 0;
            int result = 0;
            
            for (int i = n; i >= 0; i--)                         
            {
                while (index < n && works[index].deadline<=i)
                {
                    queue.Enqueue(works[index],works[index].score);
                    index++;
                }
                if (queue.Count > 0)
                {
                    result += queue.Dequeue().score;
                }
            }
                    
                    Console.WriteLine(result);
        }
            





        }

        public class Homework
        {
            public int deadline { get; set; }
            public int score { get; set; }
            public Homework(int deadline, int score)
            {
                this.deadline = deadline;
                this.score = score;
            }
        }
    }