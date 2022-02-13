using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class List<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Size { get; set; } = 0;
        public void Add(T info)
        {
            if (Head == null)
            {
                Head = new Node<T> { Info = info, Next = null };
                Tail = Head;
            }
            else
            {
                Tail.Next = new Node<T> { Info = info, Next = null };
            }
            Size++;
        }
        public void Delete(Node<int> head, int index)
        {
            Node<int> past = head, curr = head;
            do
            {
                if (index == curr.Info)
                {
                    if (curr == head)
                    {
                        Head = Head.Next;
                    }
                    else
                    {
                        past.Next = past.Next.Next;
                    }
                    Size--;
                }
                if (curr != head)
                {
                    past = past.Next;
                }
                curr = curr.Next;
            } while (curr != null);
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }
    }
}
