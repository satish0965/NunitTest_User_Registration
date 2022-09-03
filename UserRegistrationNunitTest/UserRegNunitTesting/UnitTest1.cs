using UserRegistrationNunitTest;

namespace UserRegNunitTesting
{
 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange 
            bool expected = true;
            string name = "Satish";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Patil";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "satish.patil7017@gmail.com";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "91 8698949158";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateMobileNumber(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "abcdfghihgE1@";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}