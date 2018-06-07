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

        private int _weapon;
        public int Weapon
        {
            get { return _weapon; }
            set
            {
                _weapon = value;

                OnWeaponChanged(_weapon);
            }
        }

        public int Armor { get; set; }

        public void Attack(Marine target)
        {
            int damage = (Weapon - target.Armor) * 10;
            target.HP -= damage;
            this.HP -= damage / 2;

            target.Weapon++;
        }

        #region HPChanged
        public event EventHandler<HPChangedEventArgs> HPChanged;

        protected virtual void OnHPChanged(int hp)
        {
            if (HPChanged != null)
                HPChanged(this, new HPChangedEventArgs(hp));
        }

        public class HPChangedEventArgs : EventArgs
        {
            public HPChangedEventArgs(int hp)
            {
                HP = hp;
            }

            public int HP { get; set; }
        }
        #endregion

        #region WeaponChanged event things for C# 3.0
        public event EventHandler<WeaponChangedEventArgs> WeaponChanged;

        protected virtual void OnWeaponChanged(WeaponChangedEventArgs e)
        {
            if (WeaponChanged != null)
                WeaponChanged(this, e);
        }

        private WeaponChangedEventArgs OnWeaponChanged(int weapon )
        {
            WeaponChangedEventArgs args = new WeaponChangedEventArgs(weapon );
            OnWeaponChanged(args);

            return args;
        }

        private WeaponChangedEventArgs OnWeaponChangedForOut()
        {
            WeaponChangedEventArgs args = new WeaponChangedEventArgs();
            OnWeaponChanged(args);

            return args;
        }

        public class WeaponChangedEventArgs : EventArgs
        {
            public int Weapon { get; set;} 

            public WeaponChangedEventArgs()
            {
            }
	
            public WeaponChangedEventArgs(int weapon )
            {
                Weapon = weapon; 
            }
        }
        #endregion
    }
}