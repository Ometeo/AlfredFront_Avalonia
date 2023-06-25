using AlfredFront.ViewModels;

using FluentAssertions;

namespace AlfredFrontTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {            
            MainViewModel.Title.Should().Be("Alfred");
        }
    }
}
