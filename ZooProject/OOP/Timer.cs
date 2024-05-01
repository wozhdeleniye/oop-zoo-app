
namespace ZooProject
{
    public class Timer
    {
        private Zoo zoo;
        public Timer(Zoo zooUser)
        {
            zoo = zooUser;
            TimerCallback tm = new TimerCallback(Tick);
            System.Threading.Timer timer = new System.Threading.Timer(tm, null, 0, 1000);
        }
        private void Tick(object obj)
        {
            foreach (var animal in zoo.animals)
            {
                animal.Update();
            }
            foreach (var employee in zoo.people)
            {
                employee.Update();
            }
        }
    }
}
