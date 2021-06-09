using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAUTO
{
    public partial class Form1 : Form
    {
       ListDB DB = new ListDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // создаешь бренды 
            CarBrand carBrandKia = new CarBrand();
            carBrandKia.name = "KIA";
            carBrandKia.id = 1;
            carBrandKia.countryProducing = CountryProducing.Korea;

            DB.carBrands.Add(carBrandKia);
  

            carBrandKia = new CarBrand();
            carBrandKia.name = "Hyndai";
            carBrandKia.id = 0;
            carBrandKia.countryProducing = CountryProducing.Korea;

            DB.carBrands.Add(carBrandKia);



            //var cbkia = DB.carBrands.Where(t => t.name == "KIA").FirstOrDefault();
            //var cars = DB.cars.Where(c => c.model.brand == carBrandKia).ToList();



            // создаешь модели 
            CarModel cmKiaRio = new CarModel();
            cmKiaRio.name = "РИО";
            cmKiaRio.cartype = CarType.HatchBack;
            cmKiaRio.yearofissue = 2019;
            cmKiaRio.id = 1;
            cmKiaRio.transmission = Transmission.Auto;
            cmKiaRio.enginesType = EnginesType.EngineGas;
            cmKiaRio.brand = carBrandKia;

            DB.carModels.Add(cmKiaRio);



            // машины 
            Car car = new Car();
            car.model = cmKiaRio;
            car.id = 1;
            car.odo = 900;
            car.carnew = true;
            car.color = "black";
            car.vin = 876543;
            car.price = 1200000;
            car.engineCapacity = 1.6;
            car.horsepower = 136;

            DB.cars.Add(car);


            CarBrand carBrandBMW = new CarBrand();
            carBrandBMW.name = "BMW";
            carBrandBMW.id = 2;
            carBrandBMW.countryProducing = CountryProducing.Germany;

            DB.carBrands.Add(carBrandBMW);

            CarModel cmBMW = new CarModel();
            cmBMW.id = 2;
            cmBMW.name = "M5";
            cmBMW.transmission = Transmission.Robot;
            cmBMW.yearofissue = 2021;
            cmBMW.cartype = CarType.Sedan;
            cmBMW.enginesType = EnginesType.EngineGas;
            cmBMW.brand = carBrandBMW;

            DB.carModels.Add(cmBMW);



            Car car1 = new Car();
            car1.carnew = true;
            car1.color = "blue";
            car1.id = 2;
            car1.model = cmBMW;
            car1.odo = 634;
            car1.vin = 981234;
            car1.price = 4700000;
            car1.horsepower = 249;
            car1.engineCapacity = 4.0;

            DB.cars.Add(car1);



            CarBrand carBrandToyota = new CarBrand();
            carBrandToyota.name = "Toyota";
            carBrandToyota.id = 3;
            carBrandToyota.countryProducing = CountryProducing.Japan;

            DB.carBrands.Add(carBrandToyota);

            CarModel cmToyota = new CarModel();
            cmToyota.id = 3;
            cmToyota.name = "LandCruser 200";
            cmToyota.transmission = Transmission.ManualTransmission;
            cmToyota.yearofissue = 2020;
            cmToyota.cartype = CarType.SUV;
            cmToyota.enginesType = EnginesType.EngineDiesel;
            cmToyota.brand = carBrandToyota;

            DB.carModels.Add(cmToyota);


            Car car2 = new Car();
            car2.carnew = true;
            car2.id = 3;
            car2.model = cmToyota;
            car2.odo = 460;
            car2.vin = 976333;
            car2.price = 3400000;
            car2.color = "grey";
            car2.engineCapacity = 3.0;
            car2.horsepower = 249;

            DB.cars.Add(car2);


            CarBrand carBrandLADA = new CarBrand();
            carBrandLADA.name = "LADA";
            carBrandLADA.id = 4;
            carBrandLADA.countryProducing = CountryProducing.Russia;

            DB.carBrands.Add(carBrandLADA);

            CarModel cmLada = new CarModel();
            cmLada.id = 4;
            cmLada.name = "Vesta";
            cmLada.transmission = Transmission.ManualTransmission;
            cmLada.yearofissue = 2021;
            cmLada.cartype = CarType.Universal;
            cmLada.enginesType = EnginesType.EngineGas;
            cmLada.brand = carBrandLADA;

            DB.carModels.Add(cmLada);



            Car car3 = new Car();
            car3.carnew = true;
            car3.id = 4;
            car3.model = cmLada;
            car3.odo = 5880;
            car3.vin = 126333;
            car3.price = 687000;
            car3.color = "green";
            car3.engineCapacity = 1.6;
            car3.horsepower = 126;

            DB.cars.Add(car3);

            CarBrand carBrandFORD = new CarBrand();
            carBrandFORD.name = "FORD";
            carBrandFORD.id = 5;
            carBrandFORD.countryProducing = CountryProducing.USA;

            DB.carBrands.Add(carBrandFORD);

            CarModel cmFord = new CarModel();
            cmFord.id = 5;
            cmFord.name = "FOCUS";
            cmFord.transmission = Transmission.ManualTransmission;
            cmFord.yearofissue = 2020;
            cmFord.cartype = CarType.HatchBack;
            cmFord.enginesType = EnginesType.EngineGas;
            cmFord.brand = carBrandFORD;

            DB.carModels.Add(cmFord);


            Car car4 = new Car();
            car4.carnew = true;
            car4.id = 5;
            car4.model = cmFord;
            car4.odo = 1203;
            car4.vin = 456303;
            car4.price = 1300000;
            car4.color = "red";
            car4.engineCapacity = 1.8;
            car4.horsepower = 149;

            DB.cars.Add(car4);


            CarBrand carBrandRENO = new CarBrand();
            carBrandRENO.name = "RENO";
            carBrandRENO.id = 6;
            carBrandRENO.countryProducing = CountryProducing.France;

            DB.carBrands.Add(carBrandRENO);

            CarModel cmReno = new CarModel();
            cmReno.id = 6;
            cmReno.name = "Arcana";
            cmReno.transmission = Transmission.Robot;
            cmReno.yearofissue = 2021;
            cmReno.cartype = CarType.Crossover;
            cmReno.enginesType = EnginesType.EngineGas;
            cmReno.brand = carBrandRENO;

            DB.carModels.Add(cmReno);


            Car car5 = new Car();
            car5.carnew = false;
            car5.id = 6;
            car5.model = cmReno;
            car5.odo = 4908;
            car5.vin = 116993;
            car5.price = 907000;
            car5.color = "red";
            car5.engineCapacity = 1.6;
            car5.horsepower = 136;

            DB.cars.Add(car5);


            CarBrand carBrandVolkswagen = new CarBrand();
            carBrandVolkswagen.name = "Volkswagen";
            carBrandVolkswagen.id = 7;
            carBrandVolkswagen.countryProducing = CountryProducing.Germany;

            DB.carBrands.Add(carBrandVolkswagen);

            CarModel cmVolkswagen = new CarModel();
            cmVolkswagen.id = 7;
            cmVolkswagen.name = "GOLF";
            cmVolkswagen.transmission = Transmission.Auto;
            cmVolkswagen.yearofissue = 2021;
            cmVolkswagen.cartype = CarType.HatchBack;
            cmVolkswagen.enginesType = EnginesType.EngineGas;
            cmVolkswagen.brand = carBrandVolkswagen;

            DB.carModels.Add(cmVolkswagen);


            Car car6 = new Car();
            car6.carnew = true;
            car6.id = 7;
            car6.model = cmVolkswagen;
            car6.odo = 231;
            car6.vin = 206994;
            car6.price = 1450000;
            car6.color = "yellow";
            car6.engineCapacity = 1.6;
            car6.horsepower = 136;

            DB.cars.Add(car6);



            CarBrand carBrandLandRover = new CarBrand();
            carBrandLandRover.name = "LandRover";
            carBrandLandRover.id = 8;
            carBrandLandRover.countryProducing = CountryProducing.England;

            DB.carBrands.Add(carBrandLandRover);

            CarModel cmLandRover = new CarModel();
            cmLandRover.id = 8;
            cmLandRover.name = "DEFENDER";
            cmLandRover.transmission = Transmission.Auto;
            cmLandRover.yearofissue = 2021;
            cmLandRover.cartype = CarType.Crossover;
            cmLandRover.enginesType = EnginesType.EngineDiesel;
            cmLandRover.brand = carBrandLandRover;

            DB.carModels.Add(cmLandRover);



            Car car7 = new Car();
            car7.carnew = true;
            car7.id = 8;
            car7.model = cmLandRover;
            car7.odo = 334;
            car7.vin = 112364;
            car7.price = 2300000;
            car7.color = "grey";
            car7.engineCapacity = 2.4;
            car7.horsepower = 236;

            DB.cars.Add(car7);


            CarBrand carBrandAlfaromeo = new CarBrand();
            carBrandAlfaromeo.name = "Alfaromeo";
            carBrandAlfaromeo.id = 9;
            carBrandAlfaromeo.countryProducing = CountryProducing.Spain;

            DB.carBrands.Add(carBrandAlfaromeo);

            CarModel cmAlfaromeo = new CarModel();
            cmAlfaromeo.id = 9;
            cmAlfaromeo.name = "stelvio";
            cmAlfaromeo.transmission = Transmission.Auto;
            cmAlfaromeo.yearofissue = 2021;
            cmAlfaromeo.cartype = CarType.Crossover;
            cmAlfaromeo.enginesType = EnginesType.EngineHybrid;
            cmAlfaromeo.brand = carBrandAlfaromeo;

            DB.carModels.Add(cmAlfaromeo);


            Car car8 = new Car();
            car8.carnew = true;
            car8.id = 9;
            car8.model = cmAlfaromeo;
            car8.odo = 221;
            car8.vin = 149130;
            car8.price = 2500000;
            car8.color = "red";
            car8.engineCapacity = 2.0;
            car8.horsepower = 236;

            DB.cars.Add(car8);


            CarBrand carBrandSkoda = new CarBrand();
            carBrandSkoda.name = "Skoda";
            carBrandSkoda.id = 10;
            carBrandSkoda.countryProducing = CountryProducing.CzechRepublic;

            DB.carBrands.Add(carBrandSkoda);

            CarModel cmScoda = new CarModel();
            cmScoda.id = 10;
            cmScoda.name = "Octavia";
            cmScoda.transmission = Transmission.Robot;
            cmScoda.yearofissue = 2019;
            cmScoda.cartype = CarType.Sedan;
            cmScoda.enginesType = EnginesType.EngineGas;
            cmScoda.brand = carBrandSkoda;

            DB.carModels.Add(cmScoda);


            Car car9 = new Car();
            car9.carnew = false;
            car9.id = 10;
            car9.model = cmScoda;
            car9.odo = 26004;
            car9.vin = 876541;
            car9.price = 820000;
            car9.color = "black";
            car9.engineCapacity = 1.8;
            car9.horsepower = 149;

            DB.cars.Add(car9);


            CarBrand carBrandTESLA = new CarBrand();
            carBrandTESLA.name = "TESLA";
            carBrandTESLA.id = 11;
            carBrandTESLA.countryProducing = CountryProducing.USA;

            DB.carBrands.Add(carBrandTESLA);

            CarModel cmTESLA = new CarModel();
            cmTESLA.id = 11;
            cmTESLA.name = "model 3";
            cmTESLA.transmission = Transmission.Auto;
            cmTESLA.yearofissue = 2021;
            cmTESLA.cartype = CarType.Sedan;
            cmTESLA.enginesType = EnginesType.ElectricMotor;
            cmTESLA.brand = carBrandTESLA;

            DB.carModels.Add(cmTESLA);


            Car car10 = new Car();
            car10.carnew = true;
            car10.id = 11;
            car10.model = cmTESLA;
            car10.odo = 26;
            car10.vin = 543781;
            car10.price = 4830000;
            car10.color = "red";
            car10.engineCapacity = 2;
            car10.horsepower = 262;

            DB.cars.Add(car10);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DB.LoadCar();
            //DB.SaveCar();
            //MessageBox.Show(EnginesType.EngineDiesel.ToString());
            // => id
            //int a = (int)EnginesType.EngineDiesel;
            // 
            //EnginesType b = (EnginesType)1;


        }

        private void listDBBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DB.carModels.Count.ToString());
            //IEnumerable<string> rname = DB.carModels.Where(x => x.name.Length < 6).Select(dataGridView1.Rows);

            //foreach (string name in rname)
            //{
            //    Console.WriteLine("{0}", name);
            //}

            var list = DB.cars.Where(n => n.model.name.Length < 1000).ToList();


            carBindingSource.DataSource = list;

            //DB.cars.Remove(DB.cars.Where(n => n.id == 1).FirstOrDefault());
            //dataGridView1.DataSource = list;


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // BindingSource
            
            DB.cars.Add(DB.cars.Where(n => n.id == 1).FirstOrDefault());

            
            carBindingSource.Add(null);
            //carBindingSource.RemoveCurrent();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            DB.cars.Add(DB.cars.Where(n => n.id == 1).FirstOrDefault());
            carBindingSource.RemoveCurrent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DB.cars.Add(DB.cars.Where(n => n.id == 1).FirstOrDefault());
            carBindingSource.AllowEdit.ToString();
        }

        private void colorLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void priceTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void vinTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void carBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void carnewCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
