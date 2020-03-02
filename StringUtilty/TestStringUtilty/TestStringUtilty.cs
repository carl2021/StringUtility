using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilty;

namespace TestStringUtilty
{
    [TestClass]
    public class TestStringUtilty
    {
        [TestMethod]
        public void TestStringSingleChar()
        {
            //Assert
            string stringToTest = "Hotdog";
            //Arrange
            string stringToFind = "d";
            int expectedresult = 1;
            //Act
            StringUtility obj = new StringUtility();
            int actualresult = obj.NumberOfOcc(stringToTest, stringToFind);

            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void TestStringMultiChar()
        {
            string stringToTest = "Zealand";

            string stringToFind = "a";
            int expectedresult = 2;

            StringUtility obj = new StringUtility();
            int actualresult = obj.NumberOfOcc(stringToTest, stringToFind);

            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void TestStringCaseSen()
        {
            string stringToTest = "Hej mEd dig, jeg hEdder Anderse";

            string stringToFind = "E";
            int expectedresult = 7;

            StringUtility obj = new StringUtility();
            int actualresult = obj.NumberOfOcc(stringToTest, stringToFind);

            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void TestStringNull()
        {
            string stringToTest = null;

            string stringToFind = "E";
            int expectedresult = -1;

            StringUtility obj = new StringUtility();
            int actualresult = obj.NumberOfOcc(stringToTest, stringToFind);

            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void TestStringEmpty()
        {
            string stringToTest = "";

            string stringToFind = "";
            int expectedresult = 1;

            StringUtility obj = new StringUtility();
            int actualresult = obj.NumberOfOcc(stringToTest, stringToFind);

            Assert.AreEqual(expectedresult, actualresult);
        }
    }

}
