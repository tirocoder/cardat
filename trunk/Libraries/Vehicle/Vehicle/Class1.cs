using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Windows.Forms;
using System.Security;
using VaC;

namespace Vehicle
{
    [Serializable]
    public class Car
    {
        //#### START intern variables ####
        
        //START CarData
        public string _name;        //
        public string _id;          // "special" fields
        public string _filename;    //
        public string _fullpath;
        //public Image _previewpic;   //wird ersetzt durch: siehe darunter
        public string _previewpic;

        public int _seats, _weight1, _weight2, _weight3, _weight4;
        public int _year, _year_firstcarreg, _power;
        public string _type1, _type2, _type3, _manu;
        public string _natcode, _constr, _color, _tiredims;
        public string _month_firstcarreg;
        //END CarData
        
        //START ServiceData
        [Serializable]
        public struct _Repair
        {
            public DateTime date;
            public string what;
            public string location;
            public double cost;
            public bool success;
        }

        public DateTime _first_carreg = new DateTime();     //date of first car registration
        public DateTime[] _vis = new DateTime[100];         //list of all dates when vehicle inspection succeeded
        public DateTime _last_vis = new DateTime();         //date of last vehicle inspection
        //public _Repair[] _repairs = new _Repair[100];
        IList<_Repair> _repairs = new List<_Repair>();
        int _repair_counter = 0;
        //END ServiceData

        //#### END intern variables ####

        
        
        //#### START methods ####

        //START public AddCar(int year, int power, int weight)
        public void AddCar(int seats, int weight1, int weight2, int weight3, 
                           int weight4, int power, string type1, string type2, string type3, 
                           string manu, string natcode, string constr, 
                           string color, string tiredims,
                           int year, string month_firstcarreg, int year_firstcarreg)    /* method for adding car with data from formular */
        {
            _color = color;       /* intern variables are set according to data from formular for adding car */
            _constr = constr;
            _manu = manu;
            _natcode = natcode;
            _seats = seats;
            _tiredims = tiredims;
            _type1 = type1;
            _type2 = type2;
            _type3 = type3;
            _weight1 = weight1;
            _weight2 = weight2;
            _weight3 = weight3;
            _weight4 = weight4;
            _power = power;
            _year = year;
            _month_firstcarreg = month_firstcarreg;
            _year_firstcarreg = year_firstcarreg;
            _name = _manu + " " + _type2;

            _id = CreateCarId();
            _filename = _id + VaC.VaC.CAR_EXT;
        }//END public AddCar(int year, int power, int weight, string name)

        //START public string CreateId()
        public string CreateCarId()
        {
            //return System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Millisecond.ToString();    //id number for (exact) vehicle identification <-- to be improved later!!!
            string dt = DateTime.Now.ToString();
            for (int i = 0; i < dt.Length; i++)
            {
                if ((dt[i] == ' ') || (dt[i] == '.') || (dt[i] == ':'))
                {
                    dt = dt.Remove(i, 1);
                }
            }

            //// generate md5-hash and convert to string
            //System.Security.Cryptography.MD5 crypter = System.Security.Cryptography.MD5.Create();
            //byte[] b_id = Encoding.Default.GetBytes(dt);
            //byte[] result = crypter.ComputeHash(b_id);
            //dt = System.BitConverter.ToString(result);

            return dt;  //id number for (exact) vehicle identification <-- to be improved later!!!
        }//END public string CreateId()

        //START public void AddPreviewPicture(Image pic)
        public void AddPreviewPicture(string path)   //method for adding preview picture to car
        {
            _previewpic = path;
        }//END public void AddPreviewPicture(Image pic)

        //START public Image GetPreviewPicture()
        public Image GetPreviewPicture()            //returns the preview pic of a car
        {
            if ((_previewpic == null) || (_previewpic == ""))
            {
                FileStream fs = new FileStream(VaC.VaC.NOPIC, FileMode.Open, FileAccess.Read);
                return Image.FromStream(fs);
            }
            else
            {
                try 
                {
                    FileStream fs = new FileStream(_previewpic, FileMode.Open, FileAccess.Read);
                    Image img = Image.FromStream(fs);
                    fs.Dispose();
                    //fs.Flush();
                    //fs.Close();
                    return img;
                }
                catch (Exception ex)
                {
                    FileStream fs = new FileStream(VaC.VaC.NOPIC, FileMode.Open, FileAccess.Read);
                    return Image.FromStream(fs);
                }
            }
        }//END public Image GetPreviewPicture()

        //START public Image GetPreviewPicture2()
        public Image GetPreviewPicture2()           //returns the preview pic of a car
        {
            if ((_previewpic == null) || (_previewpic == ""))
            {
                Image a = null;
                return a;
            }
            else
            {
                try
                {
                    FileStream fs = new FileStream(_previewpic, FileMode.Open, FileAccess.Read);
                    Image img = Image.FromStream(fs);
                    fs.Dispose();
                    //fs.Flush();
                    //fs.Close();
                    return img;
                }
                catch (Exception ex)
                {
                    FileStream fs = new FileStream(VaC.VaC.NOPIC, FileMode.Open, FileAccess.Read);
                    return Image.FromStream(fs);
                }
            }
        }//END public Image GetPreviewPicture2()

        //START public void CreateCarDir(Car car)
        public void CreateCarDir(Car car)
        {
            //string a = VaC.VaC.CAR_DIR;
            string path = VaC.VaC.CAR_DIR + "\\" + car._id + "\\";
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path + "pics\\");
            car._fullpath = path;
        }//END public void CreateCarDir(Car car)

        //START public void SaveCar(Car car, string filename)
        public void SaveCar(Car car)       //method for saving car with data according to formular
        {
            CreateCarDir(car);      //creates directory in which car files are saved

            //start: copying external data(e.g. preview pic) to .car-directory

            if (car._previewpic != null)
            {
                string[] ppic_fname = car._previewpic.Split('\\');
                File.Copy(car._previewpic, VaC.VaC.CAR_DIR + "\\" + car._id + "\\pics\\" + ppic_fname[ppic_fname.Length - 1]);
                car._previewpic = VaC.VaC.CAR_DIR + "\\" + car._id + "\\pics\\" + ppic_fname[ppic_fname.Length - 1];
            }

            //end: copying external data(e.g. preview pic) to .car-directory

            FileStream serialize_stream = new FileStream(_fullpath + _filename, FileMode.Create);    //filestream where file(=car) will be saved
            BinaryFormatter bf = new BinaryFormatter();     //formatter for serializing object

            bf.Serialize(serialize_stream, car);
            serialize_stream.Flush();
            serialize_stream.Close();


            //following code appends new car's filename to list(-->PROG_DATA)
            StreamReader textfile = new StreamReader(VaC.VaC.PROG_DATA, Encoding.Default);
            string text_from_file = textfile.ReadToEnd();
            textfile.Close();

            text_from_file += "\n" + _fullpath + _filename;

            StreamWriter textfile2 = new StreamWriter(VaC.VaC.PROG_DATA);
            textfile2.Write(text_from_file);
            textfile2.Flush();
            textfile2.Close();
            //end of appending

        }//END public void SaveCar(Car car, string filename)

        //START public void ModCar(Car car, string filename)
        public void ModCar(Car car, string filename)       //method for saving car with data according to formular
        {
            UpdateCarName(car);
            _filename = filename;
            FileStream serialize_stream = new FileStream(_fullpath + _filename, FileMode.Create);    //filestream where file(=car) will be saved
            BinaryFormatter bf = new BinaryFormatter();     //formatter for serializing object

            bf.Serialize(serialize_stream, car);
            serialize_stream.Flush();
            serialize_stream.Close();
        }//END public void ModCar(Car car, string filename)

        //START public void UpdateCarName(Car car)
        public void UpdateCarName(Car car)
        {
            car._name = _manu + " " + _type2;
        }//END public void UpdateCarName(Car car)

        //START public Vehicle.Car LoadCar(string path)
        public Vehicle.Car LoadCar(string path)               //method for loading and showing saved car
        {
            BinaryFormatter bf = new BinaryFormatter();     //formatter for deserializing object

            FileStream retrieveStream = new FileStream(path, FileMode.Open);
            Car loaded_car = (Car)bf.Deserialize(retrieveStream);

            retrieveStream.Flush();
            retrieveStream.Close();

            return loaded_car;
        }//END public Vehicle.Car LoadCar(string path)

        //START public void DeleteCar()
        public void DeleteCar()
        {
            string prog_dat_text = File.ReadAllText(VaC.VaC.PROG_DATA);
            string remove_str = _fullpath + _filename;
            string newtext = prog_dat_text.Replace(remove_str, "");
            StreamWriter sw = new StreamWriter(VaC.VaC.PROG_DATA);
            sw.Write(newtext);
            sw.Flush();
            sw.Close();
            File.Delete(VaC.VaC.CAR_DIR + _filename);
            
            Directory.Delete(VaC.VaC.CAR_DIR + "\\" + _id, true);
        }//END public void DeleteCar()

        /// <summary>
        /// Adds a repair to the car
        /// </summary>
        /// <param name="car"></param>
        /// <param name="repair"></param>
        /// <param name="what"></param>
        /// <param name="location"></param>
        /// <param name="cost"></param>
        /// <param name="success"></param>
        public bool SaveRepair(Car car, DateTime repair, string what, string location, double cost, bool success)
        {
            try
            {
                _Repair new_repair;

                new_repair.date = repair;
                new_repair.what = what;
                new_repair.location = location;
                new_repair.cost = cost;
                new_repair.success = success;

                _repairs.Add(new_repair);

                //_repairs[_repair_counter].date = repair;
                //_repairs[_repair_counter].what = what;
                //_repairs[_repair_counter].location = location;
                //_repairs[_repair_counter].cost = cost;
                //_repairs[_repair_counter].success = success;

                FileStream serialize_stream = new FileStream(_fullpath + _filename, FileMode.Create);    //filestream where file(=car) will be saved
                BinaryFormatter bf = new BinaryFormatter();     //formatter for serializing object

                _repair_counter++;

                bf.Serialize(serialize_stream, car);
                serialize_stream.Flush();
                serialize_stream.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Returns all repairs of a car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public IList<_Repair> LoadRepairs()
        {
            return _repairs;
        }

        /// <summary>
        /// returns a specific repair
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public Car._Repair LoadSpecificRepair(string date)
        {
            int i = 0;
            while (_repairs[i].what != null)
            {
                if (_repairs[i].date.ToString() == date) return _repairs[i];
                i++;
            }
            return _repairs[0];
        }

        //#### END methods ####
    }
}
