using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTests
{
    [TestClass]
    public class AppTests
    {
        [TestMethod]
        public void TestCountBalance()
        { 
            User user1 = new User("msm");

            user1.app.countTotalIncome(10000);
            user1.app.countTotalOutcome(10);

            long result = user1.app.getBalance();
            long expected = 10000-10;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
          public void TestGetBalance()
        { 
            User user1 = new User("msm");

            user1.app.countTotalIncome(10000);
            user1.app.countTotalOutcome();

           long result = user1.app.getBalance();
            long expected = 10000;

            Assert.AreEqual(expected, result);

        }  
         
         [TestMethod]
          public void TestGetAnalysys()
        { 
            User user1 = new User("msm");

            user1.app.countTotalIncome(10000);
            user1.app.countTotalOutcome(10);

           long result = user1.app.getBalance();
            long expected = 10000-10;

            Assert.AreEqual(expected, result);

        }
    }
}