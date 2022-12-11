using SnackMachineLogic;
using System.ComponentModel.DataAnnotations;

namespace SnackMachine.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Equal_False_ReturnCorrectValue()
        {
            //Arrage
            Money money1= new Money (0, 0, 0, 5, 0, 0);
            Money money2 = new Money(0, 0, 0, 6, 0, 0);
            bool equal = money1 == money2;
            var expected = false;
            //Assert 
            Assert.Equal(expected,equal);

        }
        [Fact]
        public void Equal_True_ReturnCorrectValue()
        {
            //Arrage
            Money money1 = new Money(0, 0, 0, 5, 0, 0);
            Money money2 = new Money(0, 0, 0, 5, 0, 0);
            bool equal = money1 == money2;
            var expected = true;
            //Assert 
            Assert.Equal(expected, equal);

        }
    }
}