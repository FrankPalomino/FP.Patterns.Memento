namespace FP.Patterns.Memento.Exercice4
{
    public class TaskManager
    {
        public List<TaskEntity> TaskList;
        private TaskManagerMemento _memento;

        public TaskManager()
        {
            TaskList = [];
            _memento = new TaskManagerMemento();
        }

        public void AddTask(TaskEntity task)
        {
            SaveState();
            TaskList.Add(task);
        }

        public void UpdateTask(int id, string description, string status)
        {
            SaveState();
            TaskEntity task = TaskList.Find(x => x.Id.Equals(id));
            if (task != null)
            {
                task.Description = description;
                task.Status = status;
            }
        }

        public void RemoveTask(int id)
        {
            SaveState();
            TaskEntity task = TaskList.Find(x => x.Id.Equals(id));
            if (task != null)
            {
                TaskList.Remove(task);
            }
        }

        public void DisplayTasks()
        {
            foreach (var task in TaskList)
            {
                task.Display();
            }
        }

        public void SaveState()
        {
            _memento.Save(new List<TaskEntity>(TaskList));
        }

        public void RestoreState()
        {
            List<TaskEntity> list = _memento.Restore();
            TaskList = list;
        }
    }
}
