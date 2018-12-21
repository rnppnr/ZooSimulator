using System;

namespace ZooSimulator
{
    public class Animal
    {
        private float _health;
        private bool _alive;

        public string Id { get; set; }        

        public Animal()
        {
            _health = 100.0F;
            _alive = true;
        }

        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        public float Health
        {
            get { return _health; }
            set
            {
                _health = value;
                if (_health > 100.0F )
                    _health = 100.0F;
            }
        }        
    }
}