using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following data and priorities: Take a shower (2), Watch TV (3), Do homeworks (1)
    // Expected Result: Do homeworks
    // Defect(s) Found: iteration to find the higher priority 
    // beginned from the second item instead of the first one.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Take a shower", 2);
        priorityQueue.Enqueue("Watch TV", 1);
        priorityQueue.Enqueue("Do homeworks", 3);

        PriorityItem expectedResult = new PriorityItem("Do homeworks", 3);
    
        var person = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult.Value, person);
    }

    [TestMethod]
    // Scenario: Create a queue with the following data and priorities: Play Video Games (1), Learn something new (2), Train Calisthenics (3), Read the scriptures (4), Pray (4)
    // Expected Result: Pray
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Play Video Game", 1);
        priorityQueue.Enqueue("Learn something new", 2);
        priorityQueue.Enqueue("Train Calisthenics", 3);
        priorityQueue.Enqueue("Read the scriptures", 4);
        priorityQueue.Enqueue("Pray", 4);

        PriorityItem expectedResult = new PriorityItem("Pray", 4);

        var person = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult.Value, person);
    }

    // Add more test cases as needed below.
}