using SnackMachineLogic;
using Xunit;

namespace SnackMachineLogic.Tests
{
    public class MoneyTest
    {
        [Fact]
        public void Money_MinusMoney_ReturnExeption()
        {
            //Arrange
            Money money53 = new Money(1, 0, 0, 0, 0, 0);

            //Assert
            Assert.Throws<InvalidOperationException>(() => money53 = new Money(-1, 0, 0, 0, 0, 0));
            Assert.Throws<InvalidOperationException>(() => money53 = new Money(0, -1, 0, 0, 0, 0));
            Assert.Throws<InvalidOperationException>(() => money53 = new Money(0, 0, -1, 0, 0, 0));
            Assert.Throws<InvalidOperationException>(() => money53 = new Money(0, 0, 0, -1, 0, 0));
            Assert.Throws<InvalidOperationException>(() => money53 = new Money(0, 0, 0, 0, -1, 0));
            Assert.Throws<InvalidOperationException>(() => money53 = new Money(0, 0, 0, 0, 0, -1));
        }
    }
}