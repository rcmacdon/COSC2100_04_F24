using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Demo_w13b_UnitTesting;

namespace Demo_w13b_UnitTesting_TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_TempCalcFtoC_01()
        {
            decimal expected = 0;
            decimal actual = Tools.ConvertFtoC(32);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_TempCalcFtoC_02()
        {
            decimal expected = 100;
            decimal actual = Tools.ConvertFtoC(212);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_TempCalcFtoC_03()
        { 
            decimal expected = -44.44m;
            decimal actual = Tools.ConvertFtoC(-48m);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test_PopulateTrainers_01()
        {
            Trainer.PopulateTrainers();
            Assert.AreEqual(48, Trainer.trainers.Count);
        }

        [TestMethod]
        public void Test_InsertTrainer_01()
        {
            Trainer t = new Trainer(0, "John", "Doe", 25, "North");
            Boolean result = Trainer.AddTrainer(t);
            Assert.IsTrue(result);
        }

    }
}
