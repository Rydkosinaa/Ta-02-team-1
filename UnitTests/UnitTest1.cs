using SnackMachineLogic;
  
namespace UnitTests
{
    public class AdditionTest
    {
        [Fact]
        public void Addition_2Dollar4Cents_ReturnCorrectValue()
        {
            Money money1 = new Money(4, 0, 0, 1, 0, 0);
            Money money2 = new Money(0, 0, 0, 1, 0, 0);
            Money sum = money1 + money2;

            var expected=2.04m;

            Assert.Equal(expected, sum.Amount);
        }
    }
}