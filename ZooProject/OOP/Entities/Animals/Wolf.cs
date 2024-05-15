using OOP.Aviary;

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
        type = AnimalType.Wolf;
        mealType = AnimalMealType.Predator;
    }

    public override void MakeSound()
    {
        Console.WriteLine(name + ": " + sound);
    }

    public override void Update(Aviary aviary)
    {
        int food = 70;
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
        if (hunger <= 50)
        {
            status = global::Status.Hungry;
        }
        else status = global::Status.Fulled;
    }
}