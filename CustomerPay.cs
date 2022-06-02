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
    public partial class CustomerPay : Form
    {
        public CustomerPay()
        {
            InitializeComponent();
            dataGridView1.Columns[6].Visible = false;
        }

        private void CustomerPay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excursions1DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.excursions1DataSet.Client);
            // TODO: This line of code loads data into the 'excursions1DataSet.Excursion' table. You can move, or remove it, as needed.
            this.excursionTableAdapter.Fill(this.excursions1DataSet.Excursion);

        }

        private void b_search_Click(object sender, EventArgs e)
        {
            int client = (int)comboBox1.SelectedValue;
            if (client == null)//start date is later then second
            {
                string message = "Choose client please!";
                string title = "Warning!";
                MessageBox.Show(message, title);
            }
            else
            {
                using (var db = new Excursions1Context())
                {
                    var select = (from x in db.Excursions.AsEnumerable()
                                  join y in db.Payments.AsEnumerable()
                                  on x.excursionId equals y.excursionId
                                  where y.clientId == client
                                  select new
                                  {
                                      excursionId = x.excursionId,
                                      startDate = x.startDate,
                                      duration = x.duration,
                                      distanceKM = x.distanceKM,
                                      countOfCustomers = x.countOfCustomers,
                                      excursionType = x.excursionType,
                                      Payment = y.paid,
                                  }).ToList();
                    dataGridView1.DataSource = select;
                    dataGridView1.Columns["Payment"].DataPropertyName = "Payment";
                    dataGridView1.Columns["Payment"].Visible = true;
                }
            }
        }
    }
}
