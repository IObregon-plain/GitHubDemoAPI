using GitHubDemoAPI.Controllers;
using Xunit;

namespace GitHubDemoAPITest
{
    public class HelloControllerTest
    {
        [Fact]
        public void CheckTheReturnValueIsTheExpectedOne()
        {
            var controller = new HelloController();
            var result = controller.Get();

            Assert.Equal("Hello world", result);
        }
    }
}