using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Pages;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Xunit;

namespace ADM_DEV_TEST.Tests
{
    public class Test2
    {
        [Fact]
        public void Test2_OK()
        {
            ITest2Service service = new Test2Service();

            var pageModel = new ADM_Test2Model(service);

            pageModel.ModelTest2.NumList = "1,3,5,23,4,12,5,";

            var res = pageModel.OnPost();

            Assert.IsType<PageResult>(res);
            pageModel.ModelTest2.Result.Should().Be(23);
        }
    }
}