using System;
using Xunit;
using System.Linq;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso(){
            // Act
            var beverage = new EspressoMachine().AddWater(20).HeatWater().AddBeans(new Beans { Sort = CoffeSorts.Arabica, Amount = 5 }).ToBeverage();
             //Assert
            Assert.IsType<Espresso>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndWaterAndBeans_Expect_Americano()
        {
            // Act
            var beverage = new EspressoMachine().AddWater(20).AddWater(20).HeatWater(92).Validate(e => e.Temperature >= 92 && e.Ingredients.All(a => a.Amount > 0)).AddBeans(new Beans { Sort = CoffeSorts.Arabica, Amount = 5 }).ToBeverage();
            //Assert
            Assert.IsType<Americano>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndMilkFoamAndBeans_Expect_Cappuccino()
        {
            // Act
            var beverage = new EspressoMachine().AddWater(20).HeatWater().Validate(e => e.Temperature >= 90 && e.Ingredients.All(a => a.Amount > 0)).AddMilkFoam(5).AddMilk(100).AddBeans(new Beans { Sort = CoffeSorts.Arabica, Amount = 5 }).ToBeverage();
            //Assert
            Assert.IsType<Cappuccino>(beverage);
        }

        [Fact]
        public void When_AddingCustom_Expect_Custom()
        {
            // Act
            var beverage = new EspressoMachine().AddWater(20).HeatWater().AddChocolateSyrup(20).ToBeverage();
            //Assert
            Assert.IsType<Custom>(beverage);
        }
    }
}