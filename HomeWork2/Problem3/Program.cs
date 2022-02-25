using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isValid = new bool[101];
            for(int i=0;i<101;++i)
            {
                isValid[i] = true;
            }
            for(int i=2;i<101;++i)
            {
                for(int j=i+1;j<101;++j)
                {
                    if(isValid[j] && j%i==0)
                    {
                        isValid[j] = false;
                    }
                }
            }
            for(int i=2;i<101;++i)
            {
                if (isValid[i]) Console.WriteLine(i);
            }
        }
    }
}
