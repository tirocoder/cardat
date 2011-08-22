using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Vehicle;

namespace CarDat_v0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Vehicle.Car new_car = new Car();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_addcar_Click(object sender, EventArgs e)
        {
            if (combobox_type1.Text == "KFZ")
            {
                int seats=Convert.ToInt32(tb_seats.Text);
                int weight1=Convert.ToInt32(tb_weight1.Text);
                int weight2=Convert.ToInt32(tb_weight2.Text);
                int weight3=Convert.ToInt32(tb_weight3.Text);
                int weight4=Convert.ToInt32(tb_weight4.Text);
                int year = Convert.ToInt32(tb_year.Text);
                int power = Convert.ToInt32(tb_power.Text);
                int year_firstcarreg = Convert.ToInt32(tb_year_firstcarreg.Text);
                string type1=combobox_type1.SelectedItem.ToString();
                string type2=tb_type2.Text;
                string type3 = "NOTHING";
                string manu=tb_manu.Text;
                string natcode=tb_natcode.Text;
                string constr=tb_constr.Text;
                string color=tb_color.Text;
                string tiredims=rtb_tiredims.Text;
                string month_firstcarreg = combobox_month_firstcarreg.Text;

                new_car.AddCar(seats, weight1, weight2, weight3, weight4, power, type1, type2, type3, manu, natcode, constr, color, tiredims, year, month_firstcarreg, year_firstcarreg);
                new_car.SaveCar(new_car);
            }
            this.Close();
            ((Form1)Application.OpenForms[0]).Form1_Load(sender, e);    // refresh main form (Form1)
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_addpreviewpic_Click(object sender, EventArgs e)
        {
            ofd_previewpic.ShowDialog();
            string filename = ofd_previewpic.FileName;

            //Image ppic = Image.FromFile(filename);

            new_car.AddPreviewPicture(filename);
        }

        private void btn_formclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_year_TextChanged(object sender, EventArgs e)
        {
            if (tb_year.Text == "")
            {
                tb_year.Text = "0";
            }
        }

        private void tb_power_TextChanged(object sender, EventArgs e)
        {
            if (tb_power.Text == "")
            {
                tb_power.Text = "0";
            }
        }

        private void tb_weight_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_name_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_year_Click(object sender, EventArgs e)
        {
            tb_year.SelectAll();
        }

        private void tb_power_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void tb_power_Click(object sender, EventArgs e)
        {
            tb_power.SelectAll();
        }

        private void tb_weight_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_manu_TextChanged(object sender, EventArgs e)
        {
            if (tb_manu.Text == "")
            {
                tb_manu.Text = "Marke eingeben";
            }
        }

        private void tb_type2_TextChanged(object sender, EventArgs e)
        {
            if (tb_type2.Text == "")
            {
                tb_type2.Text = "Bez. eingeben";
            }
        }

        private void tb_natcode_TextChanged(object sender, EventArgs e)
        {
            if (tb_natcode.Text == "")
            {
                tb_natcode.Text = "Code eingeben";
            }
        }

        private void tb_constr_TextChanged(object sender, EventArgs e)
        {
            if (tb_constr.Text == "")
            {
                tb_constr.Text = "Name eingeben";
            }
        }

        private void tb_color_TextChanged(object sender, EventArgs e)
        {
            if (tb_color.Text == "")
            {
                tb_color.Text = "Farbe eingeben";
            }
        }

        private void tb_seats_TextChanged(object sender, EventArgs e)
        {
            if (tb_seats.Text == "")
            {
                tb_seats.Text = "0";
            }
        }

        private void tb_weight1_TextChanged(object sender, EventArgs e)
        {
            if (tb_weight1.Text == "")
            {
                tb_weight1.Text = "0";
            }
        }

        private void tb_weight2_TextChanged(object sender, EventArgs e)
        {
            if (tb_weight2.Text == "")
            {
                tb_weight2.Text = "0";
            }
        }

        private void tb_weight3_TextChanged(object sender, EventArgs e)
        {
            if (tb_weight3.Text == "")
            {
                tb_weight3.Text = "0";
            }
        }

        private void tb_weight4_TextChanged(object sender, EventArgs e)
        {
            if (tb_weight4.Text == "")
            {
                tb_weight4.Text = "0";
            }
        }

        private void rtb_tiredims_TextChanged(object sender, EventArgs e)
        {
            if (rtb_tiredims.Text == "")
            {
                rtb_tiredims.Text = "-";
            }
        }

        private void combobox_type1_Click(object sender, EventArgs e)
        {

        }

        private void tb_manu_Click(object sender, EventArgs e)
        {
            tb_manu.SelectAll();
        }

        private void tb_type2_Click(object sender, EventArgs e)
        {
            tb_type2.SelectAll();
        }

        private void tb_natcode_Click(object sender, EventArgs e)
        {
            tb_natcode.SelectAll();
        }

        private void tb_constr_Click(object sender, EventArgs e)
        {
            tb_constr.SelectAll();
        }

        private void tb_color_Click(object sender, EventArgs e)
        {
            tb_color.SelectAll();
        }

        private void tb_seats_Click(object sender, EventArgs e)
        {
            tb_seats.SelectAll();
        }

        private void tb_weight1_Click(object sender, EventArgs e)
        {
            tb_weight1.SelectAll();
        }

        private void tb_weight2_Click(object sender, EventArgs e)
        {
            tb_weight2.SelectAll();
        }

        private void tb_weight3_Click(object sender, EventArgs e)
        {
            tb_weight3.SelectAll();
        }

        private void tb_weight4_Click(object sender, EventArgs e)
        {
            tb_weight4.SelectAll();
        }

        private void rtb_tiredims_Click(object sender, EventArgs e)
        {
            rtb_tiredims.SelectAll();
        }
    }
}