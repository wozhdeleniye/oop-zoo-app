﻿class Capibara : Animal
{
    private string sound;

    public string Sound
    {
        get { return sound; }
        private set { sound = value; }
    }

    public Capibara(String newName)
    {
        hunger = 40;
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
        if (hunger <= 20)
        {
            status = global::Status.Hungry;
        }
        else status = global::Status.Fulled;
    }
}