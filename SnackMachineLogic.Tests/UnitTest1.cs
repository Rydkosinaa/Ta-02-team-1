using SnackMachineLogic;
using Xunit;

namespace SnackMachineLogic.Tests
{
    public class MoneyTest
    {
        [Fact]
        public void Amount_Minus20Cent_ReturnExeption()
        {
            //Arrange
            Money money53 = new Money(0, 1, 0, 0, 0, 0);
            Assert.Throws<InvalidOperationException>(() => money53 = new Money(0, -2, 0, 0, 0, 0));
        }
    }
}