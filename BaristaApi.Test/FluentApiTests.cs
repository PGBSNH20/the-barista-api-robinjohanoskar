using Xunit;


namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso(){


            //Pseudo code
            
            // Act
            var beverage = new EspressoMachine().AddWater(20).AddBeans(new Beans { Sort = CoffeSorts.Arabica, Amount = 5 }).ToBeverage();
             //Assert
            Assert.IsType<Espresso>(beverage);
            
        }
        [Fact]
        public void When_AddingWaterAndWaterAndBeans_Expect_Americano()
        {

            //Pseudo code

            // Act
            var beverage = new EspressoMachine().AddWater(20).AddWater(20).AddBeans(new Beans { Sort = CoffeSorts.Arabica, Amount = 5 }).ToBeverage();
            //Assert
            Assert.IsType<Americano>(beverage);

        }
        [Fact]
        public void When_AddingWaterAndMilkFoamAndBeans_Expect_Cappuccino()
        {

            //Pseudo code

            // Act
            var beverage = new EspressoMachine().AddWater(20).AddMilkFoam(5).AddMilk(100).AddBeans(new Beans { Sort = CoffeSorts.Arabica, Amount = 5 }).ToBeverage();
            //Assert
            Assert.IsType<Cappuccino>(beverage);

        }
        [Fact]
        public void When_AddingCustom_Expect_Custom()
        {

            //Pseudo code

            // Act
            var beverage = new EspressoMachine().AddWater(20).AddChocolateSyrup(20).ToBeverage();
            //Assert
            Assert.IsType<Custom>(beverage);

        }
    }
}