using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Pages;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Xunit;

namespace ADM_DEV_TEST.Tests
{
    public class Test4
    {
        private ITest4Service _service;
        private ADM_Test4Model _pageModel;
        public Test4() {
            _service = new Test4Service();

            _pageModel = new ADM_Test4Model(_service);
        }

        [Fact]
        public void Test4_True()
        {
            _pageModel.ModelTest4.Text = "anina";

            var res = _pageModel.OnPost();

            Assert.IsType<PageResult>(res);
            _pageModel.ModelTest4.Result.Should().Be(true);
        }

        [Fact]
        public void Test4_False()
        {

            _pageModel.ModelTest4.Text = "anisna";

            var res = _pageModel.OnPost();

            Assert.IsType<PageResult>(res);
            _pageModel.ModelTest4.Result.Should().Be(false);
        }
    }
}