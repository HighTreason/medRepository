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
        }        
    }
}
