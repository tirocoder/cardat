using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Vehicle;

namespace CarDat_v0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 


        string text_from_file = "";
        int path_counter = 0;
        string[] path_of_cars = new string[1000];
        PictureBox[] pb_for_ppics = new PictureBox[100];    //
        
        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                panel_preview.Controls.Clear(); // clear all panel controls (=PictureBoxes)
                for (int i = 0; i < pb_for_ppics.Length; i++)   // set every value of array "pb_for_ppics" to "null"
                {
                    pb_for_ppics[i] = null;
                }
            }
            catch
            {}

            int nr_of_ppics = 0;                                //
            int x_pos = 0;                                      //for viewing preview pics of saved cars
            int y_pos = VaC.VaC.TOP;                            //
            int i_preview = 0;                                  //
            

            StreamReader textfile = new StreamReader(VaC.VaC.PROG_DATA, Encoding.Default);  //
            text_from_file = textfile.ReadToEnd();                                              //opens and reads the textfile that contains the .car-file names
            textfile.Close();                                                                   //

            path_of_cars = text_from_file.Split('\n');              //writes the path of saved .car-files into "path_of_cars"
            path_counter = path_of_cars.Length;                     //gets the amount of saved .car-files

            Vehicle.Car loaded_car = new Car();                     //creates a new car-object
  
            string car_name;                                        //the "real" car name
            string[] car_name2 = new string[1];                     //gets the splitted value from "path_of_cars"

            for (int i = 0; i < path_counter; i++)
            {
                car_name2 = path_of_cars[i].Split('\r');            //"path_of_cars" is splitted...
                car_name = car_name2[0];                            //...and "car_name" gets the "real" car name
                if ((car_name != "")&&(car_name.Length>15))                                 //if "car_name" isn't empty...
                {
                    loaded_car = loaded_car.LoadCar(car_name);      //...a car gets loaded
                    if((loaded_car._previewpic!=null) && (loaded_car._previewpic!=""))    //if the loaded car has a preview pic...
                    {                                               //...the preview pic is shown
                        //start "showing pictures on preview page"

                        if ((i_preview % VaC.VaC.PICS_IN_ROW == 0) && (i_preview != 0))
                        {
                            y_pos += VaC.VaC.PPIC_HEIGHT + VaC.VaC.VERI_DIST;
                            i_preview = 0;
                        }
                        x_pos = VaC.VaC.LEFT + i_preview * (VaC.VaC.PPIC_WIDTH + VaC.VaC.HORI_DIST);

                        pb_for_ppics[nr_of_ppics] = new PictureBox();

                        pb_for_ppics[nr_of_ppics].Location = new System.Drawing.Point(x_pos,y_pos);
                        pb_for_ppics[nr_of_ppics].Name = "pb_for_ppics" + nr_of_ppics;
                        pb_for_ppics[nr_of_ppics].Size = new System.Drawing.Size(VaC.VaC.PPIC_WIDTH, VaC.VaC.PPIC_HEIGHT);
                        pb_for_ppics[nr_of_ppics].TabIndex = 20 + nr_of_ppics;
                        pb_for_ppics[nr_of_ppics].BackgroundImageLayout = ImageLayout.Zoom;
                        pb_for_ppics[nr_of_ppics].BackgroundImage = loaded_car.GetPreviewPicture2();

                        //Controls.Add(pb_for_ppics[nr_of_ppics]);
                        panel_preview.Controls.Add(pb_for_ppics[nr_of_ppics]);
                        nr_of_ppics++;
                        i_preview++;
                        //end "showing pictures on preview page"
                    }
                }
                else continue;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Form1_Load(sender, e);
        }

        private void menu_item_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsb_addcar_Click_1(object sender, EventArgs e)
        {
            CarDat_v0.Form2 frm_addcar = new Form2();
            frm_addcar.ShowDialog();
        }

        private void tsb_listcars_Click(object sender, EventArgs e)
        {
            CarDat_v0.Form3 frm_showcars = new Form3();
            frm_showcars.ShowDialog();
        }

        private void tsb_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CarDat v0   © Thomas Tisch 2010 - 2011", "Über...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}