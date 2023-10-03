namespace FP.Patterns.Memento
{
    [Serializable]
    public class Originator
    {
        private string name;
        private int model;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Originator(string name, int model, double price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1}, with prince of {2}", name, model, price);
        }

        public Memento CreateMemento()
        {
            Memento m = new Memento();
            m.Save(this);
            return m;
        }

        public void Restore(Memento m)
        {
            Originator originator = m.Restore();
            this.name = originator.name;
            this.model = originator.model;
            this.price = originator.price;

        }
    }
}
