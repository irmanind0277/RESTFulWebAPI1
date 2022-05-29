using RestWebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWebAPI.Unit.Test
{
    public class PermutationControllerTest
    {
        [Fact]
        public void TestFunctionIsWorkingProperly()
        {
            // Arrange
            PermutationController controller = new PermutationController();

            // Act
            var case1 = controller.CheckPermutation("TEST", "ESTT");
            var case2 = controller.CheckPermutation("TEST", "ABC");
            var case3 = controller.CheckPermutation("TEST", "ABCD");
            var case4 = controller.CheckPermutation("TEST", "TEDSDD");

            // Assert
            Assert.True(case1.Result.Contains("Yes"));
            Assert.True(case2.Result.Contains("No"));
            Assert.True(case3.Result.Contains("No"));
            Assert.True(case4.Result.Contains("No"));
        }
    }
}
