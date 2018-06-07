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

        private void btnAttackMarine2_Click(object sender, EventArgs e)
        {
            // damage = 나의공격력 - 상대의방어력 * 10

            decimal damage = (nudWeapon1.Value - nudArmor2.Value) * 10;
            prbHP2.Value -= (int)damage;
        }

        private void btnAttackMarine1_Click(object sender, EventArgs e)
        {
            decimal damage = (nudWeapon2.Value - nudArmor1.Value) * 10;
            prbHP1.Value -= (int)damage;
        }
    }
}
