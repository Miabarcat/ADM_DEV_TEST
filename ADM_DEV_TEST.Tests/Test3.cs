using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Pages;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Xunit;

namespace ADM_DEV_TEST.Tests
{
    public class Test3
    {
        [Fact]
        public void Test3_OK()
        {
            ITest3Service service = new Test3Service();

            var pageModel = new ADM_Test3Model(service);

            pageModel.ModelTest3.Text = "Hello how are you? I'm fine, you?";
            pageModel.ModelTest3.Word = "you";

            var res = pageModel.OnPost();

            Assert.IsType<PageResult>(res);
            pageModel.ModelTest3.Result.Should().Be(2);
        }
    }
}