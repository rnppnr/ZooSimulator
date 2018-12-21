using System;

namespace ZooSimulator
{
    public class Giraffe : Animal
    {
        public void HealthChanged()
        {
            this.Alive = ((int)this.Health > 50) ? true : false;
        }
    }
}