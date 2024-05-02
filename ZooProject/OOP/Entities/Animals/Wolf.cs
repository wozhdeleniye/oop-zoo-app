class Wolf : Animal
{
    private string sound;

    public string Sound
    {
        get { return sound; }
        private set { sound = value; }
    }

    public Wolf(String newName)
    {
        hunger = 70;
        status = global::Status.Fulled;
        sound = "Woof wooof WOOOF!";
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
        if (hunger <= 50)
        {
            status = global::Status.Hungry;
        }
        else status = global::Status.Fulled;
    }
}