using DataStructures.LinkedLists;

namespace DataStructures;
public class MyLinkedList
{
    private Node? Head { get; set; }
    private int LengthOfList = 0;


    public int Get(int index)
    {
        if (LengthOfList == 0 || index >= LengthOfList)
            return -1;

        var node = GetNodeAtIndex(index);
        return node.NodeValue;

    }

    private Node? GetNodeAtIndex(int index)
    {

        int currentIndex = 0;
        Node? currentNode = Head;

        while (currentNode != null)
        {
            if (index == currentIndex)
                return currentNode;

            currentNode = currentNode.NextNode;
            currentIndex++;
        }

        return currentNode;
    }

    public void AddAtHead(int val)
    {
        Node newHead = new(val, Head);
        Head = newHead;
        LengthOfList++;
    }

    public void AddAtTail(int val)
    {
        Node newTail = new(val);

        if (LengthOfList == 0)
        {
            Head = newTail;
            LengthOfList++;
            return;
        }

        Node? currentNode = Head;

        while (currentNode.NextNode != null)
        {
            currentNode = currentNode.NextNode;
        }

        currentNode.NextNode = newTail;

        LengthOfList++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if (index == LengthOfList)
        {
            AddAtTail(val);
            return;
        }

        if (!IsValidated(index))
            return;

        Node newNode = new(val);
        var prevNode = GetNodeAtIndex(index - 1);
        newNode.NextNode = prevNode.NextNode;
        prevNode.NextNode = newNode;
        LengthOfList++;
    }

    public void DeleteAtIndex(int index)
    {
        if (!IsValidated(index))
            return;
        if (index == 0)
        {
            Head = (LengthOfList == 1) ? null : Head.NextNode;
            LengthOfList--;
            return;
        }

        var prevNode = GetNodeAtIndex(index - 1);
        var currNode = prevNode.NextNode;
        prevNode.NextNode = currNode.NextNode;
        LengthOfList--;
    }

    private bool IsValidated(int index)
    {
        if (index < 0 || index > 2000 || index > LengthOfList)
            return false;
        return true;
    }
}

public class Node
{
    public int NodeValue { get; set; }
    public Node? NextNode { get; set; }

    public Node(int val) : this(val, null) { }

    public Node(int val, Node? next)
    {
        NodeValue = val;
        NextNode = next;
    }
}
