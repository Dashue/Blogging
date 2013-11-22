using System;
using System.Collections.Generic;

namespace ConfigurationSection_Testable_and_Maintainable
{
    public interface IMyConfiguration
    {
        int Age { get; }
        string Name { get; }
        DayOfWeek DayOfBirth { get; }

        IEnumerable<string> MyStrings { get; }
    }
}