namespace list_test1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("키입력");
            int a = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i = 0; i <= a; i++)
            {
                list.Add(i);
            }
            list.Remove(0);
            foreach(int i in list)
                Console.WriteLine(i);
            Console.WriteLine("키입력");
            int b = int.Parse(Console.ReadLine());
            if (list.Contains(b))
            {
                list.Remove(b);
            }
            else
            {
                list.Add((int)b);
            }
            foreach (int i in list)
                Console.WriteLine(i);
        }
    }
}
