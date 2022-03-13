using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {            
            GenericList<int> glist = new GenericList<int>();
            for(int i=1;i<10;++i)
            {
                glist.Add(i);
            }
            //打印
            Console.WriteLine("打印链表元素");
            glist.ForEach(m => Console.WriteLine(m));
            //求最大值
            int max = int.MinValue;
            glist.ForEach(m =>max=Math.Max(max,m));
            Console.WriteLine($"最大值：{max}");
            //求最小值
            int min = int.MaxValue;
            glist.ForEach(m =>min=Math.Min(min, m));
            Console.WriteLine($"最小值：{min}");
            //求和
            int sum = 0;
            glist.ForEach(m=>sum+=m);
            Console.WriteLine($"和：{sum}");
        }
    }
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
;        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail==null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for(Node<T> node = head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    }
}
