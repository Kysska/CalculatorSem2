using WpfApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Back()
        {
            var calc_test = new MyCalc();
            calc_test.num = "777";
            calc_test.Back();
            calc_test.Back();
            calc_test.Back();
            Assert.AreEqual(calc_test.num, "0");
        }
        [TestMethod]
        public void TestMethod_Sum()
        {
            var calc_test = new MyCalc();
            calc_test.num = "0";
            for(int i = 0; i < 101; i++)
            {   
                calc_test.Plus();
                calc_test.num = "10";
                
            }
            Assert.AreEqual(calc_test.result, 1000);
        }
        [TestMethod]
        public void TestMethod_Minus()
        {
            var calc_test = new MyCalc();
            calc_test.num = "6";
            calc_test.Minus();
            calc_test.num = "9";
            calc_test.Plus();
            calc_test.num = "3";
            calc_test.Equality();
            Assert.AreEqual(calc_test.num, "0");
        }
        [TestMethod]
        public void TestMethod_Division()
        {
            var calc_test = new MyCalc();
            calc_test.num = "5";
            calc_test.Division();
            calc_test.num = "100000000000000";
            calc_test.Equality();
            Assert.AreEqual(calc_test.num, "5E-14");
        }
        [TestMethod]
        public void TestMethod_Proc()
        {
            var calc_test = new MyCalc();
            calc_test.num = "5";
            calc_test.Minus();
            calc_test.num = "2";
            calc_test.Proc();
            calc_test.Equality();
            Assert.AreEqual(calc_test.num, "4,9");
        }
        [TestMethod]
        public void TestMethod_Multy()
        {
            var calc_test = new MyCalc();
            calc_test.num = "5";
            calc_test.Multi();
            calc_test.num = "2";
            calc_test.Equality();
            calc_test.Equality();
            calc_test.Equality();
            calc_test.Equality();
            Assert.AreEqual(calc_test.num, "80");
        }
        [TestMethod]
        public void TestMethod_Sqrt()
        {
            var calc_test = new MyCalc();
            calc_test.num = "-2000";
            calc_test.Sqrt();
            Assert.AreEqual(calc_test.num, "Неверный ввод");
        }
        [TestMethod]
        public void TestMethod_Ln()
        {
            var calc_test = new MyCalc();
            calc_test.num = "0";
            calc_test.Ln();
            Assert.AreEqual(calc_test.num, "Неверный ввод");
        }
        [TestMethod]
        public void TestMethod_Pi_Sqr()
        {
            var calc_test = new MyCalc();
            calc_test.num = "0";
            calc_test.Pi();
            calc_test.sqr();
            calc_test.Plus();
            calc_test.Pi();
            calc_test.Equality();
            Assert.AreEqual(calc_test.num, "13,011197054679151");
        }
        [TestMethod]
        public void TestMethod_History1()
        {
            var calc_test = new MyCalc();
            calc_test.num = "0";
            calc_test.MS();
            calc_test.num = "90";
            calc_test.MPlus();
            calc_test.MR();
            Assert.AreEqual(calc_test.num, "90");
        }
        [TestMethod]
        public void TestMethod_History2()
        {
            var calc_test = new MyCalc();
            calc_test.num = "90";
            calc_test.MS();
            calc_test.num = "190";
            calc_test.MPlus();
            calc_test.MC();
            Assert.AreEqual(calc_test.num, "0");
        }
    }
}