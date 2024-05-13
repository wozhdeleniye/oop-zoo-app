using OOP.Aviary;

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
        type = AnimalType.Giraffe;
    }

    public override void MakeSound()
    {
        Console.WriteLine(name + ": " + sound);
    }

    public override void Update(Aviary aviary)
    {
        int food = 100;
        hunger -= 1;
        
        if (status == global::Status.Hungry)
        {
            if (aviary.getFood() >= food)
            {
                aviary.eatFood(food);
                hunger += food;
            }
            else
            {
                aviary.eatFood(food);
                hunger += aviary.getFood();
            }
        }
        if (hunger <= 70)
        {
            status = global::Status.Hungry;
        }
        else status = global::Status.Fulled;
    }
}