using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vehicle;

namespace CarDat_v0
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public Car car;

        private void combobox_success_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addfiles_Click(object sender, EventArgs e)
        {

        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addrep_Click(object sender, EventArgs e)
        {
            string what = "", location = "";
            double cost = 0.00;
            bool success = false;
            DateTime repair = new DateTime();

            try
            {
                what = rtb_what.Text;
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie ein was repariert wurde.", "Fehler");
            }
            try
            {
                location = rtb_location.Text;
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie ein wo die Reparatur stattgefunden hat.", "Fehler");
            }
            try
            {
                cost = Convert.ToDouble(tb_cost.Text);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie ein wie viel die Reparatur gekostet hat.", "Fehler");
            }

            if (combobox_success.Text == "ja") success = true;
            else success = false;

            try
            {
                //repair.AddDays(datetimepicker_repair.Value.Day);
                //repair.AddMonths(datetimepicker_repair.Value.Month);
                //repair.AddYears(datetimepicker_repair.Value.Year);
                ////repair.AddHours(datetimepicker_repair.Value.Hour);
                ////repair.AddMinutes(datetimepicker_repair.Value.Minute);

                repair = datetimepicker_repair.Value.Date;
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie ein korrektes Datum bzw. eine korrekte Uhrzeit ein.", "Fehler");
            }

            //saving process:
            car.SaveRepair(car, repair, what, location, cost, success);
            this.Close();
            ((Form4)Application.OpenForms[2]).lb_repairs.Items.Clear();
            ((Form4)Application.OpenForms[2]).Form4_Load(sender, e);    // refresh Form4
        }
    }
}