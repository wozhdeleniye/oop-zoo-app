using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Aviary
{
    public class Aviary : IAviary
    {
        Dictionary<Animal, bool> animals;

        

        public string Name{ get; }
        int Food;
        public int maxCapacity { get; }

        public Aviary(String name)
        {
            Name = name;
            Food = 0;
            animals = new Dictionary<Animal, bool>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal, true);
            Console.WriteLine($"{animal.getName} добавлен в вольер.");
        }

        public void RemoveAnimal(Animal animal)
        {
            if (animals.Keys.Contains(animal))
            {
                animals.Remove(animal);
                Console.WriteLine($"{animal.getName} удален из вольера.");
            }
            else
            {
                Console.WriteLine($"{animal.getName} не найден в вольере.");
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Животные в вольере:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        public string GetStatus()
        {
            String animalsStatus = "";
            foreach(var animal in animals)
            {
                animalsStatus += animal.Key.getName() + "\n";
            }
            return "Название: " + Name + "\nКоличество еды:" + Food + "\nЖивотные:\n" + animalsStatus;
        }

        public void changeLocation()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 10);
            if(value == 0)
            {
                foreach (var animal in animals)
                {
                    if (animal.Value) animals[animal.Key] = false;
                    else animals[animal.Key] = true;
                }
            }
        }

        public List<Animal> animalsList()
        {
            return animals.Keys.ToList();
        }
        public bool getCapability(AnimalType type)
        {
            if (animals.First().Key.getType() == type)
            {
                if (animals.Count == 0)
                {
                    return true;
                }
                else
                {
                    if (maxCapacity + getAnimalSize(animals.First().Key.getType()) <= maxCapacity)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            else return false;
        }
        private int getAnimalSize(AnimalType type)
        {
            if (type == AnimalType.Giraffe) return 3;
            if (type == AnimalType.Capibara) return 1;
            else return 2;
        }

        public int getFood()
        {
            return Food;
        }

        public void putFood(int food)
        {
            Food += food;
        }

        public void eatFood(int food)
        {
            Food -= food;
        }

        public string getName()
        {
            return Name;
        }
    }
}
