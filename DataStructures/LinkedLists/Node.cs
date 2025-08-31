namespace DataStructures.LinkedLists;
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
