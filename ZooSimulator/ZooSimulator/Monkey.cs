using System;

namespace ZooSimulator
{
    public class Monkey : Animal
    {
        public void HealthChanged()
        {
        this.Alive = ((int)this.Health > 30) ? true : false;
        }
    }
}