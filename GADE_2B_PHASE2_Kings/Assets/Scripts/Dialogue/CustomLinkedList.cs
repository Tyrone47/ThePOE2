using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLinkedList<T>
{
    private CNode<T> head;
    private CNode<T> last;
    private int size = 0;

    public void clear()
    {
        this.head = null;
        this.last = null;
        this.size = 0;
    }

    public void push(T data)
    {
        CNode<T> temp = new CNode<T>(data);
        if (head == null)
        {
            head = temp;
            last = temp;

        }
        else
        {
            last.next = temp;
            last = temp;

        }
        ++size;

    }

    public void replace(int index, T data)
    {
        if (index >= 0 && index < this.size)
        {
            CNode<T> current = this.head;
            for (int i = 0; i <= index; ++i)
            {
                if (i != index)
                {
                    current = current.next;
                }
                else
                {
                    current.data = data;
                }
            }
        }
    }

    public void insertAtPosition(int index, T data)
    {
        if (index >= 0 && index < this.size)
        {
            CNode<T> new_data = new CNode<T>(data);
            if (index == 0)
            {
                new_data.next = this.head;
                this.head = new_data;
            }
            else
            {
                CNode<T> current = this.head;
                for (int i = 0; i < index; ++i)
                {
                    if (i == (index - 1))
                    {
                        CNode<T> next = current.next;
                        current.next = new_data;
                        new_data.next = next;
                    }
                    else
                    {
                        current = current.next;
                    }
                }

                if (index == (this.size - 1))
                {
                    this.last = new_data;
                }
            }
            ++this.size;
        }
    }

    public void remove(int index)
    {
        if (index >= 0 && index < this.size)
        {
            if (index == 0)
            {
                if (this.head.next != null)
                {
                    this.head = this.head.next;
                }
                else
                {
                    this.head = null;
                    this.last = null;
                }

                --this.size;
            }
            else
            {
                CNode<T> current = this.head;
                for (int i = 0; i < this.size; ++i)
                {
                    if (i == (index - 1))
                    {
                        if (current.next.next != null)
                        {
                            current.next = current.next.next;
                        }
                        else
                        {
                            current.next = null;
                            this.last = current;
                            break;
                        }
                    }
                    else
                    {
                        current = current.next;
                    }
                }

                --this.size;
            }
        }
    }

    public T get(int index)
    {
        if (index >= 0 && index < this.size)
        {
            CNode<T> current = this.head;
            T val = default(T);
            for (int i = 0; i < this.size; ++i)
            {
                if (i == index)
                {
                    val = current.data;
                }
                else
                {
                    current = current.next;
                }
            }

            return val;
        }
        else
        {
            throw new System.NullReferenceException();
        }
    }

    public T pop()
    {
        if (head != null)
        {
            CNode<T> temp = this.head;
            if (head.next != null)
            {
                this.head = head.next;
            }
            else
            {
                this.head = null;
                this.last = null;
            }

            --this.size;
            return temp.data;
        }
        else
        {
            throw new System.NullReferenceException();
        }
    }

    public bool contains(T data)
    {
        LinkIterator<T> it = this.getIterator();
        bool found = false;

        while (!found && it.hasNext())
        {
            if (it.next().ToString() == data.ToString())
            {
                found = true;
            }
        }

        return found;
    }

    public int getSize()
    {
        return this.size;
    }

    public void displayList()
    {
        if (this.head != null)
        {
            Debug.Log("[");
            this.head.display();
            Debug.Log("]");
        }
    }

    public LinkIterator<T> getIterator()
    {
        LinkIterator<T> it = new LinkIterator<T>(this.head);
        return it;
    }
}
