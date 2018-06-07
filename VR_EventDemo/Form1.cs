#region
using System;
using System.Windows.Forms;
#endregion

namespace VR_EventDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Marine m1 = new Marine();
        private readonly Marine m2 = new Marine();

        private void Form1_Load(object sender, EventArgs e)
        {
//            m1.HPChanged += new EventHandler<HPChangedEventArgs>(Marine_HPChanged);
            m1.HPChanged += Marine_HPChanged;
            m2.HPChanged += Marine_HPChanged;

            m1.WeaponChanged += Marine_WeaponChanged;
        }

        private void Marine_WeaponChanged(object sender, Marine.WeaponChangedEventArgs e)
        {
            if (sender == m1)
                nudWeapon1.Value = e.Weapon;
            else
                nudWeapon2.Value = e.Weapon;
        }

        private void Marine_HPChanged(object sender, Marine.HPChangedEventArgs e)
        {
            if (sender == m1)
                prbHP1.Value = e.HP;
            else
                prbHP2.Value = e.HP;
        }

        private void btnAttackMarine2_Click(object sender, EventArgs e)
        {
            // damage = 나의공격력 - 상대의방어력 * 10

            m1.Attack(m2);

//            prbHP2.Value = m2.HP;
//            prbHP1.Value = m1.HP;
        }

        private void btnAttackMarine1_Click(object sender, EventArgs e)
        {
            m2.Attack(m1);

//            decimal damage = (nudWeapon2.Value - nudArmor1.Value) * 10;
//            prbHP1.Value -= (int)damage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox) sender;

            textBox2.Text = t1.Text;
        }
    }
}