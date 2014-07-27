using MED.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MED
{
    public partial class Med : Form
    {
        public Med()
        {
            InitializeComponent();

            populateLocationComboBox();
            populateDateTimeComboBox();
        }

        /// <summary>
        /// populates the location combo box from LocationUnits enum
        /// </summary>
        private void populateLocationComboBox()
        {
            Array locationUnits = Enum.GetValues(typeof(Options.LocationUnit));
            Array.Sort(locationUnits);

            foreach (int locationUnit in locationUnits)
            {
                locationUnitComboBox.Items.Add((Options.LocationUnit) locationUnit);
            }

            locationUnitComboBox.SelectedIndex = 0;
        }    
    
        /// <summary>
        /// populates the date & time combo box from DateTimeUnit enum
        /// </summary>
        private void populateDateTimeComboBox()
        {
            Array dateTmeUnits = Enum.GetValues(typeof(Options.DateTimeUnit));
            Array.Sort(dateTmeUnits);

            foreach (int dateTmeUnit in dateTmeUnits)
            {
                dateTimeComboBox.Items.Add((Options.DateTimeUnit)dateTmeUnit);
            }

            dateTimeComboBox.SelectedIndex = 0;
        }
    }
}
