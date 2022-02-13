using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class Hash
    {
        private readonly int Size;
        private List<int>[] Table;
        public Hash(int size)
        {
            Size = size;
            Table = new List<int>[Size];
        }

        public void Add(int info)
        {
            int index = info % Size;
            if (Table[index] == null)
            {
                Table[index] = new List<int>();
            }
            Table[index].Add(info);
        }

        public string Find(int index)
        {
            string res = " ";
            for (int i = 0; i < Size; i++)
            {
                if (index % Size == i)
                {
                    Node<int> curr = Table[i].Head;
                    do
                    {
                        if (curr.Info == index)
                        {
                            res += Convert.ToString(curr.Info) + "\n";
                        }
                        curr = curr.Next;
                    } while (curr != null);
                }
            }
            return res;
        }

        public string ToString()
        {
            string res = "{ \n";
            for (int i = 0; i < Size; i++)
            {
                if (Table[i] != null)
                {
                    Node<int> curr = Table[i].Head;
                    while (curr != null)
                    {
                        res += Convert.ToString(curr.Info) + "\n";
                        curr = curr.Next;
                    }
                }
            }
            res += "}";
            return res;
        }
        public void Delete(int index)
        {
            int hash = index % Size;
            List<int> list = Table[hash];
            list.Delete(list.Head, index);
        }
        public void Clear(int index)
        {
            List<int> list = Table[index];
            list.Clear();
        }
    }
}
