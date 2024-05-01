namespace ZooProject
{
    public class Zoo
    {
        public List<Animal> animals;
        public List<Human> people;
        public List<Stuff> stuff;
        public Zoo() 
        {
            animals = new List<Animal>();
            people = new List<Human>();
            stuff = new List<Stuff>();
        }
        public String Status()
        {
            return $"Количество животных: {animals.Count}\nКоличество посетителей: {people.Count - stuff.Count}\nКоличество работников: {stuff.Count}\n";
        }
    }
}