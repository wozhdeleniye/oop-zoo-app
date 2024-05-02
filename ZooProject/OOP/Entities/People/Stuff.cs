using System.Security.Cryptography;

public class Stuff : Human
{
    public Animal hisAnimal { get; set; }

    public Stuff(String name, Gender gender, Animal animal) 
    {
        this.name = name;
        this.type = HumanType.Stuff;
        this.gender = gender;
        hisAnimal = animal;
    }
    public override void Update() 
    {
        if(hisAnimal != null)
        {
            if (hisAnimal.GetStatus() == global::Status.Hungry)
            {
                hisAnimal.Feed(50);
                Console.WriteLine("Покормлено животное: " + hisAnimal.getName());
            }
        }
    }
    public override String Status()
    {
        if (gender == Gender.Male) return $"- {name}\n- Мужчина\n- Приглядывает за {hisAnimal.getName()}";
        else return name + $", Женщина, \nПриглядывает за {hisAnimal.getName()}";
    }
}
