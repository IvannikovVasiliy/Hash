using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class Node<T>
    {
        public T Info { get; set; }
        public Node<T> Next { get; set; }
    }
}
