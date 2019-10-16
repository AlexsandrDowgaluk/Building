using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Building
{
    public class BuildingTest
    {


        [Theory]
        [InlineData(250, 1, 250)]
        [InlineData(2, 100, 0.02)]
        [InlineData(400, 100, 5)]
        public void PossingToCalculateHight(double hight, int quantity, double expected)
        {
            Building b = new Building();
            b.HighBuilding = hight;
            b.NumberOfStoreys = quantity;

            double actual = b.HighStorey();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckID()
        {
            Building b1 = new Building();
            Building b2 = new Building();
            int i = b2.IdBuilding - b1.IdBuilding;

            Assert.Equal(1, i);
        }
    }
    }












}






    
       
}
 
    

