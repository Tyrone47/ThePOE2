using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue<T>
{
    private Node<T> head;
    private Node<T> tail;

    public void Enqueue(T element)
    {
        var temp = new Node<T>(element);

        if (head == null)
            head = tail = temp;
        else
        {
            tail.Next = temp;
            tail = temp;
        }
    }

    public bool hasNext()
    {
        if(head != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public T Dequeue()
    {
        if (head == null)
            throw new System.Exception("Queue Empty");

        var temp = head.Element;
        head = (Node<T>)head.Next;

        return temp;
    }
}
