
using System;
using System.ComponentModel;
using System.Configuration;

namespace ConfigurationSection_Testable_and_Maintainable
{
    public class MyConfiguration : ConfigurationSection, IMyConfiguration
    {
        private MyConfiguration()
        {
        }

        public static IMyConfiguration Get()
        {
            return (IMyConfiguration)ConfigurationManager.GetSection("MyConfiguration");
        }

        [ConfigurationProperty("Age", IsRequired = true)]
        public int Age
        {
            get
            {
                return (int)this["Age"];
            }
        }

        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["Name"];
            }
        }

        [ConfigurationProperty("DayOfBirth", IsRequired = true)]
        public DayOfWeek DayOfBirth
        {
            get
            {
                return (DayOfWeek)this["DayOfBirth"];
            }
        }

        [ConfigurationProperty("MyStrings", IsRequired = true)]
        [TypeConverter(typeof(CommaDelimitedStringCollectionConverter))]
        public CommaDelimitedStringCollection MyStrings
        {
            get
            {
                return (CommaDelimitedStringCollection)this["MyStrings"];
            }
        }
    }
}
