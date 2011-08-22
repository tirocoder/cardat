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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //global variables

        string text_from_file = "";
        int path_counter = 0;
        string[] path_of_cars = new string[1000];

        int index_of_listbox = -1;

        Vehicle.Car loaded_car = new Car();
        //Vehicle.Car._CarData loaded_cardata = new Car._CarData();

        Vehicle.Car loaded_car2 = new Car();
        //Vehicle.Car._CarData loaded_cardata2 = new Car._CarData();



        public void Delete(object sender, EventArgs e)
        {
            if (listbox_cars.SelectedIndex != -1)
            {
                if (MessageBox.Show("Fahrzeug wirklich löschen?", "Löschvorgang...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // release picture in preview box
                    pb_previewpic.BackgroundImage.Dispose();
                    //GC.Collect(); // force garbage collection
                    loaded_car.DeleteCar();

                    index_of_listbox = -1;
                    //MessageBox.Show("Fahrzeug gelöscht!");
                    Form3_Load(sender, e);

                    pb_previewpic.BackgroundImage = null;
                    loaded_car = null;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listbox_cars.Items.Clear();

            StreamReader textfile = new StreamReader(VaC.VaC.PROG_DATA, Encoding.Default);
            text_from_file = textfile.ReadToEnd();

            textfile.Close();

            //string[] path_of_cars = new string[1000];
            path_of_cars = text_from_file.Split('\n');
            

            path_counter = path_of_cars.Length;

            string[] car_name2 = new string[1];

            string car_name;

            for (int i = 0; i < path_counter; i++)
            {
                car_name2 = path_of_cars[i].Split('\r');
                car_name=car_name2[0];
                if (car_name != "")
                {
                    loaded_car2 = loaded_car2.LoadCar(car_name);
                    listbox_cars.Items.Add(loaded_car2._name);
                }
                else continue;
            }
        }

        int found = -1;
        private void listbox_cars_Click(object sender, EventArgs e)
        {
            try
            {
                string car_to_show = listbox_cars.SelectedItem.ToString();
                string[] car_path = new string[1];

                index_of_listbox = listbox_cars.SelectedIndex;

                for (int i = 0; i < path_counter; i++)
                {
                    car_path = path_of_cars[i].Split('\r');
                    if (car_path[0] != "")
                    {
                        loaded_car = loaded_car.LoadCar(car_path[0]);
                        if (loaded_car._name == car_to_show)
                        {
                            found = i;
                            break;
                        }
                    }
                }
                pb_previewpic.BackgroundImage = loaded_car.GetPreviewPicture();
            }
            catch(Exception ex)
            {}
        }

        
        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            
        }

        int found2 = -1;
        private void listbox_cars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string car_to_show = listbox_cars.SelectedItem.ToString();
                string[] car_path = new string[1];

                //Vehicle.Car loaded_car = new Car();

                for (int i = 0; i < path_counter; i++)
                {
                    car_path = path_of_cars[i].Split('\r');
                    if (car_path[0] != "")
                    {
                        loaded_car = loaded_car.LoadCar(car_path[0]);
                        if (loaded_car._name == car_to_show)
                        {
                            found2 = i;
                            break;
                        }
                    }
                }

                loaded_car = loaded_car.LoadCar(car_path[0]);
                //MessageBox.Show(loaded_name.ToString()+"\n"+loaded_power.ToString());

                CarDat_v0.Form4 frm_showcar = new Form4();
                frm_showcar.car = loaded_car;
                frm_showcar.filename = loaded_car._filename;
                frm_showcar.fullpath = loaded_car._fullpath;
                frm_showcar.ShowDialog();
            }
            catch { }
        }

        bool in_and_out = false;
        private void listbox_cars_MouseMove(object sender, MouseEventArgs e)
        {
            if (in_and_out == false)
            {
                //index_of_listbox = listbox_cars.SelectedIndex;

                Form3_Load(sender, e);
                try { pb_previewpic.Refresh(); }
                catch { pb_previewpic.BackgroundImage = null; }
                //pb_previewpic.BackgroundImage = loaded_previewpic;
                listbox_cars.SelectedIndex = index_of_listbox;

                in_and_out = true;
            }
        }

        private void listbox_cars_MouseLeave(object sender, EventArgs e)
        {
            if (in_and_out == true)
            {
                //index_of_listbox = listbox_cars.SelectedIndex;
                
                Form3_Load(sender, e);
                try { pb_previewpic.Refresh(); }
                catch { pb_previewpic.BackgroundImage = null; }
                //pb_previewpic.BackgroundImage = loaded_previewpic;
                listbox_cars.SelectedIndex = index_of_listbox;

                in_and_out = false;
            }
        }

        private void btn_formclose_Click(object sender, EventArgs e)
        {
            this.Close();
            //((Form1)Application.OpenForms[0]).Form1_Load(sender, e);    // refresh Form1
        }

        private void btn_delcar_Click(object sender, EventArgs e)
        {
            
        }

        private void listbox_cars_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Delete(sender, e);
            }
        }

        private void listbox_cars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_delcar_Click_1(object sender, EventArgs e)
        {
            Delete(sender, e);
        }

        private void listbox_cars_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form1)Application.OpenForms[0]).Form1_Load(sender, e);    // refresh Form1
        }
    }
}