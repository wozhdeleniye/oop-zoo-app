class Giraffe : Animal
{
    private string sound;

    public string Sound
    {
        get { return sound; }
        private set { sound = value; }
    }

    public Giraffe(String newName)
    {
        hunger = 100;
        status = global::Status.Fulled;
        sound = "Awwww! awww";
        name = newName;
        age = 0;
    }

    public override void MakeSound()
    {
        Console.WriteLine(name + ": " + sound);
    }

    public override void Update()
    {
        hunger -= 1;
        if (hunger <= 70)
        {
            status = global::Status.Hungry;
        }
        else status = global::Status.Fulled;
    }
}