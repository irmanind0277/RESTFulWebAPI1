using RestWebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWebAPI.Unit.Test
{
    public class StringCompressionControllerTest
    {
        [Fact]
        public void TestFunctionIsWorkingProperly()
        {
            // Arrange
            StringCompressionController controller = new StringCompressionController();

            // Act
            var case1 = controller.StringCompress("A");
            var case2 = controller.StringCompress("AA");
            var case3 = controller.StringCompress("AAABBBCCC");
            var case4 = controller.StringCompress("AAABBBCCC1234");

            // Assert
            Assert.True(case1.Result.Equals("A"));
            Assert.True(case2.Result.Equals("AA"));
            Assert.True(case3.Result.Equals("A3B3C3"));
            Assert.True(case4.Result.Equals("AAABBBCCC1234"));
        }
    }
}
