using FluentAssertions;
using GuardNull;
using System;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;
using YamlDotNet.Serialization;

namespace GuardNullTests
{
    public class ExtensionTests
    {
        private ITestOutputHelper Output { get; init; }
        public ExtensionTests(ITestOutputHelper output)
        {
            Output = output;
        }
        [Fact]
        public void Should_Throw_Proper_Exception()
        {

            Action action = () => Traditional.AnyMethod(anyString: null);
            action.Should().Throw<ArgumentNullException>().WithParameterName("anyString").And.Message.Should().Be("Argument should not be null! (Parameter 'anyString')");

            try
            {
                action();
            }
            catch (Exception e)
            {
                var serializer = new SerializerBuilder().Build();
                var yaml = serializer.Serialize(e);
                Output.WriteLine("--- Extension ---");
                Output.WriteLine(yaml);
                true.Should().BeFalse();
            }
        }
    }
}
