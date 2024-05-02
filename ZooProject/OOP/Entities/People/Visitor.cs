using System.Security.Cryptography;

public class Visitor : Human
{
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
}