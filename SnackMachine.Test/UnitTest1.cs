using SnackMachineLogic;
using System.ComponentModel.DataAnnotations;

namespace SnackMachine.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Diff_2Dollars6Cents_ReturnCorrectValue()
        {
            //Arrage
            Money money1= new Money (0, 0, 0, 0, 1, 0);
            Money money2 = new Money(6, 0, 0, 2, 1, 0);
            var diff = money2 - money1;
            var expected = 2.06m;
            //Assert 
            Assert.Equal(expected,diff.Amount,2);

        }
        
    }
}