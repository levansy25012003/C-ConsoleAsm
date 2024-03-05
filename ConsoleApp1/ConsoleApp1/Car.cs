using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car : Vehicle
    {
        private int NumberOfSeats { get; set; }
       

        public static List<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { id = "001", name = "MercedesBenz E200", price = 250000, manufacturer = "Facebook", YearOfManufacture = 2020, NumberOfSeats = 1},
                    new Car { id = "002", name = "MercedesBenz E250", price = 150000, manufacturer = "Facebook", YearOfManufacture = 2022, NumberOfSeats = 2},
                    new Car { id = "003", name = "MercedesBenz E300", price = 170000, manufacturer = "Facebook", YearOfManufacture = 2020, NumberOfSeats = 3 },
                    new Car { id = "004", name = "MercedesBenz E400", price = 190000, manufacturer = "Tiktok", YearOfManufacture = 1945, NumberOfSeats = 5 },
                    new Car { id = "005", name = "MercedesBenz E450", price = 260000, manufacturer = "Tiktok", YearOfManufacture = 2016, NumberOfSeats = 8 },
                    new Car { id = "006", name = "MercedesBenz E500", price = 90000,  manufacturer = "Meta", YearOfManufacture = 1950, NumberOfSeats = 12},
                };
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", base.id, base.name, base.price, base.manufacturer, base.YearOfManufacture, this.NumberOfSeats);
        }

    }
}
