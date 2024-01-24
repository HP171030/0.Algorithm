using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*자연수 N과 M이 주어졌을 때, 아래 조건을 만족하는 길이가 M인 
 * 수열을 모두 구하는 프로그램을 작성하시오.

1부터 N까지 자연수 중에서 M개를 고른 수열
같은 수를 여러 번 골라도 된다.*/
namespace list_test1
{
    class Program1
    {
        static void M1ain()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            int[] result = new int[m];
            Permutation(numbers, result, n, m);
        }

        static void Permutation(int[] arr, int[] result, int n, int m, int index = 0)
        {
            if (index == m)
            {
                // 결과를 출력
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                result[index] = arr[i];                         //result[0] = arr[0]
                Permutation(arr, result, n, m, index + 1);
            }
        }
    }
}