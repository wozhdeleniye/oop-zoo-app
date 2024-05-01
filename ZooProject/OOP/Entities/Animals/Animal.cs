public abstract class Animal
{
    public abstract Status status { get; set; }
    public abstract int hunger { get; set; }
    public abstract string name { get; set; }
    public abstract int age { get; set; }
    public virtual void MakeSound()
    {
        // Реализация метода будет в подклассах
    }
    public virtual void Update()
    {
        // Реализация метода будет в подклассах
    }
    public virtual String Status()
    {
        return $"Статус {status}\nГолод {hunger}" ;
    }
}