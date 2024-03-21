namespace FP.Patterns.Memento.Exercice4
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public TaskEntity(int id, string description, string status)
        {
            Id = id;
            Description = description;
            Status = status;
        }

        public void Display()
        {
            Console.WriteLine($"Task {Id}: {Description}");
        }
    }
}
