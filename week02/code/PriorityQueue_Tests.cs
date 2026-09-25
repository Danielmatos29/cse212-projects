using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following data and priorities: Take a shower (2), Watch TV (1), Do homeworks (3)
    // Expected Result: Do homeworks, Take a shower, Watch TV
    // Defect(s) Found: iteration to find the higher priority 
    // beginned from the second item instead of the first one, also missed the RemoveAt method from the Dequeue method.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Take a shower", 2);
        priorityQueue.Enqueue("Watch TV", 1);
        priorityQueue.Enqueue("Do homeworks", 3);

        List<PriorityItem> expectedResults = new List<PriorityItem>
        {
            new PriorityItem("Do homeworks", 3),
            new PriorityItem("Take a shower", 2),
            new PriorityItem("Watch TV", 1)
        };
    
        for (int i = 0; i < 3; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResults[i].Value, person);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following data and priorities: Play Video Games (1), Learn something new (2), Train Calisthenics (3), Read the scriptures (4), Pray (4)
    // Expected Result: Read the scriptures, Pray, Train Calisthenics, Learn something new, Play Vide Games
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Play Video Games", 1);
        priorityQueue.Enqueue("Learn something new", 2);
        priorityQueue.Enqueue("Train Calisthenics", 3);
        priorityQueue.Enqueue("Read the scriptures", 4);
        priorityQueue.Enqueue("Pray", 4);

        List<PriorityItem> expectedResults = new List<PriorityItem>
        {
            new PriorityItem("Read the scriptures", 4),
            new PriorityItem("Pray", 4),
            new PriorityItem("Train Calisthenics", 3),
            new PriorityItem("Learn something new", 2),
            new PriorityItem("Play Video Games", 1)
        };
    
        for (int i = 0; i < 5; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResults[i].Value, person);
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following data and priorities: Take a shower (2), Watch TV (1), Do homeworks (3)
    // Expected Result: Take a shower, Watch TV, Do homeworks
    // Defect(s): None
    public void TestPriorityQueueAtBack()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Take a shower", 2);
        priorityQueue.Enqueue("Watch TV", 1);
        priorityQueue.Enqueue("Do homeworks", 3);

        string expected = "[Take a shower (Pri:2), Watch TV (Pri:1), Do homeworks (Pri:3)]";

        Assert.AreEqual(expected, priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Try to dequeue an item from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: None
    public void TestPriorityQueueIsEmpty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}