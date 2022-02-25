using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int[] ans=Func(num);
            foreach(int i in ans)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Hello World!");
        }
        static int[] Func(int num)
        {
            int n = (int)Math.Sqrt(num);
            int[] ans = new int[n];
            int j = 0;
            int i = 2;
            while(num>i)
            {
                if(num%i!=0)
                {
                    ++i;
                }
                else
                {
                    ans[j] = i;
                    ++j;
                    num %= i;
                }
                
            }
            return ans;
        }
    }
}
