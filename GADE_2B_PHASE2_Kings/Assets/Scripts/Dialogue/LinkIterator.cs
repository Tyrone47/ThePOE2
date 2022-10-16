using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkIterator<T>
{
    private CNode<T> current;
    private int index = -1;

    public LinkIterator(CNode<T> start_node)
    {
        this.current = start_node;
    }

    public bool hasNext()
    {
        if (index == -1)
        {
            return current != null;
        }
        else
        {
            return current.next != null;
        }
    }

    public T next()
    {
        if (index == -1)
        {
            ++index;
            return current.data;
        }
        else
        {
            ++index;
            current = current.next;
            return current.data;
        }
    }
}
