
using System.Threading.Tasks;

namespace FP.Patterns.Memento.Exercice3
{
    public class TaskManager
    {
        private List<ETask> _tasks;
        private Stack<TaskManagerMemento> _mementos;

        public TaskManager()
        {
            _tasks = [];
            _mementos = [];
        }

        public void AddTask(ETask task)
        {
            _tasks.Add(task);
            SaveState();
        }

        public void UpdateTask(long taskId, string newDescription, string newStatus)
        {
            var taskToUpdate = _tasks.Find(x => x.Id == taskId);
            if ( taskToUpdate is not null)
            {
                taskToUpdate.Description = newDescription;
                taskToUpdate.Status = newStatus;
                SaveState();
            }
            else
            {
                Console.WriteLine("Task not found");
            }
        }

        public void RemoveTask(long taskId)
        {
            var taskToDelete = _tasks.Find(x => x.Id == taskId);
            if(  taskToDelete is not null)
            {
                _tasks.Remove(taskToDelete);
                SaveState();
            }
            else
            {
                Console.WriteLine("Task not found");
            }
        }

        private void SaveState()
        {
            _mementos.Push(new TaskManagerMemento(_tasks));
        }

        public void RestoreState()
        {
            if(_mementos.Count > 0)
            {
                TaskManagerMemento memento = _mementos.Pop();
                _tasks = memento.Tasks;
            }
            else
            {
                Console.WriteLine("No previous state available");
            }
        }

        public void DisplayTasks()
        {
            foreach(var task in _tasks)
            {
                task.Display();
            }
        }
    }
}
