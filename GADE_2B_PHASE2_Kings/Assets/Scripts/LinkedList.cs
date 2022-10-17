using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList
{
    Node nodesForWayPoint;

    abstract class Node
    {
        int data;
        Node next;

        // Constructor to create a new node
        Node(int d) { data = d; }
    }
}