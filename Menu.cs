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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionBusDriver' table. You can move, or remove it, as needed.
            this.excursionBusDriverTableAdapter.Fill(this.excursions1DataSet.ExcursionBusDriver);
            // TODO: This line of code loads data into the 'excursions1DataSet.BusMark' table. You can move, or remove it, as needed.
            this.busMarkTableAdapter.Fill(this.excursions1DataSet.BusMark);
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionType' table. You can move, or remove it, as needed.
            this.excursionTypeTableAdapter.Fill(this.excursions1DataSet.ExcursionType);
            // TODO: This line of code loads data into the 'excursions1DataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.excursions1DataSet.Driver);
            // TODO: This line of code loads data into the 'excursions1DataSet.Bus' table. You can move, or remove it, as needed.
            this.busTableAdapter.Fill(this.excursions1DataSet.Bus);
            // TODO: This line of code loads data into the 'excursions1DataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.excursions1DataSet.Payment);
            // TODO: This line of code loads data into the 'excursions1DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.excursions1DataSet.Client);
            // TODO: This line of code loads data into the 'excursions1DataSet.Excursion' table. You can move, or remove it, as needed.
            this.excursionTableAdapter.Fill(this.excursions1DataSet.Excursion);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.excursionTableAdapter.FillBy(this.excursions1DataSet.Excursion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
