using System;
using Xunit;
using ConsoleAppContactManager.Models;

namespace ContactManager.Tests
{
    public class ContctInfoTests
    {
        [Fact]
        public void NumbersThatContainsNumber()
        {
            //Arrange
            ContactInfo contactInfo = new ContactInfo();

            PhoneNumber phoneNumber1 = new PhoneNumber("000000000");
            PhoneNumber phoneNumber2 = new PhoneNumber("123123132");
            PhoneNumber phoneNumber3 = new PhoneNumber("456456465456");
            contactInfo.AddPhoneNumber(phoneNumber1);
            contactInfo.AddPhoneNumber(phoneNumber2);
            contactInfo.AddPhoneNumber(phoneNumber3);

            //Act
            PhoneNumber[] result = contactInfo.FindPhoneNumberContaning("12");

            //Assert
            Assert.True(result.Length == 1);
            Assert.Equal(phoneNumber2, result[0]);
        }
    }
}
