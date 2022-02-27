using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNum(out bool[] isValid,100);
            for(int i=2;i<101;++i)
            {
                if (isValid[i]) Console.WriteLine(i);
            }
        }
        static void PrimeNum(out bool[] isValid,int num)
        {
            isValid = new bool[num+1];
            for (int i = 0; i <= num; ++i)
            {
                isValid[i] = true;
            }
            for (int i = 2; i <= num; ++i)
            {
                for (int j = i + 1; j <= num; ++j)
                {
                    if (isValid[j] && j % i == 0)
                    {
                        isValid[j] = false;
                    }
                }
            }
        }
    }
}
