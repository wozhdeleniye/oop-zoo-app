using System.Security.Cryptography;

public class Stuff : Human
{
    public override string name { get; set; }
    public override HumanType type { get; set; }
    public override Gender gender { get; set; }
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
            if (hisAnimal.status == global::Status.Hungry)
            {
                hisAnimal.hunger += 50;
                Console.WriteLine("Покормлено животное: " + hisAnimal.name);
            }
        }
    }
    public String Status()
    {
        if (gender == Gender.Male) return $"- {name}\n- Мужчина\n- Приглядывает за {hisAnimal.name}";
        else return name + $", Женщина, \nПриглядывает за {hisAnimal.name}";
    }
}
