namespace FP.Patterns.Memento.Exercice3
{
    public class ETask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public ETask(int id, string description, string status) {
            Id = id;
            Description = description;
            Status = status;
        }

        public void Display()
        {
            Console.WriteLine($"Task ID: {Id}, Description: {Description}, Status: {Status}");
        }
    }
}
