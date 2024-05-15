using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Aviary
{
    public interface IAviary
    {
        string Name { get; }
        int maxCapacity { get; }
        void AddAnimal(Animal animal);
        void RemoveAnimal(Animal animal);
        string DisplayStatus();
        void putFood(int food);
        void eatFood(int food);
        string getName();
    }
}
