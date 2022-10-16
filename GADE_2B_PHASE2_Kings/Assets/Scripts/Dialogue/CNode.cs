using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CNode<T>
{
    public T data;
    public CNode<T> next;
    public CNode()
    {

    }

    public CNode(T data)
    {
        this.data = data;
        this.next = null;
    }

    public void display()
    {
        Debug.Log(this.data.ToString());

        if (this.next != null)
        {
            Debug.Log(", ");
            this.next.display();
        }
    }
}
