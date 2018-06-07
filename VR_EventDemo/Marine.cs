using System;

namespace VR_EventDemo
{
    public class Marine
    {
        public Marine()
        {
            HP = 100;
            Weapon = 1;
            Armor = 1;
        }

        private int _hp;

        public int HP
        {
            get { return _hp; }
            set
            {
                // HPChanging
                _hp = value;
                
                OnHPChanged(_hp);   
            }
        }

        public int Weapon { get; set; }
        public int Armor { get; set; }

        public void Attack(Marine target)
        {
            int damage = (Weapon - target.Armor) * 10;
            target.HP -= damage;
            this.HP -= damage / 2;
        }

        public event EventHandler<HPChangedEventArgs> HPChanged;

        protected virtual void OnHPChanged(int hp)
        {
            if (HPChanged != null)
                HPChanged(this, new HPChangedEventArgs(hp));
        }
    }

    public class HPChangedEventArgs : EventArgs
    {
        public HPChangedEventArgs(int hp)
        {
            HP = hp;
        }

        public int HP { get; set; }
    }
}