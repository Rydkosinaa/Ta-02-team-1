using SnackMachineLogic;
using System.ComponentModel.DataAnnotations;

namespace SnackMachine.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Check_2Dollars6Cents_ReturnCorrectValue()
        {
            //Arrage
            
            Money money1 = new Money(6, 0, 0, 2, 1, 0);
       
            var expected = 7.06m;
            //Assert 
            Assert.Equal(expected,money1.Amount,2);

        }
        
    }
}
