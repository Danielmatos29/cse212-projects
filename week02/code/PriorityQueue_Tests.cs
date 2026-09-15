using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following data and priority: Take a shower (2), Watch TV (3), Do homeworks (1)
    // Expected Result: Do homeworks
    // Defect(s) Found: iteration to find the higher priority 
    // beginned from the second item instead of the first one.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Take a shower", 2);
        priorityQueue.Enqueue("Watch TV", 1);
        priorityQueue.Enqueue("Do homeworks", 3);

        PriorityItem expectedResults = new PriorityItem("Do homeworks", 3);
    
        var person = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResults.Value, person);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}