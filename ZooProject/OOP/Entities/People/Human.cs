public abstract class Human
{
    protected string name;
    protected HumanType type;
    protected Gender gender;

    public virtual void Update()
    {
        // Реализация метода будет в подклассах
    }
    public virtual String Status()
    {
        return "Error";
        // Реализация метода будет в подклассах
    }
    public String getName()
    {
        return name;
    }
    public void setName(String name)
    {
        this.name = name;
    }
    public void setGender(Gender gen)
    {
        this.gender = gen;
    }
    public HumanType getType()
    {
        return type;
    }
}
