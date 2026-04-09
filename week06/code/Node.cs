using System;

public class Node
{
    public int Data { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node(int data)
    {
        Data = data;
    }

    // Problem 1: Insert Unique Values Only
    public void Insert(int value)
    {
        if (value == Data)
            return;

        if (value < Data)
        {
            Left ??= new Node(value);
            Left.Insert(value);
        }
        else
        {
            Right ??= new Node(value);
            Right.Insert(value);
        }
    }

    // Problem 2: Contains
    public bool Contains(int value)
    {
        if (value == Data) return true;
        if (value < Data)
            return Left?.Contains(value) ?? false;
        return Right?.Contains(value) ?? false;
    }

    // Problem 4: Tree Height
    public int GetHeight()
    {
        if (Left is null && Right is null)
            return 1;

        return 1 + Math.Max(Left?.GetHeight() ?? 0, Right?.GetHeight() ?? 0);
    }
}