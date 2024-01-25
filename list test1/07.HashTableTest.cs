using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_test1
{
    public class CheatKey
    {
                                //key  ,  value
        public static Dictionary<string, Action> CheatDic = new Dictionary<string, Action>();
            
        public static void Run(string cheatKey)
        {
            CheatDic.TryGetValue(cheatKey, out Action action);
            action?.Invoke();
            //조건문 없이 바로 탐색 
        }
        public static void ShowMeTheMoney()
        {
            Console.WriteLine("m");
        }
        public static void OperationCwal()
        {
            Console.WriteLine("era");
        }

        static void Main1(string[] args)
        {
            CheatDic.Add("show me the money", ShowMeTheMoney);
            CheatDic.Add("operation cwal", OperationCwal);

            while (true)
            {
                Console.Write("Message : ");
                string ms = Console.ReadLine();
                
                Run(ms);
            }
        }
    }
   

    
}