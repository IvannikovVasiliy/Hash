using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List_Hash;

namespace List_Hash
{
    public class Info
    {
        const int Size = 100;
        public int[] arr { get; set; } = new int[Size];
        public int sum_curr
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum +=arr[i];
                }
                return sum;
            }
            set
            {
                sum_curr = value;
            }
        }
        public int Count { get; set; } = 0;
        public void Add(int value)
        {
            if (Count == 100)
                throw new Exception("Переполнение");
            arr[Count] = value;
            Count++;
        }
        public void Delete(int value)
        {
            for (int i = 0; i < Size; i++)
            {
                if (arr[i] == value)
                {
                    for (int j = i; j < Size - 1; j++)
                    {
                        int buf = arr[j];
                        arr[j] = arr[j + 1];
                    }
                    arr[Size - 1] = 0;
                }
            }
            Count--;
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

    }
    public class Node
    {
        public Info info { get; set; } = new Info();
        public Node next { get; set; }
        public void Add(int value)
        {
            info.Add(value);
        }
    }
    public class Hashtable
    {
        public Hashtable()
        {
            for (int i = 0; i < Size; i++)
            {
                Node node = new Node();

                if (i == 0)
                {
                    Head = node;
                    Tail = node;
                }
                else
                {
                    Tail.next = node;
                    Tail = node;
                }
            }
        }
        private Node Head { get; set; }
        private Node Tail { get; set; }
        private int Size { get; set; } = 100;
        public int Count { get; set; } = 0;
        public void Add(int value)
        {
            Node node = new Node();
            node = Get(value % Size);
            node.Add(value);
            Count++;
        }
        public Node Get(int index)
        {
            Node node = new Node();
            node = Head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }
        public void Delete(int value)
        {
            Node node = Get(value % Size);
            node.info.Delete(value);
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Node node = Get(i);
                node.info.Print();
                Console.WriteLine();
            }
        }
    }
}
