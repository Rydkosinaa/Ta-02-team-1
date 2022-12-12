using SnackMachineLogic;
using System.ComponentModel.DataAnnotations;

namespace SnackMachine.Test
{
    public class MoneyTest
    {
        [Fact]
<<<<<<< HEAD
        public void Check_2Dollars6Cents_ReturnCorrectValue()
        {
            //Arrage
            
            Money money1 = new Money(6, 0, 0, 2, 1, 0);
       
            var expected = 7.06m;
            //Assert 
            Assert.Equal(expected,money1.Amount,2);
=======
        public void Diff_2Dollars6Cents_ReturnCorrectValue()
        {
            //Arrage
            Money money1= new Money (0, 0, 0, 0, 1, 0);
            Money money2 = new Money(6, 0, 0, 2, 1, 0);
            var diff = money2 - money1;
            var expected = 2.06m;
            //Assert 
            Assert.Equal(expected,diff.Amount,2);
>>>>>>> 123954485bd4b3cc54115da1cc416cb572d51d52

        }
        
    }
}