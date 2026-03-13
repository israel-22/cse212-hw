using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_1()
    {
        // Scenario: Items are added with different priorities.
        // Expected Result: Dequeue returns the item with the highest priority.
        // Defect(s) Found: None

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Tim", result);
    }



    [TestMethod]
public void TestPriorityQueue_2()
{
    // Scenario: Two items have the same highest priority.
    // Expected Result: The one inserted first should be removed first.
    // Defect(s) Found: None

    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("Bob", 5);
    priorityQueue.Enqueue("Tim", 5);
    priorityQueue.Enqueue("Sue", 3);

    var result = priorityQueue.Dequeue();

    Assert.AreEqual("Bob", result);
}
}