using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private readonly FormValidate validate = new FormValidate();

        [TestMethod]
        [DataRow("Vinod")]
        [DataRow("vinod")]
        public void GivenFirstName_ShouldThrow_TrueOrFalse(string field)
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = validate.FormVal(field, validate.REGEX_NAME);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Vinod")]
        [DataRow("vinod")]
        public void GivenLastName_ShouldThrow_TrueOrFalse(string field)
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = validate.FormVal(field, validate.REGEX_NAME);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("vinod@gmail.com")]
        [DataRow("vinodgmail")]
        public void GivenEmailId_ShouldThrow_TrueOrFalse(string field)
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = validate.FormVal(field, validate.REGEX_EMAIL);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("91 1234567890")]
        [DataRow("1234567890")]
        public void GivenMobileNumber_ShouldThrow_TrueOrFalse(string field)
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = validate.FormVal(field, validate.REGEX_MOBILE);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Vinod@12")]
        [DataRow("vinod@g")]
        public void GivenPassword_ShouldThrow_TrueOrFalse(string field)
        {
            //Arrange
            bool expected = true;

            //Act
            bool result = validate.FormVal(field, validate.REGEX_PASSWORD);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
