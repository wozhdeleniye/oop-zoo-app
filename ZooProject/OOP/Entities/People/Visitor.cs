using System.Security.Cryptography;

public class Visitor : Human
{
    public override string name { get; set; }
    public override HumanType type { get; set; }
    public override Gender gender { get; set; }


    public Visitor(String name, Gender gender)
    {
        this.name = name;
        this.type = HumanType.Visitor;
        this.gender = gender;
    }
    public String Status()
    {
        if (gender == Gender.Male) return "- " + name + "- Мужчина";
        else return "- " + name + "\n- Женщина";
    }
}