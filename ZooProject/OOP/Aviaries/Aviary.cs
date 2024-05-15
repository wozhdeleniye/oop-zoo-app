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
            Food = 500;
            maxCapacity = 15;
            animals = new Dictionary<Animal, bool>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal, true);
            Console.WriteLine($"{animal.getName()} добавлен в вольер.");
        }

        public void RemoveAnimal(Animal animal)
        {
            if (animals.Keys.Contains(animal))
            {
                animals.Remove(animal);
                Console.WriteLine($"{animal.getName()} удален из вольера.");
            }
            else
            {
                Console.WriteLine($"{animal.getName()} не найден в вольере.");
            }
        }

        public string DisplayStatus()
        {
            String animalsStatus = "";
            foreach (var animal in animals)
            {
                string inAviaryString;
                if (animal.Value) inAviaryString = " В вольере";
                else inAviaryString = " Не в вольере";
                animalsStatus += animal.Key.getName() + $" {inAviaryString}\n";
            }
            return "Название: " + Name + "\nКоличество еды:" + Food + "\nЖивотные:\n" + animalsStatus;
        }

        public void changeLocation()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 1);
            if(value == 0)
            {
                value = rnd.Next(0, animals.Count()-1);

                if (animals.ElementAt(value).Value) animals[animals.ElementAt(value).Key] = false;
                else animals[animals.ElementAt(value).Key] = true;
            }
        }

        public List<Animal> animalsList()
        {
            return animals.Keys.ToList();
        }

        public Dictionary<Animal, bool> animalsListForVisitors()
        {
            return animals;
        }

        public bool getCapability(AnimalType type)
        {
            if (animals.Count == 0)
            {
                return true;
            }
            else
            {
                if (animals.First().Key.getType() == type)
                {
                    int filled = 0;
                    foreach(var animal in animals)
                    {
                        filled += getAnimalSize(animal.Key.getType());
                    }
                    if (filled + getAnimalSize(animals.First().Key.getType()) <= maxCapacity)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            
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
