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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Car car;
        public string filename;     //used for saving modded car in: private void btn_modifycar_Click(object sender, EventArgs e)
        public string fullpath;     //used for saving modded car in: private void btn_modifycar_Click(object sender, EventArgs e)
        bool modmode = false;       //used in: private void btn_modifycar_Click(object sender, EventArgs e)
        string ppic_path = "";      //for saving new preview pic when car is modded
            

        public bool Invert(bool tf) //help-function for inverting bool types
        {
            if (tf == true) tf = false;
            else tf = true;
            return tf;
        }

        public void ChangeFormForModding(bool tf)   //function for enabling/disabling textboxes for car data modding
        {
            combobox_type1.Enabled = Invert(tf);
            tb_manu.ReadOnly = tf;
            tb_type2.ReadOnly = tf;
            tb_natcode.ReadOnly = tf;
            tb_constr.ReadOnly = tf;
            tb_color.ReadOnly = tf;
            tb_seats.ReadOnly = tf;
            tb_weight1.ReadOnly = tf;
            tb_weight2.ReadOnly = tf;
            tb_weight3.ReadOnly = tf;
            tb_weight4.ReadOnly = tf;
            rtb_tiredims.ReadOnly = tf;
            tb_year.ReadOnly = tf;
            combobox_month_firstcarreg.Enabled = Invert(tf);
            tb_year_firstcarreg.ReadOnly = tf;
            tb_power.ReadOnly = tf;
        }


        public void Form4_Load(object sender, EventArgs e)
        {
            tb_power.Text = car._power.ToString();
            tb_year.Text = car._year.ToString();
            combobox_month_firstcarreg.Text = car._month_firstcarreg;
            tb_year_firstcarreg.Text = car._year_firstcarreg.ToString();

            combobox_type1.Text = car._type1;
            tb_color.Text = car._color;
            tb_constr.Text = car._constr;
            tb_manu.Text = car._manu;
            tb_natcode.Text = car._natcode;
            tb_seats.Text = car._seats.ToString();
            tb_type2.Text = car._type2;
            tb_weight1.Text = car._weight1.ToString();
            tb_weight2.Text = car._weight2.ToString();
            tb_weight3.Text = car._weight3.ToString();
            tb_weight4.Text = car._weight4.ToString();
            rtb_tiredims.Text = car._tiredims;

            pb_previewpic.BackgroundImage = car.GetPreviewPicture();
            ppic_path = car._previewpic;

            //fill repair list
            IList<Car._Repair> repair_list = car.LoadRepairs();
            for (int i = 0; i < repair_list.Count; i++)
            {
                if((repair_list[i].what != "") && (repair_list[i].what != null))
                {
                    lb_repairs.Items.Add(repair_list[i].date);
                }
            }
            //

            CenterToScreen();
        }

        private void btn_modifycar_Click(object sender, EventArgs e)
        {
            if (modmode == false)
            {
                btn_modifycar.BackColor = Color.Red;
                
                btn_changepic.Visible = true;
                ChangeFormForModding(false);

                modmode = true;
            }
            else
            {
                btn_modifycar.BackColor = Color.FromKnownColor(KnownColor.Control);
                
                btn_changepic.Visible = false;
                ChangeFormForModding(true);

                modmode = false;

                //start modify process
                Vehicle.Car modded_car = new Car();

                modded_car = modded_car.LoadCar(fullpath + filename);
                modded_car._type1 = combobox_type1.Text;
                modded_car._manu = tb_manu.Text;
                modded_car._type2 = tb_type2.Text;
                modded_car._natcode = tb_natcode.Text;
                modded_car._constr = tb_constr.Text;
                modded_car._color = tb_color.Text;
                modded_car._seats=Convert.ToInt32(tb_seats.Text);
                modded_car._weight1 = Convert.ToInt32(tb_weight1.Text);
                modded_car._weight2 = Convert.ToInt32(tb_weight2.Text);
                modded_car._weight3 = Convert.ToInt32(tb_weight3.Text);
                modded_car._weight4 = Convert.ToInt32(tb_weight4.Text);
                modded_car._tiredims = rtb_tiredims.Text;
                modded_car._year=Convert.ToInt32(tb_year.Text);
                modded_car._month_firstcarreg = combobox_month_firstcarreg.Text;
                modded_car._year_firstcarreg=Convert.ToInt32(tb_year_firstcarreg.Text);
                modded_car._power = Convert.ToInt32(tb_power.Text);

                modded_car._previewpic = ppic_path ;

                modded_car.ModCar(modded_car, filename);
                //end modify process
            }
        }

        private void btn_closeform_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Form1)Application.OpenForms[0]).Form1_Load(sender, e);    // refresh main form (Form1)
        }

        private void btn_changepic_Click(object sender, EventArgs e)
        {
            string filename2;

            ofd_newpic.ShowDialog();
            filename2=ofd_newpic.FileName;
            pb_previewpic.BackgroundImage = Image.FromFile(filename2);
            ppic_path = filename2;
        }

        private void btn_add_rep_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            string sel = combobox_action.Text;

            if (sel == "AddRepair")
            {
                CarDat_v0.Form5 frm_addrep = new Form5();
                frm_addrep.car = car;
                frm_addrep.ShowDialog();
            }
        }

        private void lb_repairs_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lb_repairs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string date = lb_repairs.SelectedItem.ToString();
                Car._Repair rep = car.LoadSpecificRepair(date);

                CarDat_v0.Form6 frm_showrep = new Form6();
                frm_showrep.repair = rep;
                frm_showrep.ShowDialog();
            }
            catch (Exception ex)
            { }
        }
    }
}