using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace projectAUTO
{
    enum CarType
    {
        Sedan = 0,
        HatchBack = 1,
        Universal = 2,
        PickUp = 3,
        Crossover = 4,
        SUV = 5

    }
    enum Transmission
    {
        Auto = 1,
        Robot = 2,
        ManualTransmission = 3
    }
    enum CountryProducing
    {
        USA = 1,
        Korea = 2,
        Japan = 3,
        Russia = 4,
        England = 5,
        France = 6,
        Germany = 7,
        Spain = 8,
        CzechRepublic = 9
    }

    enum EnginesType
    {
        EngineGas = 1,
        EngineDiesel = 2,
        ElectricMotor = 3,
        EngineHybrid = 4
    }

    
    class Car
    {
        public int id { get; set; }
        public CarModel model { get; set; }
        public string color { get; set; }
        public int vin { get; set; }

        public bool carnew { get; set; }

        public int odo { get; set; }

        public int price  { get; set; }

        public double engineCapacity { get; set; }

        public int horsepower { get; set; }

      
    }

    class CarModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public CarType cartype { get; set; }

        public int yearofissue { get; set; }

        public Transmission transmission { get; set; }

        public EnginesType enginesType { get; set; }

        public CarBrand brand { get; set; }

        public override string ToString()
        {
            return name + " " + brand.name; 
        }
        


    }
    class CarBrand
    {
        public int id { get; set; }
        public string name { get; set; }

        public CountryProducing countryProducing { get; set; }


    }

    class ListDB
    {

        public List<Car> cars = new List<Car>();
        public List<CarModel> carModels = new List<CarModel>();
        public List<CarBrand> carBrands = new List<CarBrand>();

        public void SaveCar()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("db");
            var en = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            doc.AppendChild(en);
            doc.AppendChild(root);
            XmlElement carlist = doc.CreateElement("cars");
            XmlElement modellist = doc.CreateElement("models");
            XmlElement brandlist = doc.CreateElement("brands");
            root.AppendChild(brandlist);
            root.AppendChild(modellist);
            root.AppendChild(carlist);
            foreach (var item in cars)
            {
                XmlElement ev = doc.CreateElement("car");
                ev.SetAttribute("id", item.id.ToString());
                ev.SetAttribute("carnew", item.carnew.ToString());
                ev.SetAttribute("color", (item.color).ToString());
                ev.SetAttribute("engineCapacity", ((int)item.engineCapacity).ToString());
                ev.SetAttribute("horsepower", item.horsepower.ToString());
                ev.SetAttribute("price", item.price.ToString());
                ev.SetAttribute("vin", item.vin.ToString());
                ev.SetAttribute("odo", item.odo.ToString());
                ev.SetAttribute("id_model", item.model.id.ToString());

                carlist.AppendChild(ev);
            }
            foreach (var item in carModels)
            {
                XmlElement md = doc.CreateElement("model");
                md.SetAttribute("id", ((int)item.id).ToString());
                md.SetAttribute("name", item.name.ToString());
                md.SetAttribute("yearofissue", item.yearofissue.ToString());
                md.SetAttribute("cartype", ((int)item.cartype).ToString());
                md.SetAttribute("transmission", ((int)item.transmission).ToString());
                md.SetAttribute("enginesType", ((int)item.enginesType).ToString());
                md.SetAttribute("id_brand", item.brand.id.ToString());

                modellist.AppendChild(md);

            }
            foreach (var item in carBrands)
            {
                XmlElement br = doc.CreateElement("brand");
                br.SetAttribute("id", ((int)item.id).ToString());
                br.SetAttribute("name", item.name.ToString());
                br.SetAttribute("countryProducing", ((int)item.countryProducing).ToString());
                brandlist.AppendChild(br);
            }


            doc.Save("db.xml");

        }

        public void LoadCar()
        {

            XmlDocument doc = new XmlDocument();
            //XmlElement carlist = doc.CreateElement("cars");
            //XmlElement modellist = doc.CreateElement("models");
            //XmlElement brandlist = doc.CreateElement("brands");
            doc.Load("db.xml");
            XmlNodeList brandlist = doc.SelectNodes("db/brands/brand");
            XmlNodeList modellist = doc.SelectNodes("db/models/model");
            XmlNodeList carlist = doc.SelectNodes("db/cars/car");


            foreach (XmlNode br in brandlist)
            {

                int id = Convert.ToInt32(br.Attributes.GetNamedItem("id").Value);
                string name = br.Attributes.GetNamedItem("name").Value;
                int countryProducing = Convert.ToInt32(br.Attributes.GetNamedItem("countryProducing").Value);
                
                CarBrand brand = new CarBrand();
                brand.id = id;
                brand.name = name;
                brand.countryProducing = (CountryProducing)countryProducing;
                carBrands.Add(brand);


            }

            foreach (XmlNode md in modellist)
            {
                int id = Convert.ToInt32(md.Attributes.GetNamedItem("id").Value);
                string name = Convert.ToString(md.Attributes.GetNamedItem("name"));
                int yearofissue = Convert.ToInt32(md.Attributes.GetNamedItem("yearofissue").Value);
                int cartype = Convert.ToInt32(md.Attributes.GetNamedItem("cartype").Value);
                int transmission = Convert.ToInt32(md.Attributes.GetNamedItem("transmission").Value);
                int enginesType = Convert.ToInt32(md.Attributes.GetNamedItem("enginesType").Value);
                int id_brand = Convert.ToInt32(md.Attributes.GetNamedItem("id_brand").Value);

                CarModel model = new CarModel();
                model.name = name;
                model.id = id;
                model.yearofissue = yearofissue;
                model.transmission = (Transmission)transmission;
                model.cartype = (CarType)cartype;
                model.enginesType = (EnginesType)enginesType;
                model.brand = carBrands.Where(t => t.id == id_brand).FirstOrDefault();
                carModels.Add(model);
               

            }

            foreach (XmlNode ev in carlist)
            {
                
                int id = Convert.ToInt32(ev.Attributes.GetNamedItem("id").Value);
                bool carnew = Convert.ToBoolean(ev.Attributes.GetNamedItem("carnew").Value);
                string color = ev.Attributes.GetNamedItem("color").Value;
                int engineCapacity = Convert.ToInt32(ev.Attributes.GetNamedItem("engineCapacity").Value);
                int horsepower = Convert.ToInt32(ev.Attributes.GetNamedItem("horsepower").Value);
                int price = Convert.ToInt32(ev.Attributes.GetNamedItem("price").Value);
                int vin = Convert.ToInt32(ev.Attributes.GetNamedItem("vin").Value);
                int odo = Convert.ToInt32(ev.Attributes.GetNamedItem("odo").Value);
                int id_model = Convert.ToInt32(ev.Attributes.GetNamedItem("id_model").Value);

                Car car = new Car();
                car.id = id;
                car.carnew = carnew;
                car.color = color;
                car.engineCapacity = engineCapacity;
                car.horsepower = horsepower;
                car.price = price;
                car.vin = vin;
                car.odo = odo;
                car.model = carModels.Where(t => t.id == id_model).FirstOrDefault();
                cars.Add(car);

            }
          
        }

      
    }


}

   

