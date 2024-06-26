﻿using OOP;
using OOP.Aviary;
using System;

namespace ZooProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Timer timer = new Timer(zoo);
            Director dir = new Director(zoo);

            //автозаполнение
            Random rnd = new Random();

            dir.AddFood("Еда1", 40);
            for (int i = 0; i < 8; i++)
            {
                dir.CreateAviary($"Вольер{i}");

                int value = rnd.Next(0, 1);
                Gender gen;
                if (value == 0) gen = Gender.Male;
                else gen = Gender.Female;
                dir.AddStuff($"Сотрудник{i}", gen, zoo.aviaries.Last());

                value = rnd.Next(0, 1);
                if (value == 0) gen = Gender.Male;
                else gen = Gender.Female;

                dir.AddVisitor($"Посетитель{i}", gen);
            }
            while (zoo.animals.Count()<15)
            {
                for (int i = 0; i < 30; i++)
                {
                    foreach (var aviary in zoo.aviaries)
                    {
                        int value = rnd.Next(1, 3);
                        AnimalType type;
                        string animalTypeStr;
                        if (value == 1) { type = AnimalType.Capibara; animalTypeStr = "Капибара"; }
                        if (value == 2) { type = AnimalType.Wolf; animalTypeStr = "Волк"; }
                        else { type = AnimalType.Giraffe; animalTypeStr = "Жираф"; }
                        if (aviary.getCapability(type))
                        {
                            dir.AddAnimal(value, $"{animalTypeStr}{i}", aviary);
                        }
                    }
                }
            }
            


            int aviaryNumber = 0;
            while (true)
            {
                Console.WriteLine("Выберете действие:");
                Console.WriteLine("1. Добавлять нового посетителя/сотрудника/животного");
                Console.WriteLine("2. Редактировать посетителя/сотрудника/животного");
                Console.WriteLine("3. Удалять посетителя/сотрудника/животного");
                Console.WriteLine("4. Проверять статус посетителя/сотрудника/животного/зоопарка");
                Console.WriteLine("5. Приказать животному подать голос");
                Console.WriteLine("6. Остановить таймер");
                Console.WriteLine("7. Возобновить таймер");
                Console.WriteLine("8. Создать вольер");
                Console.WriteLine("9. Проверить статус вольера");
                Console.WriteLine("10. Добавить еду");

                int answerNumber = Convert.ToInt32(Console.ReadLine());

                switch (answerNumber)
                {
                    case 1:
                        Console.WriteLine("Выберете действие:");
                        Console.WriteLine("1. Добавлять нового посетителя");
                        Console.WriteLine("2. Добавлять нового сотрудника");
                        Console.WriteLine("3. Добавлять нового животного");

                        int answerTwoNumber = Convert.ToInt32(Console.ReadLine());
                        String answerName;
                        int answerGender;
                        Gender gen;
                        switch (answerTwoNumber)
                        {
                            case 1:
                                Console.WriteLine($"Введите имя:");
                                answerName = Console.ReadLine();
                                Console.WriteLine($"Введите пол: 1 - муж, 2 - женщина");
                                answerGender = Convert.ToInt32(Console.ReadLine());
                                switch (answerGender)
                                {
                                    case 1:
                                        Console.WriteLine("Мужчина");
                                        break;
                                    case 2:
                                        Console.WriteLine("Женщина");
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка! Введено некорректное число.");
                                        break;
                                }
                                gen = Gender.Male;
                                if (answerGender == 1) gen = Gender.Female;
                                else if (answerGender == 2) gen = Gender.Female;
                                dir.AddVisitor(answerName, gen);
                                break;
                            case 2:
                                Console.WriteLine($"Введите имя:");
                                answerName = Console.ReadLine();
                                Console.WriteLine($"Введите пол: 1 - муж, 2 - женщина");
                                answerGender = Convert.ToInt32(Console.ReadLine());
                                switch (answerGender)
                                {
                                    case 1:
                                        Console.WriteLine("Мужчина");
                                        break;
                                    case 2:
                                        Console.WriteLine("Женщина");
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка! Введено некорректное число.");
                                        break;
                                }
                                gen = Gender.Male;
                                if (answerGender == 1) gen = Gender.Female; 
                                else if (answerGender == 2) gen = Gender.Female;
                                Console.WriteLine("Выберите вольер:");
                                foreach (var aviary in zoo.aviaries)
                                {
                                    Console.WriteLine($"{aviary.getName()}, 1 - да, 2 - нет");
                                    int answerAnimalName = Convert.ToInt32(Console.ReadLine());
                                    if (answerAnimalName == 1) {
                                        dir.AddStuff(answerName, gen, aviary);
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                
                                Console.WriteLine("Выберете действие:");
                                Console.WriteLine("1. Добавить капибару");
                                Console.WriteLine("2. Добавить волка");
                                Console.WriteLine("3. Добавить жирафа");
                                int answerWhichAnimal = Convert.ToInt32(Console.ReadLine());
                                int whichAnimal = 4;
                                AnimalType type = AnimalType.Capibara;
                                switch (answerWhichAnimal)
                                {
                                    case 1:
                                        whichAnimal = 1;
                                        type = AnimalType.Capibara;
                                        break;
                                    case 2:
                                        whichAnimal = 2;
                                        type = AnimalType.Wolf;
                                        break;
                                    case 3:
                                        whichAnimal = 3;
                                        type = AnimalType.Giraffe;
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка! Введено некорректное число.");
                                        break;
                                }
                                Console.WriteLine($"Введите имя");
                                String answerNameAnimal = Console.ReadLine();
                                if (whichAnimal != 4)
                                {
                                    Console.WriteLine("Выберете вольер:");
                                    foreach (var aviary in zoo.aviaries)
                                    {
                                        Console.WriteLine($"{aviary.getName()}, 1 - да, 2 - нет");
                                        int answerAnimalName = Convert.ToInt32(Console.ReadLine());
                                        if (answerAnimalName == 1)
                                        {
                                            if (aviary.getCapability(type))
                                            {

                                                dir.AddAnimal(whichAnimal, answerNameAnimal, aviary);
                                            }
                                            else Console.WriteLine("Вольер занят, нельзя добавить животное");
                                            break;
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Ошибка! Введено некорректное число.");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Выберете действие:");
                        Console.WriteLine("1. Редактировать посетителя");
                        Console.WriteLine("2. Редактировать сотрудника");
                        Console.WriteLine("3. Редактировать животное");
                        int answerThreeNumber = Convert.ToInt32(Console.ReadLine());
                        switch (answerThreeNumber)
                        {
                            
                            case 1:
                                Console.WriteLine("Выберите кого будете редактировать, 1 - да, 2 - нет");
                                foreach (var visitor in zoo.people)
                                {
                                    if(visitor.getType() == HumanType.Visitor)
                                    {
                                        Console.WriteLine("Имя:" + visitor.getName());
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            Console.WriteLine($"Введите имя:");
                                            answerName = Console.ReadLine();
                                            Console.WriteLine($"Введите пол: 1 - муж, 2 - женщина");
                                            answerGender = Convert.ToInt32(Console.ReadLine());
                                            switch (answerGender)
                                            {
                                                case 1:
                                                    Console.WriteLine("Мужчина");
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Женщина");
                                                    break;
                                                default:
                                                    Console.WriteLine("Ошибка! Введено некорректное число.");
                                                    break;
                                            }
                                            gen = Gender.Male;
                                            if (answerGender == 1) gen = Gender.Female;
                                            else if (answerGender == 2) gen = Gender.Female;
                                            dir.EditVisitor(answerName, gen, visitor);
                                            break;
                                        }
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Выберите кого будете редактировать, 1 - да, 2 - нет");
                                foreach (var stuff in zoo.stuff)
                                {
                                    if (stuff.getType() == HumanType.Stuff)
                                    {
                                        Console.WriteLine("Имя:" + stuff.getName());
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            Console.WriteLine($"Предыдущее имя: " + stuff.getName() + " Введите имя:");
                                            answerName = Console.ReadLine();
                                            Console.WriteLine($"Введите пол: 1 - муж, 2 - женщина");
                                            answerGender = Convert.ToInt32(Console.ReadLine());
                                            switch (answerGender)
                                            {
                                                case 1:
                                                    Console.WriteLine("Мужчина");
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Женщина");
                                                    break;
                                                default:
                                                    Console.WriteLine("Ошибка! Введено некорректное число.");
                                                    break;
                                            }
                                            gen = Gender.Male;
                                            if (answerGender == 1) gen = Gender.Female;
                                            else if (answerGender == 2) gen = Gender.Female;
                                            Console.WriteLine("Выберите вольер:");
                                            foreach (var aviary in zoo.aviaries)
                                            {
                                                Console.WriteLine($"{aviary.getName()}, 1 - да, 2 - нет");
                                                int answerAnimalName = Convert.ToInt32(Console.ReadLine());
                                                if (answerAnimalName == 1)
                                                {
                                                    dir.EditStuff(answerName, gen, stuff, aviary);
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("Выберите кого будете редактировать, 1 - да, 2 - нет");
                                foreach (var animal in zoo.animals)
                                {
                                    Console.WriteLine("Имя:" + animal.getName());
                                    int accept = Convert.ToInt32(Console.ReadLine());
                                    if (accept == 1)
                                    {
                                        Console.WriteLine($"Введите новое имя:");
                                        answerName = Console.ReadLine();
                                        dir.EditAnimal(answerName, animal);
                                        break;
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Ошибка! Введено некорректное число.");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Выберете действие:");
                        Console.WriteLine("1. Удалить посетителя");
                        Console.WriteLine("2. Удалить сотрудника");
                        Console.WriteLine("3. Удалить животного");

                        int answerFourNumber = Convert.ToInt32(Console.ReadLine());

                        switch (answerFourNumber)
                        {
                            case 1:
                                Console.WriteLine("Выберите кого удалить, 1 - да, 2 - нет");
                                foreach (var person in zoo.visitors)
                                {
                                    if (person.getType() == HumanType.Visitor)
                                    {
                                        Console.WriteLine("Имя:" + person.getName());
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            dir.DeleteVisitor(person);
                                            break;
                                        }
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Выберите кого удалить, 1 - да, 2 - нет");
                                foreach (var person in zoo.stuff)
                                {
                                    if (person.getType() == HumanType.Stuff)
                                    {
                                        Console.WriteLine("Имя:" + person.getName());
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            dir.DeleteStuff(person);
                                            break;
                                        }
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("Выберите кого удалить, 1 - да, 2 - нет");
                                foreach (var animal in zoo.animals)
                                {
                                    Console.WriteLine("Имя:" + animal.getName());
                                    int accept = Convert.ToInt32(Console.ReadLine());
                                    if (accept == 1)
                                    {
                                        dir.DeleteAnimal(animal);
                                        break;
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Ошибка! Введено некорректное число.");
                                break;
                        }
                        break;


                    case 4:
                        Console.WriteLine("Выберете действие:");
                        Console.WriteLine("1. Проверить статус посетителя");
                        Console.WriteLine("2. Проверить статус сотрудника");
                        Console.WriteLine("3. Проверить статус животного");
                        Console.WriteLine("4. Проверить статус зоопарка");

                        int answerFiveNumber = Convert.ToInt32(Console.ReadLine());

                        switch (answerFiveNumber)
                        {
                            case 1:
                                foreach(var person in zoo.people)
                                {
                                    if(person.getType() == HumanType.Visitor)
                                    {
                                        Console.WriteLine("Имя: " + person.getName());
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            Console.WriteLine(person.Status());
                                            break;
                                        }
                                    }
                                }
                                break;
                            case 2:
                                foreach (var stuff in zoo.stuff)
                                {
                                    Console.WriteLine("Имя: " + stuff.getName());
                                    int accept = Convert.ToInt32(Console.ReadLine());
                                    if (accept == 1)
                                    {
                                        Console.WriteLine(stuff.Status());
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                foreach (var animal in zoo.animals)
                                {
                                    Console.WriteLine("Имя: " + animal.getName());
                                    int accept = Convert.ToInt32(Console.ReadLine());
                                    if (accept == 1)
                                    {
                                        Console.WriteLine(animal.Status());
                                        break;
                                    }
                                }
                                break;
                            case 4:
                                Console.WriteLine(zoo.Status());
                                break;
                            default:
                                Console.WriteLine("Ошибка! Введено некорректное число.");
                                break;
                        }
                        break;

                    case 5:
                        Console.WriteLine("Выберите животное, которое подаст голос: 1 - да, 2 - нет");
                        foreach(var animal in zoo.animals)
                        {
                            Console.WriteLine("Имя: " + animal.getName());
                            int accept = Convert.ToInt32(Console.ReadLine());
                            if (accept == 1)
                            {
                                animal.MakeSound();
                                break;
                            }
                        }
                        break;
                    case 6:
                        timer.Pause();
                        Console.WriteLine("Таймер остановлен");
                        break;
                    case 7:
                        timer.Resume();
                        Console.WriteLine("Таймер возобновлен");
                        break;
                    case 8:
                        Console.WriteLine("Выберите название вольера:");
                        String name = Console.ReadLine();
                        if (name == null) name = "Вольер" + aviaryNumber;
                        aviaryNumber += 1;
                        dir.CreateAviary(name);
                        break;
                    case 9:
                        Console.WriteLine("Выберите вольер: 1 - да, 2 - нет");
                        foreach (var aviary in zoo.aviaries)
                        {
                            Console.WriteLine("Имя: " + aviary.getName());
                            int accept = Convert.ToInt32(Console.ReadLine());
                            if (accept == 1)
                            {
                                dir.GetAviaryStatus(aviary);
                                break;
                            }
                        }
                        break;
                    case 10:
                        Console.WriteLine("Выберите название еды");
                        name = Console.ReadLine();
                        Console.WriteLine("Выберите нажористость еды");
                        int gluttony = Convert.ToInt32(Console.ReadLine());
                        dir.AddFood(name, gluttony);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Введено некорректное число.");
                        break;
                }
            }
        }

    }
}