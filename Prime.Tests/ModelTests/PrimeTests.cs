using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Models;
using System.Collections.Generic;
using System;

namespace Prime.Tests
{
    [TestClass]
    public class PrimeTests : IDisposable
    {

        public void Dispose()
        {
            Number.ClearAll();
        }

        [TestMethod]
        public void NumberConstructor_CreatesInstanceOfNumberClass_Number()
        {
            Number newNumber = new Number(0);
            Assert.AreEqual(typeof(Number), newNumber.GetType());
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_NumberList()
        {
            List<Number> newList = new List<Number> { };
            List<Number> result = Number.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsNumbers_NumberList()
        {
            int input01 = 10;
            int input02 = 20;
            Number newList1 = new Number(input01);
            Number newList2 = new Number(input02);
            List<Number> newList = new List<Number> { newList1, newList2 };

            List<Number> result = Number.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }
    }
}