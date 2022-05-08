//using FluentAssertions;
//using GuardNull;
//using System;
//using System.Diagnostics;
//using System.Reflection.Metadata;
//using Xunit;
//using Xunit.Abstractions;
//using YamlDotNet.Serialization;

//namespace GuardNullTests
//{
//    public class TraditionalTest
//    {
//        private ITestOutputHelper Output { get; init; }
//        public TraditionalTest(ITestOutputHelper output)
//        {
//            Output = output;
//        }


//        [Fact]
//        public void Should_Throw_Proper_Exception
//            ()
//        {
//            Action action = () =>Traditional.AnyMethod(null);
//            action.Should().Throw<ArgumentNullException>().WithParameterName("anyString").And.Message.Should().Be("Argument should not be null! (Parameter 'anyString')");

//            //try
//            //{
//            //    action();
//            //}
//            //catch (Exception e)
//            //{
//            //    var serializer = new SerializerBuilder().Build();
//            //    var yaml = serializer.Serialize(e);
//            //    Output.WriteLine("--- Traditional ---");
//            //    Output.WriteLine(yaml);
//            //    true.Should().BeFalse();
//            //}

//        }

//        [Fact]
//        public void Should_throw_proper_exception_with_custom_paramname
//    ()
//        {
//            Action action = () => Traditional.AnyExtendedMethod(null);
//            action.Should().Throw<ArgumentNullException>().WithParameterName("custom paramName").And.Message.Should().Be("Argument should not be null! (Parameter 'anyString')");
//        }

//        }
//    }