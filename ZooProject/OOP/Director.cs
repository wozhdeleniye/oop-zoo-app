using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

        public void AddAnimal(int i, String name)
        {
            switch (i)
            {
                case 1:
                    zoo.animals.Add(new Capibara(name));
                    break;
                case 2:
                    zoo.animals.Add(new Wolf(name));
                    break;
                case 3:
                    zoo.animals.Add(new Wolf(name));
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
        public void AddStuff(String name,Gender gender, Animal animal)
        {
            zoo.people.Add(new Stuff(name, gender, animal));
            zoo.stuff.Add(new Stuff(name, gender, animal));
        }
        public void AddVisitor(String name, Gender gender)
        {
            zoo.people.Add(new Visitor(name, gender));
        }
        public void EditVisitor(String name, Gender gender, Human human)
        {
            human.name = name;
            human.gender = gender;
        }
        public void EditStuff(String name, Gender gender, Stuff human, Animal hisAnimal)
        {
            human.name = name;
            human.gender = gender;
            human.hisAnimal = hisAnimal;
        }
        public void EditAnimal(String name, Animal animal)
        {
            animal.name = name;
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
            foreach(var stuff in zoo.stuff)
            {
                if(stuff.hisAnimal == animal)
                {
                    stuff.hisAnimal = null;
                }
            }
        }
    }
}
