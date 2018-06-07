using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_EventDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Marine m1 = new Marine();
        private Marine m2 = new Marine();

        private void Form1_Load(object sender, EventArgs e)
        {
//            m1.HPChanged += new EventHandler<HPChangedEventArgs>(Marine_HPChanged);
            m1.HPChanged += Marine_HPChanged;
        }

        private void Marine_HPChanged(object sender, HPChangedEventArgs e)
        {
        }

        private void btnAttackMarine2_Click(object sender, EventArgs e)
        {
            // damage = 나의공격력 - 상대의방어력 * 10

            m1.Attack(m2);

            prbHP2.Value = m2.HP;
            prbHP1.Value = m1.HP;
        }

        private void btnAttackMarine1_Click(object sender, EventArgs e)
        {
            decimal damage = (nudWeapon2.Value - nudArmor1.Value) * 10;
            prbHP1.Value -= (int)damage;
        }
    }
}
