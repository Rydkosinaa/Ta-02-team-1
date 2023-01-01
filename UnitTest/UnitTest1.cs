using SnackMachineLogic;

namespace UnitTest
{
    public class ClassMoneyTest
    {
        [Fact]
        public void OperatMinus_6Dollars3Cents_ReturnCorrectValue()
        {
            //Arrage
            Money money1 = new Money(2, 2, 2, 2, 2, 2);
            Money money2 = new Money(1, 1, 1, 1, 1, 1);
            var diff = money1 - money2;
            var expected = 26.36m;
            //Assert 
            Assert.Equal(expected,diff.Amount);
        }
    }
}