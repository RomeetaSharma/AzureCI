using System;
using SimpleAPI.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc.Core;
namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValueController obj=new ValueController();
         [Fact]
        public void GetReturnMyName()
        {
        var returnValue=obj.Get(1);
        Assert.Equal("Romeeta Sharma",returnValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
