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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public Car._Repair repair;

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                tb_date.Text = repair.date.ToString();
                rtb_what.Text = repair.what;
                rtb_location.Text = repair.location;
                tb_cost.Text = repair.cost.ToString();
                if (repair.success == true) tb_success.Text = "ja";
                else tb_success.Text = "nein";
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}