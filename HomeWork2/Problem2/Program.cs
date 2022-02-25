using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input an array:");
            String s=Console.ReadLine();
            String[] strArr = s.Split(" ");
            int[] intArr = new int[strArr.Length];
            for(int i=0;i<strArr.Length;++i)
            {
                intArr[i] = Int32.Parse(strArr[i]);
            }
            Func(intArr,out int max,out int min,out double avr,out int sum);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(avr);
            Console.WriteLine(sum);
        }
        static void Func(int[] arr,out int max,out int min,out double avr,out int sum)
        {
            max = Int32.MinValue;
            min = Int32.MaxValue;
            sum = 0;
            foreach(int i in arr)
            {
                max = Math.Max(max, i);
                min = Math.Min(min, i);
                sum += i;
            }
            avr = (double)sum / arr.Length;
        }
    }
}
