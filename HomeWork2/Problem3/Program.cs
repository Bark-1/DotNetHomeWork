using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNum(out bool[] isValid, 100);
            for(int i=1;i<=100;++i)
            {
                if (isValid[i]) Console.WriteLine(i);
            }
        }
        static void PrimeNum(out bool[] isPrime,int num)
        {
            isPrime = new bool[num + 1];
            for(int i=0;i<=num;++i)
            {
                isPrime[i] = true;
            }
            for(int i=2;i<=num;++i)
            {
                for(int j=i+1;j<=num;++j)
                {
                    if(j%i==0)
                    {
                        isPrime[j] = false;
                    }
                }
            }
        }
    }
}
