using System;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlExceptionTests
    {
        [Fact]
        public void Ctor_Default()
        {
            HtmlException exception = new HtmlException();
            Assert.Equal("Exception of type 'HtmlGenerator.HtmlException' was thrown.", exception.Message);
            Assert.Null(exception.InnerException);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" \t \r \n")]
        [InlineData("mesage")]
        public void Ctor_String(string message)
        {
            HtmlException exception = new HtmlException(message);
            Assert.Equal(message ?? "Exception of type 'HtmlGenerator.HtmlException' was thrown.", exception.Message);
            Assert.Null(exception.InnerException);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" \t \r \n")]
        [InlineData("mesage")]
        public void Ctor_String_Exception(string message)
        {
            Exception innerException = new InvalidOperationException();
            HtmlException exception = new HtmlException(message, innerException);
            Assert.Equal(message ?? "Exception of type 'HtmlGenerator.HtmlException' was thrown.", exception.Message);
            Assert.Same(innerException, exception.InnerException);
        }
    }
}
