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
    public partial class ExcursionForPeriod : Form
    {
        public ExcursionForPeriod()
        {
            InitializeComponent();
        }

        private void ExcursionForPeriod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excursions1DataSet.Excursion' table. You can move, or remove it, as needed.
            this.excursionTableAdapter.Fill(this.excursions1DataSet.Excursion);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
