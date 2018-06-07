using Microsoft.VisualStudio.TestTools.UnitTesting;
using VR_EventDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR_EventDemo.Tests
{
    [TestClass()]
    public class MarineTests
    {
        [TestMethod()]
        public void AttackTest()
        {
            Marine m1 = new Marine();
            Marine m2 = new Marine();

            m1.Weapon = 3;

            m1.Attack(m2);

            Assert.AreEqual(80, m2.HP);
        }
    }
}