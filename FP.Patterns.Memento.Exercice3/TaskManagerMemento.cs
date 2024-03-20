namespace FP.Patterns.Memento.Exercice3
{
    public class TaskManagerMemento
    {
        public List<ETask> Tasks { get; }
        public TaskManagerMemento(List<ETask> tasks)
        {
            Tasks = new List<ETask>(tasks);
        }
    }
}
