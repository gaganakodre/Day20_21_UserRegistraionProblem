using UserRegistrationTestAndRegex;

namespace UserRegistrationTest
{
    public class Tests
    {
        UserRegistrationDetails user;
        [SetUp]
        public void Setup()
        {
            user = new UserRegistrationDetails();
        }

        [Test]
        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Shreegowri";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Koder";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }


    }
}