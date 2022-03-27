using cs18_paskaita_Store.Functionality;
using Xunit;

namespace CartAndChequeSystemValidation_xUnit
{
    public class CartAndChequeSystemValidation_xUnit
    {
        [Fact]
        public void CartAndChequeSystem_Calculation_Validation_AddingItems()
        {
            // Arange
            CartAndChequeSystem.cartTotal = 50m;
            CartAndChequeSystem.wallet = 100m;
            CartAndChequeSystem.AddSweetsToCartList(2); // 4.99
            CartAndChequeSystem.AddMeatsToCartList(0); // 5.99 
            CartAndChequeSystem.AddGreensToCartList(1); // 1.99
            CartAndChequeSystem.AddDrinkablesToCartList(3); // 0.99
            // Act
            decimal test1Result = CartAndChequeSystem.cartTotal;

            // Asert
            Assert.Equal(63.96m, test1Result);
        }
        [Fact]
        public void CartAndChequeSystem_Calculation_Validation_RemovingItems()
        {
            // Arange
            CartAndChequeSystem.cartTotal = 50m;
            CartAndChequeSystem.wallet = 100m;
            CartAndChequeSystem.AddSweetsToCartList(2); // 4.99
            CartAndChequeSystem.AddMeatsToCartList(0); // 5.99 
            CartAndChequeSystem.AddGreensToCartList(1); // 1.99

            CartAndChequeSystem.RemoveFromCart(2);
            // Act
            decimal test1Result = CartAndChequeSystem.cartTotal;
            int test2Result = CartAndChequeSystem.moneyOperations.Count;

            // Asert
            Assert.Equal(56.98m, test1Result);
            Assert.Equal(2, test2Result);
        }
    }
}