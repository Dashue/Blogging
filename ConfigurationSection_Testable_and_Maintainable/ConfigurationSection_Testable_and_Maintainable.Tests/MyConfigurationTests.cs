
using System;
using System.Linq;
using Xunit;

namespace ConfigurationSection_Testable_and_Maintainable.Tests
{
    public class MyConfigurationTests
    {
        [Fact]
        public void ReadMyConfiguration()
        {
            IMyConfiguration configuration = MyConfiguration.Get();

            Assert.Equal(25, configuration.Age);
            Assert.Equal("Name", configuration.Name);
            Assert.Equal(DayOfWeek.Monday, configuration.DayOfBirth);

            Assert.Equal(3, configuration.MyStrings.Count());
            Assert.Equal("Value1", configuration.MyStrings.ElementAt(0));
            Assert.Equal("Value2", configuration.MyStrings.ElementAt(1));
            Assert.Equal("Value3", configuration.MyStrings.ElementAt(2));

            Assert.Equal(2, configuration.MyConnections.Count);
            Assert.Equal("Server1", configuration.MyConnections[0].Server);
            Assert.Equal(80, configuration.MyConnections[0].Port);
            Assert.Equal("Server2", configuration.MyConnections[1].Server);
            Assert.Equal(88, configuration.MyConnections[1].Port);
        }
    }
}
