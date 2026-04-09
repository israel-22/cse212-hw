using System.Collections;
using System.Collections.Generic;

public class BinarySearchTree : IEnumerable<int>
{
    private Node? _root;

    /// <summary>
    /// Insert a new node in the BST (no duplicates allowed).
    /// </summary>
    public void Insert(int value)
    {
        if (_root is null)
        {
            _root = new Node(value);
        }
        else
        {
            _root.Insert(value);
        }
    }

    /// <summary>
    /// Check if the tree contains a certain value
    /// </summary>
    public bool Contains(int value)
    {
        return _root?.Contains(value) ?? false;
    }

    /// <summary>
    /// Get the height of the tree (0 if tree is empty)
    /// </summary>
    public int GetHeight()
    {
        return _root?.GetHeight() ?? 0;
    }

    /// <summary>
    /// Returns string in format: <Bst>{1, 3, 4, 5, 6, 7, 10}
    /// </summary>
    public override string ToString()
    {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }

    // ==================== IN-ORDER TRAVERSAL (for foreach and ToString) ====================
    public IEnumerator<int> GetEnumerator()
    {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        return numbers.GetEnumerator();   // Más eficiente
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private void TraverseForward(Node? node, List<int> values)
    {
        if (node is not null)
        {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    // ==================== REVERSE TRAVERSAL (Problem 3) ====================
    /// <summary>
    /// Returns all values in descending order (largest to smallest)
    /// </summary>
    public IEnumerable<int> Reverse()
    {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        return numbers;
    }

    private void TraverseBackward(Node? node, List<int> values)
    {
        if (node is not null)
        {
            TraverseBackward(node.Right, values);  // Right first
            values.Add(node.Data);
            TraverseBackward(node.Left, values);   // Left after
        }
    }
}