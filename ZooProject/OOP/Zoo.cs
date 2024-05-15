using OOP.Aviary;

namespace ZooProject
{
    public class Zoo
    {
        public List<Animal> animals;
        public List<Human> people;
        public List<Stuff> stuff;
        public List<Aviary> aviaries;
        public List<Visitor> visitors;
        public Dictionary<string, int> food;
        public Zoo() 
        {
            animals = new List<Animal>();
            people = new List<Human>();
            stuff = new List<Stuff>();
            aviaries = new List<Aviary>();
            visitors = new List<Visitor>();
            food = new Dictionary<string, int>();
        }
        public String Status()
        {
            string status = $"Количество животных: {animals.Count}\nКоличество посетителей: {people.Count - stuff.Count}\nКоличество работников: {stuff.Count}\nВольеры:\n";
            foreach(var aviary in aviaries)
            {
                status += aviary.DisplayStatus() + "\n";
            }
            return status;
        }


    }
}