using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.classes
{
    public class Options
    {
        public enum LocationUnit : int
        {
            [Description("None")]
            None = -1,
            [Description("Random")]
            Random = 0,
            [Description("Street")]
            Street = 1,
            [Description("City")]
            City = 2,
            [Description("Country")]
            Country = 3
        }

        public enum DateTimeUnit: int
        {
            [Description("None")]
            None = -1,
            [Description("Random")]
            Random = 0,
            [Description("Hour")]
            Hour = 1,
            [Description("Day")]
            Day = 2,
            [Description("Week")]
            Week = 3,
            [Description("Month")]
            Month = 4,
            [Description("Year")]
            Year = 5
        }
    }
}
