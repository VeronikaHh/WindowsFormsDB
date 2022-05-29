﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    public partial class Menu : Form
    {


        SqlConnection sqlconnection;

        SqlCommand sqlcommand;

        string ConnectionString = @"Data Source=DESKTOP-KDVI0GR;Initial Catalog=Excursions1;Integrated Security=True";

        string ExcQuery;

        DataSet dataset;

        DataTable datatable;

        SqlDataAdapter sqladapter;


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionBus' table. You can move, or remove it, as needed.
            this.excursionBusTableAdapter.Fill(this.excursions1DataSet.ExcursionBus);
            // TODO: This line of code loads data into the 'excursions1DataSet.ExcursionClient' table. You can move, or remove it, as needed.
            this.excursionClientTableAdapter.Fill(this.excursions1DataSet.ExcursionClient);
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

        //--------------------------------- SAVE - BUTTONS ----------------------------------------
        //excursion save
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.excursionTableAdapter.Update(this.excursions1DataSet.Excursion);
        }
        //client save
        private void saveToolStripButton1_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Update(this.excursions1DataSet.Client);

        }
        //bus save 
        private void saveToolStripButton3_Click(object sender, EventArgs e)
        {
            this.busTableAdapter.Update(this.excursions1DataSet.Bus);
        }
        //driver save
        private void saveToolStripButton4_Click(object sender, EventArgs e)
        {
            this.driverTableAdapter.Update(this.excursions1DataSet.Driver);
        }
        //excursionBusDriver save
        private void saveToolStripButton5_Click(object sender, EventArgs e)
        {
            this.excursionBusDriverTableAdapter.Update(this.excursions1DataSet.ExcursionBusDriver);
        }
        //excursionClient save
        private void saveToolStripButton6_Click(object sender, EventArgs e)
        {
            this.excursionClientTableAdapter.Update(this.excursions1DataSet.ExcursionClient);
        }
        //excursionBus save
        private void saveToolStripButton7_Click(object sender, EventArgs e)
        {
            this.excursionBusTableAdapter.Update(this.excursions1DataSet.ExcursionBus);
        }

        //------------------------------------- FILTERS --------------------------------------------------------
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (toolStripComboBox5 != null)
            {
                //toolStripComboBox5 = (System.Windows.Controls.ComboBox)e.Control;
                toolStripComboBox5.SelectedIndexChanged += new EventHandler(toolStripComboBox5_SelectedIndexChanged);
            }
        }

        private void toolStripComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (toolStripComboBox5.SelectedItem != null)
            //{

            //    if (toolStripComboBox5.SelectedIndex == 0)
            //    {
            //        this.excursionTableAdapter.Fill(this.excursions1DataSet.Excursion);
            //    }
            //    else if (toolStripComboBox5.SelectedIndex == 2)
            //    {

            //        dataGridView1.BackColor = Color.Red;
            //        DataView DV = new DataView(datatable);

            //        ExcQuery = "SELECT * FROM Excursion WHERE startDate >= CAST(CURRENT_TIMESTAMP AS DATE)";

            //        DV.RowFilter = string.Format(ExcQuery);

            //        dataGridView1.DataSource = DV;
            //        //this.excursionTableAdapter.Fill(this.excursions1DataSet.Excursion);
            //    }
            //    else if (toolStripComboBox5.SelectedIndex == 2)
            //    {
            //        DataView DV = new DataView(datatable);

            //        ExcQuery = "SELECT * FROM Excursion WHERE startDate =< CAST(CURRENT_TIMESTAMP AS DATE)";

            //        DV.RowFilter = string.Format(ExcQuery);

            //        dataGridView1.DataSource = DV;
            //        // this.excursionTableAdapter.Fill(this.excursions1DataSet.Excursion);
            //    }
            //}
        }
    }
}
