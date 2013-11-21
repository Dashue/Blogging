using System;
using System.Configuration;

namespace ConfigurationSection_Testable_and_Maintainable
{
    public interface IMyConfiguration
    {
        int Age { get; }
        string Name { get; }
        DayOfWeek DayOfBirth { get; }

        CommaDelimitedStringCollection MyStrings { get; }
    }
}