using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Vehicle
    {
       // Công ty chủ quản
       public string company { get; set; }

        public static List<Truck> Trucks
        {
            get
            {
                return new List<Truck>
                {
                    new Truck { id = "001", name = "HINO", price = 250000, manufacturer = "ThaCo", YearOfManufacture = 2020, company = "Nakarot" },
                    new Truck { id = "002", name = "HYND", price = 250000, manufacturer = "ThaCo", YearOfManufacture = 2024, company = "Nakarot" },
                    new Truck { id = "003", name = "FUSO", price = 250000, manufacturer = "ThaCo", YearOfManufacture = 2013, company = "FPT" },
                    new Truck { id = "004", name = "TATA", price = 250000, manufacturer = "ThaCo", YearOfManufacture = 2020, company = "GREEN EVENT" },
                    new Truck { id = "006", name = "TERA", price = 250000, manufacturer = "ThaCo", YearOfManufacture = 2018, company = "BLUE EVENT" }
                };
            }
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", base.id, base.name, base.price, base.manufacturer, base.YearOfManufacture, this.company);
        }
    }
}
