using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            if(int.TryParse(Console.ReadLine(),out int num))
            {
                int[] ans = new int[100];
                GetFactor(num, ref ans,out int j);
                for (int i = 0; i < j; ++i)
                {
                    Console.WriteLine(ans[i]);
                }
            }
        }
        static void GetFactor(int num,ref int[] ans,out int j)
        {
            j = 0;
            if (num <= 0) return;

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
                    num /= i;
                }
            }
            ans[j] = num;
            ++j;
        }
    }
}
