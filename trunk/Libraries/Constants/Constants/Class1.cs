using System;
using System.Collections.Generic;
using System.Text;

namespace Vac
{
    public class Vac
    {
        //START constants for saving car
        public const string APP_DIR = "c:\\cardat";
        public const string PROG_DATA = APP_DIR + "\\programdata.txt";
        public const string CAR_DIR = APP_DIR + "\\cars\\";
        public const string CAR_EXT = ".car";
        public const string NOPIC = APP_DIR + "\\none.jpg";
        //END constants for saving car

        //START constants for showing preview data
        public const int LEFT = 20;            //distance from left column to left border of panel_preview
        public const int TOP = 20;            //distance from top row to top border of panel_preview
        public const int PICS_IN_ROW = 4;      //amount of displayed pics in a row
        public const int PPIC_WIDTH = 200;     //width of created PictureBox
        public const int PPIC_HEIGHT = 190;    //height of created PictureBox
        public const int HORI_DIST = 10;       //horizontal distance between two PictureBoxes
        public const int VERI_DIST = 20;       //vertical distance between two PictureBoxes
        //END constants for showing preview data
    }
}
