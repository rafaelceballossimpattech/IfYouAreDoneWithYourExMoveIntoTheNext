//Create a generic linked list where if IsDone is true, then move into the next node, otherwise stay in the current node.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LinkedListNode<T>
{
    public T Value { get; set; }
    public LinkedListNode<T> Next { get; set; }

    public LinkedListNode(T value)
    {
        Value = value;
        Next = null;
    }
}