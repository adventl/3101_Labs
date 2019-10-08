using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using Program;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
                    fr.Read("D:\\Documents\\Dropbox\\SIT\\3101 - Software Verification and Validation\\Lab 1\\Lab1\\3101_Calculator\\MagicNumbers.txt"))
                .Returns(new string[10] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"});
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNum_WhenGeneratingTest1_Result()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.GenMagicNum(0, _mockFileReader.Object), Is.EqualTo(2.0));
        }

        [Test]
        [TestCase(0, 2)]
        [TestCase(1, 4)]
        [TestCase(2, 6)]
        [TestCase(3, 8)]
        [TestCase(4, 10)]
        [TestCase(5, 12)]
        [TestCase(6, 14)]
        [TestCase(7, 16)]
        [TestCase(8, 18)]
        [TestCase(9, 20)]
        public void GenMagicNum_WhenGeneratingTest2_Result(int input, int result)
        {
            // Act
            // Assert
            Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(result));
        }
    }
}