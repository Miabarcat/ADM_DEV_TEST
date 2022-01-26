using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Pages;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Xunit;

namespace ADM_DEV_TEST.Tests
{
    public class Test1
    {
        [Fact]
        public void Test1_OK()
        {
            ITest1Service service = new Test1Service();

            var pageModel = new ADM_Test1Model(service);

            pageModel.ModelTest1.Num1 = 2;
            pageModel.ModelTest1.Num2 = 4;

            var res = pageModel.OnPost();

            Assert.IsType<PageResult>(res);
            pageModel.ModelTest1.MultiResult.Should().Be(8);
        }
    }
}