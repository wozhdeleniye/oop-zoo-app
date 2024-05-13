using OOP.Aviary;

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
        hunger = 40;
        status = global::Status.Fulled;
        sound = "......";
        name = newName;
        age = 0;
        type = AnimalType.Capibara;
    }

    public override void MakeSound()
    {
        Console.WriteLine(name + ": "+ sound);
    }

    public override void Update(Aviary aviary)
    {
        int food = 40;
        hunger -= 1;
        
        if(status == global::Status.Hungry)
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
        if (hunger <= 20)
        {
            status = global::Status.Hungry;
        }
        else status = global::Status.Fulled;
    }
}