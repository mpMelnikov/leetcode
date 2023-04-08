public class Solution133
{
    private Dictionary<Node, Node> _cloned;

    public Node CloneGraph(Node node)
    {
        if (node == null) return node;
        if (node.neighbors == null || node.neighbors.Count == 0)
            return new Node(node.val);

        _cloned = new();
        return Clone(node);
    }

    private Node Clone(Node node)
    {
        if(_cloned.ContainsKey(node)) return _cloned[node];

        var clone = new Node(node.val);

        _cloned.Add(node, clone);

        foreach(var neighbor in node.neighbors)
        {
            var childClone = Clone(neighbor);
            clone.neighbors.Add(childClone);
        }

        return clone;
    }
}
