using System.Security.Cryptography;

public class Visitor : Human
{
    int cash;
    public Visitor(String name, Gender gender)
    {
        this.name = name;
        this.type = HumanType.Visitor;
        this.gender = gender;
    }
    public override String Status()
    {
        if (gender == Gender.Male) return "- " + name + "- Мужчина";
        else return "- " + name + "\n- Женщина";
    }

    public void Feed(Animal animal, int gluttony)
    {
        animal.getFoodFromVisitor(gluttony);
    }
}