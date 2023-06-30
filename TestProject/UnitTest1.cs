using KiselevaBA_01_13;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
        }

        [Test]
        public void BaseClassCalculationTest ()
        {
            BaseClass baseClass = new BaseClass("������������", 4, 12);
            int actual = baseClass.Calcilation();
            int expected = 3;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void BaseClassPrintInfoTest ()
        {
            BaseClass baseClass = new BaseClass("������������", 2, 22);
            string? actual = baseClass.PrintInfo();
            string expected = "��� ������: ������������\n���������� ��� ������: 2\n������� ������: 22\nQ = 11";
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void ChildClassCalculationTest1 ()
        {
            ChildClass childClass = new ChildClass("������", 2, 4, false);
            int actual = childClass.Calcilation();
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ChildClassCalculationTest2 ()
        {
            ChildClass childClass = new ChildClass("������", 2, 4, true);
            int actual = childClass.Calcilation();
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}