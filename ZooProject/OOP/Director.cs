﻿using OOP.Aviary;
using ZooProject;

namespace OOP
{
    public class Director
    {
        private Zoo zoo;

        public Director(Zoo zooUser) 
        {
            zoo = zooUser;
        }

        public void AddAnimal(int i, String name, Aviary.Aviary aviary)
        {
            switch (i)
            {
                case 1:
                    Capibara capibara = new Capibara(name);
                    aviary.AddAnimal(capibara);
                    zoo.animals.Add(capibara);
                    break;
                case 2:
                    Wolf wolf = new Wolf(name);
                    aviary.AddAnimal(wolf);
                    zoo.animals.Add(wolf);
                    break;
                case 3:
                    Giraffe giraffe = new Giraffe(name);
                    aviary.AddAnimal(giraffe);
                    zoo.animals.Add(giraffe);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
        public void AddStuff(String name, Gender gender, Aviary.Aviary aviary)
        {
            zoo.people.Add(new Stuff(name, gender, aviary));
            zoo.stuff.Add(new Stuff(name, gender, aviary));
        }
        public void AddVisitor(String name, Gender gender)
        {
            zoo.people.Add(new Visitor(name, gender));
        }
        public void EditVisitor(String name, Gender gender, Human human)
        {
            human.setName(name);
            human.setGender(gender);
        }
        public void EditStuff(String name, Gender gender, Stuff human, Aviary.Aviary aviary)
        {
            human.setName(name);
            human.setGender(gender);
            human.setHisAviary(aviary);
        }
        public void EditAnimal(String name, Animal animal)
        {
            animal.setName(name);
        }
        public void DeleteVisitor(Human person)
        {
            zoo.people.Remove(person);
        }
        public void DeleteStuff(Stuff person)
        {
            zoo.stuff.Remove(person);
        }
        public void DeleteAnimal(Animal animal)
        {
            zoo.animals.Remove(animal);
            foreach(var aviary in zoo.aviaries)
            {
                if(aviary.animalsList().Exists(p => p == animal))
                {
                    aviary.RemoveAnimal(animal);
                }
            }
        }

        public void CreateAviary(String name)
        {
            zoo.aviaries.Add(new Aviary.Aviary(name));
        }

        /*public void AddAnimalToAviary(Animal animal, Aviary.Aviary aviary)
        {
            if (aviary.getCapability(animal.getType()))
            {
                aviary.AddAnimal(animal);
            }
        }*/

        public void GetAviaryStatus(Aviary.Aviary aviary)
        {
            aviary.GetStatus();
        }
    }
}
