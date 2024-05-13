using OOP.Aviary;

namespace ZooProject
{
    public class Zoo
    {
        public List<Animal> animals;
        public List<Human> people;
        public List<Stuff> stuff;
        public List<Aviary> aviaries;
        public Zoo() 
        {
            animals = new List<Animal>();
            people = new List<Human>();
            stuff = new List<Stuff>();
            aviaries = new List<Aviary>();
        }
        public String Status()
        {
            return $"Количество животных: {animals.Count}\nКоличество посетителей: {people.Count - stuff.Count}\nКоличество работников: {stuff.Count}\n";
        }

    }
}