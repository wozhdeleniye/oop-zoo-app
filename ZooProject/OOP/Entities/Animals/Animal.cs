public abstract class Animal
{
    protected Status status;
    protected int hunger;
    protected string name;
    protected int age;
    public virtual void MakeSound()
    {
        // Реализация метода будет в подклассах
    }
    public virtual void Update()
    {
        // Реализация метода будет в подклассах
    }
    public void Feed(int food)
    {
        hunger += food;
    }
    public Status GetStatus()
    {
        return status;
    }
    public String Status()
    {
        return $"Статус {status}\nГолод {hunger}" ;
    }
    public String getName()
    {
        return name;
    }
    public void setName(String name)
    {
        this.name = name;
    }
}