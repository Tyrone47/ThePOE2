using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Node<T> 
{
    public Node<T> Next { get; set; }
    public T Element { get; set; }

    public Node (T element) { this.Element = element; }



}
