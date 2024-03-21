/*
Implement a simplified version of a task management system using the "Memento" software design pattern. 
The system should allow users to create, update, and delete tasks. 
Additionally, users should be able to undo and redo their actions using the Memento pattern.

Requirements:

Implement a Task class with attributes such as task ID, description, status, and any other relevant information.
Create a TaskManager class responsible for managing tasks. It should include methods for adding, updating, and deleting tasks.
Implement the Memento class to store the state of the TaskManager at different points in time.
The TaskManager should have methods to create a new Memento object, restore the state from a Memento, undo the last action, 
and redo the last undone action.
Provide a user interface to interact with the TaskManager, allowing users to perform actions such as adding, updating, 
and deleting tasks, as well as undoing and redoing actions.
*/

// Creating TaskManager instance

using FP.Patterns.Memento.Exercice4;

TaskManager taskManager = new();

// Adding tasks
taskManager.AddTask(new TaskEntity(1, "Implement Memento Pattern", "In Progress"));
taskManager.AddTask(new TaskEntity(2, "Update TaskManager UI", "Pending"));
taskManager.AddTask(new TaskEntity(3, "Test TaskManager Class", "Completed"));

Console.WriteLine("Initial Tasks:");
taskManager.DisplayTasks();

// Updating a task
Console.WriteLine("\nUpdating Task with ID 2...");
taskManager.UpdateTask(2, "Update TaskManager UI - Done", "Completed");
taskManager.DisplayTasks();

// Deleting a task
Console.WriteLine("\nDeleting Task with ID 1...");
taskManager.RemoveTask(1);
taskManager.DisplayTasks();

// Undoing last action
Console.WriteLine("\nUndoing last action...");
taskManager.RestoreState();
taskManager.DisplayTasks();