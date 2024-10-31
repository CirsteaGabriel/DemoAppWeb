using Xunit;
using DemoWebApp.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoWebApp.Tests
{
    public class IndexModelTests
    {
        [Fact]
        public void OnGet_SetsMessageCorrectly()
        {
            // Arrange
            var pageModel = new IndexModel();

            // Act
            pageModel.OnGet();

            // Assert
            Assert.Contains("Azure DevOps", pageModel.Message);
        }

        [Fact]
        public void IndexPage_ShouldBePageModel()
        {
            // Arrange & Act
            var pageModel = new IndexModel();

            // Assert
            Assert.True(pageModel is PageModel); // Modificat aici
            // SAU
            // Assert.IsAssignableFrom<PageModel>(pageModel);
        }
    }
}