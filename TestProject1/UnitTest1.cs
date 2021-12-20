using ClassLibrary1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var myObj = new Class1 { MyDate = DateTime.MinValue };

            // Act
            myObj.ReplaceMinValue();

            // Assert
            Assert.Null(myObj.MyDate);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var now = DateTime.Now;
            var myObj = new Class1 { MyDate = now };

            // Act
            myObj.ReplaceMinValue();

            // Assert
            Assert.Equal(now, myObj.MyDate);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var myObj = new Class1 { MyDate = null };

            // Act
            myObj.ReplaceMinValue();

            // Assert
            Assert.Null(myObj.MyDate);
        }
    }
}
