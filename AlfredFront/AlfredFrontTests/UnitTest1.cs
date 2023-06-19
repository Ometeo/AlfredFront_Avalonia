using AlfredFront.ViewModels;

using FluentAssertions;

namespace AlfredFrontTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MainViewModel viewModel = new MainViewModel();
            viewModel.Title.Should().Be("Alfred");
        }
    }
}
