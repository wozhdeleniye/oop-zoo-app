public abstract class Human
{
    public abstract string name { get; set; }
    public abstract HumanType type { get; set; }
    public abstract Gender gender { get; set; }

    public virtual void Update()
    {
        // Реализация метода будет в подклассах
    }
}
