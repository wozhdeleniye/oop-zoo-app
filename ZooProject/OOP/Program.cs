using OOP;
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

            while (true)
            {
                Console.WriteLine("Выберете действие:");
                Console.WriteLine("1. Добавлять нового посетителя/сотрудника/животного");
                Console.WriteLine("2. Редактировать посетителя/сотрудника/животного");
                Console.WriteLine("3. Удалять посетителя/сотрудника/животного");
                Console.WriteLine("4. Проверять статус посетителя/сотрудника/животного/зоопарка");
                Console.WriteLine("5. Приказать животному подать голос");

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
                                Console.WriteLine("Выберите животное:");
                                foreach (var animal in zoo.animals)
                                {
                                    Console.WriteLine($"{animal.name}, 1 - да, 2 - нет");
                                    int answerAnimalName = Convert.ToInt32(Console.ReadLine());
                                    if (answerAnimalName == 1) {
                                        dir.AddStuff(answerName, gen, animal);
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("Выберете действие:");
                                Console.WriteLine("1. Добавить капибару");
                                Console.WriteLine("2. Добавить волка");
                                int answerWhichAnimal = Convert.ToInt32(Console.ReadLine());
                                int whichAnimal = 2;
                                switch (answerWhichAnimal)
                                {
                                    case 1:
                                        whichAnimal = 1;
                                        break;
                                    case 2:
                                        whichAnimal = 2;
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка! Введено некорректное число.");
                                        break;
                                }
                                Console.WriteLine($"Введите имя");
                                String answerNameAnimal = Console.ReadLine();
                                dir.AddAnimal(whichAnimal, answerNameAnimal);
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
                                    if(visitor.type == HumanType.Visitor)
                                    {
                                        Console.WriteLine("Имя:" + visitor.name);
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
                                    if (stuff.type == HumanType.Stuff)
                                    {
                                        Console.WriteLine("Имя:" + stuff.name);
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            Console.WriteLine($"Предыдущее имя: " + stuff.name + " Введите имя:");
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
                                            Console.WriteLine("Выберите животное:");
                                            foreach (var animal in zoo.animals)
                                            {
                                                Console.WriteLine($"{animal.name}, 1 - да, 2 - нет");
                                                int answerAnimalName = Convert.ToInt32(Console.ReadLine());
                                                if (answerAnimalName == 1)
                                                {
                                                    dir.EditStuff(answerName, gen, stuff, animal);
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
                                    Console.WriteLine("Имя:" + animal.name);
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
                                foreach (var person in zoo.people)
                                {
                                    if (person.type == HumanType.Visitor)
                                    {
                                        Console.WriteLine("Имя:" + person.name);
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
                                    if (person.type == HumanType.Visitor)
                                    {
                                        Console.WriteLine("Имя:" + person.name);
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            dir.DeleteVisitor(person);
                                            break;
                                        }
                                    }
                                }
                                break;
                            case 3:
                                Console.WriteLine("Выберите кого удалить, 1 - да, 2 - нет");
                                foreach (var animal in zoo.animals)
                                {
                                    Console.WriteLine("Имя:" + animal.name);
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
                                foreach(var person  in zoo.people)
                                {
                                    if(person.type == HumanType.Visitor)
                                    {
                                        Console.WriteLine("Имя: " + person.name);
                                        int accept = Convert.ToInt32(Console.ReadLine());
                                        if (accept == 1)
                                        {
                                            Console.WriteLine(dir.StatusVisitor(person));
                                            break;
                                        }
                                    }
                                }
                                break;
                            case 2:
                                foreach (var stuff in zoo.stuff)
                                {
                                    Console.WriteLine("Имя: " + stuff.name);
                                    int accept = Convert.ToInt32(Console.ReadLine());
                                    if (accept == 1)
                                    {
                                        Console.WriteLine(dir.StatusStuff(stuff));
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                foreach (var animal in zoo.animals)
                                {
                                    Console.WriteLine("Имя: " + animal.name);
                                    int accept = Convert.ToInt32(Console.ReadLine());
                                    if (accept == 1)
                                    {
                                        Console.WriteLine(animal.Status);
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
                            Console.WriteLine("Имя: " + animal.name);
                            int accept = Convert.ToInt32(Console.ReadLine());
                            if (accept == 1)
                            {
                                animal.MakeSound();
                                break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Ошибка! Введено некорректное число.");
                        break;
                }
            }
        }

    }
}