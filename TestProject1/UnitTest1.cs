using SnackMachineLogic;

namespace SnackMachineTest
{
    public class MoneyTest1
    {
        [Fact]
        public void OperatorEqual_True_ReturnCorrectValue()
        {
            //Arrage
            Money money1 = new Money(1, 0, 0, 4, 0, 0);
            Money money2 = new Money(1, 0, 0, 4, 0, 0);
            bool money = money1 == money2;
            var expected = true;
            //Asserd
            Assert.Equal(expected, money);
        }
    }
}

