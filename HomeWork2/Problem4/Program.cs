using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;
            Console.WriteLine("Input a matrix");
            Console.WriteLine("Input M:");
            m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input N:");
            n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[m,n];
            for(int i=0;i<m;++i)
            {
                Console.WriteLine($"Input row{i}:");
                String s = Console.ReadLine();
                String[] strArr = s.Split(" ");
                for(int j=0;j<n;++j)
                {
                    if(j>=strArr.Length)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = Int32.Parse(strArr[j]);

                    }
                }
            }
            Console.WriteLine(Judge(matrix, m, n));
        }
        static bool Judge(int[,] matrix,int m,int n)
        {
            bool isValid = true;
            for(int i=1;i<m;++i)
            {
                if (!isValid) break;
                for(int j=1;j<n;++j)
                {
                    if (matrix[i, j] == matrix[i - 1, j - 1])
                    {
                        continue;
                    }
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
