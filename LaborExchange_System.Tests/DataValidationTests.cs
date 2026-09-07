using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace LaborExchange_System.Tests
{
    [TestClass]
    // Класс тестів для перевірки валідації даних у системі LaborExchange
    public class DataValidationTests
    {
        [TestMethod]
        public void SpecialistEmail_ValidFormat_ReturnsTrue()
        {
            // Arrange
            string validEmail = "candidate@mail.com";
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Act
            bool isValid = Regex.IsMatch(validEmail, pattern);

            // Assert
            Assert.IsTrue(isValid, "Коректний email повинен проходити валідацію");
        }

        [TestMethod]
        public void SpecialistEmail_InvalidFormat_ReturnsFalse()
        {
            // Arrange
            string invalidEmail = "candidate_without_at_symbol.com";
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Act
            bool isValid = Regex.IsMatch(invalidEmail, pattern);

            // Assert
            Assert.IsFalse(isValid, "Некоректний email не повинен проходити валідацію");
        }

        [TestMethod]
        public void SalaryRange_NegativeSalary_ShouldBeInvalid()
        {
            // Arrange
            decimal salary = -500.00m;

            // Act
            bool isValidSalary = salary >= 0;

            // Assert
            Assert.IsFalse(isValidSalary, "Рівень заробітної плати не може бути від'ємним");
        }

        [TestMethod]
        public void PhoneNumber_ValidFormat_ReturnsTrue()
        {
            // Arrange
            string validPhone = "+380501234567";
            string pattern = @"^\+?380\d{9}$";

            // Act
            bool isValid = Regex.IsMatch(validPhone, pattern);

            // Assert
            Assert.IsTrue(isValid, "Коректний номер телефону має успішно проходити валідацію");
        }

        [TestMethod]
        public void SalaryRange_ValidMinAndMax_ReturnsTrue()
        {
            // Arrange
            decimal minSalary = 20000m;
            decimal maxSalary = 35000m;

            // Act
            bool isValidRange = minSalary <= maxSalary && minSalary >= 0;

            // Assert
            Assert.IsTrue(isValidRange, "Мінімальна зарплата не може перевищувати максимальну або бути від'ємною");
        }
    }
}

// CI pipeline test trigger
