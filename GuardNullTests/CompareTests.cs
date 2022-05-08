using FluentAssertions;
using GuardNull;
using System;
using Xunit;
using Xunit.Abstractions;
using YamlDotNet.Serialization;

namespace GuardNullTests
{
    public class CompareTests
    {
        private const string _aMessage = "A custom message";
        private const string _aParamName = "A custom param name";

        private ITestOutputHelper Output { get; init; }
        public CompareTests(ITestOutputHelper output)
        {
            Output = output;
        }


        [Fact]
        public void Should_Throw_Proper_Exception()
        {
            this.assertTraditional();

            this.assertThrowIfNull();
            
            this.assertThrowIfNullExtended();

            this.assertGuard();

            this.failToShowOutput();
        }
        
        private void assertGuard()
        {
            static void guardFunc(string? anArgument) => Guard.ThrowIfNullArgument(anArgument, _aParamName, _aMessage);

            try
            {
                guardFunc(null);
            }
            catch (ArgumentNullException guardExceptionEx)
            {
                this.outputException(nameof(guardExceptionEx), guardExceptionEx);

            }
        }


        private void assertTraditional()
        {
            static void traditionalFunc(string? anArgument)
            {
                if (anArgument == null)
                    throw new ArgumentNullException(_aParamName, _aMessage);
            }

            try
            {
                traditionalFunc(null);
            }
            catch (ArgumentNullException traditionalEx)
            {
                this.outputException(nameof(traditionalEx), traditionalEx);
            }
        }

        private void assertThrowIfNull()
        {
            static void throwIfNull(string? anArgument)
            {

                ArgumentNullException.ThrowIfNull(anArgument, _aParamName);
            }

            try
            {
                throwIfNull(null);
            }
            catch (ArgumentNullException throwIfNullEx)
            {
                this.outputException(nameof(throwIfNullEx), throwIfNullEx);
            }
        }

        private void assertThrowIfNullExtended()
        {
            static void throwIfNull(string? anArgument)
            {

                (new ArgumentNullException()).ThrowIfNull(anArgument, _aParamName, _aMessage);
            }

            try
            {
                throwIfNull(null);
            }
            catch (ArgumentNullException assertThrowIfNullExt)
            {
                this.outputException(nameof(assertThrowIfNullExt), assertThrowIfNullExt);
            }
        }


        private void failToShowOutput()
        {
            true.Should().BeFalse();
        }

        private void outputException(string title, ArgumentNullException e)
        {
            Output.WriteLine($"--- {title} ---");
            Output.WriteLine("ParamName: " + e.ParamName);
            Output.WriteLine("Message: " + e.Message);
        }

        private void outputExceptionYaml(string title, ArgumentNullException e) => 
            Output.WriteLine($"--- {title} ---\n{new SerializerBuilder().Build().Serialize(e)}");

        

    }
}