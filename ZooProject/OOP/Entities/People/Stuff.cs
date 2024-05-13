using OOP.Aviary;
using System.Security.Cryptography;

public class Stuff : Human
{
    public Aviary hisAviary { get; set; }

    public Stuff(String name, Gender gender, Aviary aviary)
    {
        this.name = name;
        this.type = HumanType.Stuff;
        this.gender = gender;
        hisAviary = aviary;
    }
    public override void Update() 
    {
        bool needFood = false;
        hisAviary.animalsList().ToList().ForEach(animal =>
        {
            if(animal.GetStatus() == global::Status.Hungry)
            {
                needFood = true;
            }
        });
        if((needFood) || (hisAviary.getFood()<100))
        {
            hisAviary.putFood(600);
        }
    }
    public override String Status()
    {
        if (gender == Gender.Male) return $"- {name}\n- Мужчина\n- Приглядывает за {hisAviary.getName()}";
        else return name + $", Женщина, \nПриглядывает за {hisAviary.getName()}";
    }
    public void setHisAviary(Aviary aviary)
    {
        hisAviary = aviary;
    }
}
