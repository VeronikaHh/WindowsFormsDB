using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    public partial class BusSchedule : Form
    {
        public BusSchedule()
        {
            InitializeComponent();
        }

        private void BusSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionBusDriver' table. You can move, or remove it, as needed.
            this.excursionBusDriverTableAdapter.Fill(this.excursions1DataSet.ExcursionBusDriver);

        }
    }
}
