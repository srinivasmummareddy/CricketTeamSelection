using Shouldly;
using System;

namespace UnitTests.Extensions
{
    public static class ShouldyHelper
    {
        public static void MessageShouldBe(this Exception exception, string message)
        {
            exception.Message.Replace(Environment.NewLine, string.Empty).ShouldBe(message);
        }
    }
}
