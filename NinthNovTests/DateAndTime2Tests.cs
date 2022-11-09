using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinthNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace NinthNov.Tests
{
    [TestClass()]
    public class DateAndTime2Tests
    {
        DateAndTime2 wish = new DateAndTime2();
        [TestMethod()]
        public void datetimeTests() {
            Assert.AreEqual("Good Morning", wish.datetime());
        }
    }
}