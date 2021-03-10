using C_1_base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class Tests1
    {
        [TestMethod]
        public void SquerTrangle1()
        {
            Assert.AreEqual(3.0, YourTasksHere1.SquerOfTrungle(3, 2));
        }

        [TestMethod]
        public void SquerTrangle2()
        {
            Assert.AreEqual(1.5, YourTasksHere1.SquerOfTrungle(3, 1));
        }

        [TestMethod]
        public void SquerTrangle3()
        {
            Assert.AreEqual(5.0, YourTasksHere1.SquerOfTrungle(1, 10));
        }

        [TestMethod]
        public void isTrungle1()
        {
            Assert.AreEqual(true, YourTasksHere1.isTrungle(1, 1, 1));
        }

        [TestMethod]
        public void isTrungle2()
        {
            Assert.AreEqual(false, YourTasksHere1.isTrungle(1, 3, 1));
            Assert.AreEqual(false, YourTasksHere1.isTrungle(3, 1, 1));
            Assert.AreEqual(false, YourTasksHere1.isTrungle(1, 1, 3));
        }

        [TestMethod]
        public void isTrungle3()
        {
            Assert.AreEqual(true, YourTasksHere1.isTrungle(2, 2, 1));
            Assert.AreEqual(true, YourTasksHere1.isTrungle(1, 2, 2));
            Assert.AreEqual(true, YourTasksHere1.isTrungle(2, 1, 2));
        }

        [TestMethod]
        public void isTrungle4()
        {
            Assert.AreEqual(true, YourTasksHere1.isTrungle(5, 4, 3));
            Assert.AreEqual(true, YourTasksHere1.isTrungle(4, 3, 5));
            Assert.AreEqual(true, YourTasksHere1.isTrungle(3, 5, 4));
            Assert.AreEqual(true, YourTasksHere1.isTrungle(5, 3, 4));
            Assert.AreEqual(true, YourTasksHere1.isTrungle(4, 5, 3));
            Assert.AreEqual(true, YourTasksHere1.isTrungle(3, 4, 5));
        }

        [TestMethod]
        public void Arifmetika1()
        {
            Assert.AreEqual(3, YourTasksHere1.Arifmetika(1, 2));
        }

        [TestMethod]
        public void Arifmetika2()
        {
            Assert.AreEqual(-3, YourTasksHere1.Arifmetika(-1, -2));
        }

        [TestMethod]
        public void Arifmetika3()
        {
            Assert.AreEqual(3, YourTasksHere1.Arifmetika(-1, 2));
        }

        [TestMethod]
        public void Arifmetika4()
        {
            Assert.AreEqual(2, YourTasksHere1.Arifmetika(1, -1));
        }

        [TestMethod]
        public void Arifmetika5()
        {
            Assert.AreEqual(3, YourTasksHere1.Arifmetika(1, -2));
        }

        [TestMethod]
        public void Fuc1()
        {
            Assert.AreEqual(1, YourTasksHere1.Fuc(1));
        }

        [TestMethod]
        public void Fuc2()
        {
            Assert.AreEqual(2, YourTasksHere1.Fuc(2));
        }

        [TestMethod]
        public void Fuc3()
        {
            Assert.AreEqual(6, YourTasksHere1.Fuc(3));
        }

        [TestMethod]
        public void Fuc4()
        {
            Assert.AreEqual(24, YourTasksHere1.Fuc(4));
        }

        [TestMethod]
        public void ArrayCreate1()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, YourTasksHere1.ArrayCreate(1));
        }

        [TestMethod]
        public void ArrayCreate2()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, YourTasksHere1.ArrayCreate(3));
        }

        [TestMethod]
        public void ArrayCreate3()
        {
            CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, YourTasksHere1.ArrayCreate(5));
        }

        [TestMethod]
        public void MaxSearch1()
        {
            Assert.AreEqual(0, YourTasksHere1.MaxSearch(new int[] { -1 }));
        }

        [TestMethod]
        public void MaxSearch2()
        {
            Assert.AreEqual(1, YourTasksHere1.MaxSearch(new int[] { -1, 1, 1, 0, -10, 1 }));
        }

        [TestMethod]
        public void MaxSearch3()
        {
            Assert.AreEqual(5, YourTasksHere1.MaxSearch(new int[] { 1, 2, 3, 4, 5, 6 }));
        }

        [TestMethod]
        public void ArrayCopy()
        {
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            CollectionAssert.AreEqual(array, YourTasksHere1.ArrayCopy(array));
            Assert.AreNotEqual(array, YourTasksHere1.ArrayCopy(array));
        }

        [TestMethod]
        public void Fibobachi1()
        {
            Assert.AreEqual(1, YourTasksHere1.Fibonachi(1));
        }

        [TestMethod]
        public void Fibobachi2()
        {
            Assert.AreEqual(2, YourTasksHere1.Fibonachi(2));
        }

        [TestMethod]
        public void Fibobachi3()
        {
            Assert.AreEqual(3, YourTasksHere1.Fibonachi(3));
        }


        [TestMethod]
        public void Fibobachi4()
        {
            Assert.AreEqual(5, YourTasksHere1.Fibonachi(4));
        }

        [TestMethod]
        public void Fibobachi5()
        {
            Assert.AreEqual(8, YourTasksHere1.Fibonachi(5));
        }


        [TestMethod]
        public void HardArray1()
        {
            int[] array = new int[] { 1, 2, 3, 8, -1, 0 };
            int[] outarray;
            Assert.AreEqual(8, YourTasksHere1.HardArray(array, out outarray));
            CollectionAssert.AreEqual(array, outarray);
            Assert.AreNotEqual(array, outarray);
        }

        [TestMethod]
        public void HardArray2()
        {
            int[] array = new int[] { -1 };
            int[] outarray;
            Assert.AreEqual(-1, YourTasksHere1.HardArray(array, out outarray));
            CollectionAssert.AreEqual(array, outarray);
            Assert.AreNotEqual(array, outarray);
        }

        [TestMethod]
        public void HardArray3()
        {
            int[] array = new int[] { -1, 2, 5 };
            int[] outarray;
            Assert.AreEqual(5, YourTasksHere1.HardArray(array, out outarray));
            CollectionAssert.AreEqual(array, outarray);
            Assert.AreNotEqual(array, outarray);
        }

        [TestMethod]
        public void Fight1()
        {
            int f = 100, s = 100;
            YourTasksHere1.Fight(ref f, 10, ref s, 10);
            Assert.AreEqual(0, f);
            Assert.AreEqual(0, s);
        }

        [TestMethod]
        public void Fight2()
        {
            int f = 10, s = 100;
            YourTasksHere1.Fight(ref f, 10, ref s, 1);
            Assert.AreEqual(0, f);
            Assert.AreEqual(0, s);
        }

        [TestMethod]
        public void Figh3()
        {
            int f = 10, s = 100;
            YourTasksHere1.Fight(ref f, 5, ref s, 1);
            Assert.AreEqual(0, f);
            Assert.AreEqual(50, s);
        }

        [TestMethod]
        public void Figh4()
        {
            int f = 3, s = 4;
            YourTasksHere1.Fight(ref f, 2, ref s, 5);
            Assert.AreEqual(-2, f);
            Assert.AreEqual(2, s);
        }

        [TestMethod]
        public void Figh5()
        {
            int f = 0, s = 4;
            YourTasksHere1.Fight(ref f, 2, ref s, 5);
            Assert.AreEqual(0, f);
            Assert.AreEqual(4, s);
        }
    }
}
