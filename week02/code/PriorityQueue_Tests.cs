using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue 3 items with different priorities, then Dequeue.
    // Expected Result: Item with highest priority is removed first.
    // Defect(s) Found: Original Dequeue didn’t check last item or didn’t remove the item.
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("low", 1);
        queue.Enqueue("medium", 5);
        queue.Enqueue("high", 10);

        var result = queue.Dequeue();
        Assert.AreEqual("high", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with same highest priority.
    // Expected Result: The one enqueued first is removed (FIFO behavior).
    // Defect(s) Found: None.
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("first-high", 10);
        queue.Enqueue("second-high", 10);
        queue.Enqueue("low", 1);

        var result1 = queue.Dequeue();
        var result2 = queue.Dequeue();

        Assert.AreEqual("first-high", result1);
        Assert.AreEqual("second-high", result2);
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    public void TestPriorityQueue_Empty()
    {
        var queue = new PriorityQueue();
        try
        {
            queue.Dequeue();
            Assert.Fail("Should throw exception on empty queue.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}
