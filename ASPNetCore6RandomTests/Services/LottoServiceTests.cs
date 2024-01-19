using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPNetCore6Random.Services;
using ASPNetCore6Random.ViewModels;
using ExpectedObjects;
using ASPNetCore6Random.Wrapper;
using Moq;

namespace ASPNetCore6Random.Services.Tests
{
    [TestClass()]
    public class LottoServiceTests
    {
        [TestMethod()]
        public void Test_Lottoing_輸入亂數範圍_0_10_預期回傳_9_恭喜中獎()
        {
            // Arrange
            var expected = new LottoViewModel()
            { YourNumber = 9, Message = "恭喜中獎" }
                        .ToExpectedObject();

            int fixedValue = 9;
            var mockRandomGenerator = new Mock<IRandomGenerator>();
            mockRandomGenerator.Setup(r => r.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(fixedValue);

            // Act
            var target = new LottoService(mockRandomGenerator.Object);
            var actual = target.Lottoing(0, 10);

            // Assert
            expected.ShouldEqual(actual);
        }


        [TestMethod()]
        public void Test_Lottoing_輸入亂數範圍_0_10_預期回傳_1_再接再厲()
        {
            // Arrange
            var expected = new LottoViewModel()
            { YourNumber = 1, Message = "再接再厲" }
                        .ToExpectedObject();

            int fixedValue = 1;
            var mockRandomGenerator = new Mock<IRandomGenerator>();
            mockRandomGenerator.Setup(r => r.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(fixedValue);

            // Act
            var target = new LottoService(mockRandomGenerator.Object);
            var actual = target.Lottoing(0, 10);

            // Assert
            expected.ShouldEqual(actual);
        }

    }
}