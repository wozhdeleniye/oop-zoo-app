using OOP.Aviary;

namespace ZooProject
{
    public class Timer
    {
        private bool isPaused;
        private Zoo zoo;
        private System.Threading.Timer timer;
        public Timer(Zoo zooUser)
        {
            zoo = zooUser;
            isPaused = false;
            TimerCallback tm = new TimerCallback(Tick);
            timer = new System.Threading.Timer(tm, null, 0, 1000);
        }
        public void Pause()
        {
            isPaused = true;
            timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }

        public void Resume()
        {
            isPaused = false;
            timer.Change(0, 1000);
        }
        private void Tick(object obj)
        {
            foreach (var aviary in zoo.aviaries)
            {
                foreach (var animal in aviary.animalsList())
                {
                    animal.Update(aviary);
                }
            }

            foreach (var employee in zoo.people)
            {
                employee.Update();
            }

            Random rnd = new Random();
            int value = rnd.Next(0, 5);
            if(value == 0)
            {
                foreach (var aviary in zoo.aviaries)
                {
                    aviary.changeLocation();
                }
            }

            if((zoo.animals.Count > 0) && ( zoo.aviaries.Count()>0))
            {
                foreach (var visitor in zoo.visitors)
                {
                    value = rnd.Next(0, 5);
                    if (value == 0)
                    {
                        value = rnd.Next(0, zoo.aviaries.Count()-1);
                        var aviary = zoo.aviaries[value];
                        if (aviary.animalsList().Count() > 0) 
                        {
                            value = rnd.Next(0, aviary.animalsList().Count()-1);
                            if (aviary.animalsListForVisitors().ElementAt(value).Value)//можно добавить проверку на то, голоден ли зверёк
                            {
                                int randomFood = rnd.Next(0, zoo.food.Count() - 1);
                                visitor.Feed(aviary.animalsListForVisitors().ElementAt(value).Key, zoo.food.ElementAt(randomFood).Value);
                            }
                        }
                    }
                }
            }
        }
    }
}
