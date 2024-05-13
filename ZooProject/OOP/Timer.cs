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
        }
    }
}
