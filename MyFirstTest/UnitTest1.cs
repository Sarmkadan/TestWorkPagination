using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace MyFirstTest
{
    [TestClass] 
    public class UnitTest1
    {
       private int[] _mylista = new int[] { 0, 1, 6, 7, 7, 7, 100, 100, 100, 11, 9, 11, 11 };
       private int[] _myListb = new int[] { 0, 1, 3, 2, 3, 4, 50, 1, 100, 6, 5, 5, 4 };
        [TestMethod]
        public void Pagingv0()
        {

            string[] expected = new string[] {0.ToString()};
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[0], _myListb[0]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv1()
        {
            string[] expected = new string[] { 1.ToString() };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[1], _myListb[1]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv2()
        {
            string[] expected = new string[] { "1","2","3","4","5","6" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[2], _myListb[2]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv3()
        {
            string[] expected = new string[] { "1", "2", "3", "...", "5", "6","7" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[3], _myListb[3]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv4()
        {
            string[] expected = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[4], _myListb[4]);
            CollectionAssert.AreEqual(expected, result);
            
        }
        [TestMethod]
        public void Pagingv5()
        {
            string[] expected = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[5], _myListb[5]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv6()
        {
            string[] expected = new string[] { "1", "2", "3", "...", "49", "50", "51", "...", "98", "99", "100" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[6], _myListb[6]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv7()
        {
            string[] expected = new string[] { "1", "2", "3", "...", "98", "99", "100" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[7], _myListb[7]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv8()
        {
            string[] expected = new string[] { "1", "2", "3", "...", "98", "99", "100" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[8], _myListb[8]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv9()
        {
            string[] expected = new string[] { "1", "2", "3", "...", "5", "6", "7", "...", "9", "10", "11" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[9], _myListb[9]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv10()
        {
            string[] expected = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[10], _myListb[10]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv11()
        {
            string[] expected = new string[] { "1", "2", "3", "4", "5", "6", "...", "9", "10", "11" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(_mylista[11], _myListb[11]);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv12()
        {
            string[] expected = new string[] { "1", "2", "3", "...", "39", "40", "41", "...", "58", "59", "60" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(60, 40);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv13()
        {
            string[] expected = new string[] { "1", "2", "3", "4", "5", "6"};
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(6, 4);
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Pagingv14()
        {
            string[] expected = new string[] { "1", "2", "3", "...", "5", "6", "7", "...", "18", "19", "20" };
            var myClass = new PagingMethod();
            string[] result = myClass.GetPagesv3(20, 6);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}

