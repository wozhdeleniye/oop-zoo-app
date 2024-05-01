class Capibara : Animal
{
    private string sound;

    public string Sound
    {
        get { return sound; }
        private set { sound = value; }
    }

    public Capibara(String newName)
    {
        hunger = 51;
        status = global::Status.Fulled;
        sound = "......";
        name = newName;
        age = 0;
    }

    public override void MakeSound()
    {
        Console.WriteLine(name + ": "+ sound);
    }

    public override void Update()
    {
        hunger -= 1;
        if (hunger <= 50)
        {
            status = global::Status.Hungry;
        }
        else status = global::Status.Fulled;
    }

    public override Status status { get; set; }
    public override int hunger { get; set; }
    public override string name { get; set; }
    public override int age { get; set; }
}