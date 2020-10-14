using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using UserRegistrationProblem;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class MatchingPatternsTest
    {
        [TestCategory("First Name")]
        [TestMethod]
        [DataRow("")]
        public void TestingFirstNameForEmptyStringShouldReturnException(string firstNameInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.FirstAndLastName(firstNameInput);
                //Arrange
                Assert.IsTrue(expected, "firstName is not in correct format.");
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "first name and last name can not be empty");
            }
        }
        [TestCategory("First Name")]
        [TestMethod]
        [DataRow(null)]
        public void TestingFirstNameForNULLShouldReturnException(string firstNameInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.FirstAndLastName(firstNameInput);
                //Arrange
                Assert.IsTrue(expected, "firstName is not in correct format.");
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "first name and last name can not be null");
            }
        }
        [TestCategory("First Name")]
        [TestMethod]
        [DataRow("vishal")]
        public void TestingFirstName(string firstNameInput)
        {
            //Arrange
            UserRegistration userRegistration = new UserRegistration();
            //Act
            bool expected = userRegistration.FirstAndLastName(firstNameInput);
            //Arrange
            Assert.IsTrue(expected, "firstName is not in correct format.");
        }

        [TestCategory("Last Name")]
        [TestMethod]
        [DataRow("garg")]
        public void TestingLastName(string lastNameInput)
        {
            //Arrange
            UserRegistration userRegistration = new UserRegistration();
            //Act
            bool expected = userRegistration.FirstAndLastName(lastNameInput);
            //Arrange
            Assert.IsTrue(expected, "LastName is not in correct format.");
        }
        [TestCategory("Last Name")]
        [TestMethod]
        [DataRow("")]
        public void TestingLastNameForEmptyInputShouldReturnCustomException(string lastNameInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.FirstAndLastName(lastNameInput);
                //Arrange
                Assert.IsTrue(expected, "LastName is not in correct format.");
            }
            catch(UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "first name and last name can not be empty");
            }
        }
        [TestCategory("Last Name")]
        [TestMethod]
        [DataRow(null)]
        public void TestingLastNameForNULLShouldReturnCustomException(string lastNameInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.FirstAndLastName(lastNameInput);
                //Arrange
                Assert.IsTrue(expected, "LastName is not in correct format.");
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "first name and last name can not be null");
            }
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("vishal.garg@capgemini.com")]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc111@yahoo.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc+100@gmail.com")]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void TestingEmail(string emailInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.Email(emailInput);
                //Arrange
                Assert.IsTrue(expected, "email is not in correct format.");
            }
            catch(UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "email can not be empty or null");
            }
        }
        [TestMethod]
        [DataRow("91 8570934858")]
        [DataRow("")]
        [DataRow(null)]
        public void TestingMobileNo(string mobileNoInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.MobileNo(mobileNoInput);
                //Arrange
                Assert.IsTrue(expected, "mobile no. is not in correct format.");
            }
            catch(UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "mobile no can not be empty or null");
            }
        }
        [TestMethod]
        [DataRow("vishalgargVisGarg111")]
        [DataRow("")]
        [DataRow(null)]
        public void TestingPassword(string passwordInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.Password(passwordInput);
                //Arrange
                Assert.IsTrue(expected, "password is not in correct format.");
            }
            catch(UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "password can not be empty or null");
            }
        }
    }
}
