namespace FP.Patterns.Memento.Exercice4
{
    public class TaskManagerMemento
    {
        public Stack<List<TaskEntity>> Tasks;

        public TaskManagerMemento() { Tasks = []; }

        public void Save(List<TaskEntity> taskManager)
        {
            Tasks.Push(taskManager);
        }

        public List<TaskEntity> Restore()
        {
            return Tasks.Pop();
        }
    }
}
