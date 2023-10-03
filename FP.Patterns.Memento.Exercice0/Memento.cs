using System.Text.Json;

namespace FP.Patterns.Memento
{
    public class Memento
    {
        internal void Save(Originator originator)
        {
            Stream stream = new FileStream("memento.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            JsonSerializer.Serialize(stream, originator);
            stream.Close();

            Console.WriteLine("Saved");
        }

        internal Originator Restore()
        {
            Stream stream = new FileStream("memento.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            Originator originator = JsonSerializer.Deserialize<Originator>(stream);
            stream.Close();

            if (originator is null)
            {
                throw new Exception("No memento found");
            }

            Console.WriteLine("Restored");
            return originator;
        }
    }
}
