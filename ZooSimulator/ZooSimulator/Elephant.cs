using System;

namespace ZooSimulator
{
    public class Elephant : Animal
    {
        private bool _canWalk;

        public Elephant()
        {
            _canWalk = true;
        }

        public bool CanWalk
        {
            get { return _canWalk; }
            set { _canWalk = value; }
        }

        public void HealthChanged()
        {
            int health = (int)this.Health;

            this.Alive = (health > 0) ? true : false;

            if ((_canWalk) && (health < 70))
                _canWalk = false;

            if ((!_canWalk) && (health > 70))
                _canWalk = true;

            if ((!_canWalk) && (health < 70))
            {
                this.Health = 0.0F;
                this.Alive = false;
            }

        }
    }
}