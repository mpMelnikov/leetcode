public static class GraphBuilder
{
    // An adjacency list is a collection of unordered lists used to represent a finite graph.
    // Each list describes the set of neighbors of a node in the graph.
    public static Node Create(int[][] adjacencyList)
    {
        Dictionary<int, Node> nodes = new();
        int nodeId = 1;
        foreach(int[] neighbors in adjacencyList)
        {
            var node = new Node(nodeId);
            nodes.Add(nodeId, node);

            foreach(int neighbor in neighbors)
            {
                if (neighbor > nodeId) continue;

                nodes[neighbor].neighbors.Add(node);
                node.neighbors.Add(nodes[neighbor]);
            }

            nodeId++;                 
        }

        return nodes[1];
    }
}
