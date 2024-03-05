using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string choose= "";
            do
            {
                Console.WriteLine("==========================> MENU <================================");
                Console.WriteLine("| a) Hiển thị các xe có giá trong khoảng 100.000 - 250.000       |");
                Console.WriteLine("| b) các xe có năm sản xuất > 1990.                              |");
                Console.WriteLine("| c) gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm. |");
                Console.WriteLine("| d) hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất. |");
                Console.WriteLine("| e) hiển thị tên cty chủ quản của Truck.                        |");
                Console.WriteLine("==================================================================");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "a": showPriceIn(); break;
                    case "b": YearOfManufactureIn(); break;
                    case "c": toltalInGroup(); break;
                    case "d": showTruckYearOfManufacture(); break;
                    case "e": showCompanyOfTruck(); break;
                    default:
                        Console.WriteLine("Thoát");
                        break;
                }

            } while (!string.IsNullOrEmpty(choose));
           
            
        }
        // a) Hiển thị các xe có giá trong khoảng 100.000 - 250.000
        static void showPriceIn()
        {
            var result = Car.Cars.Where(f => f.price >= 100000 && f.price <= 250000);
            // Hiển thị kết quả
            foreach (var car in result)
            {
                Console.WriteLine(car.ToString());
            }
            Console.ReadKey();
        }
        
        // b) các xe có năm sản xuất > 1990.
        static void YearOfManufactureIn()
        {
            var result = Car.Cars.Where(f => f.YearOfManufacture >= 1990);
            // Hiển thị kết quả
            foreach (var car in result)
            {
                Console.WriteLine(car.ToString());
            }
            Console.ReadKey();
        }

        // c) gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm.
        static void toltalInGroup()
        {
            var groupedByManufacturer = Car.Cars
                    .GroupBy(car => car.manufacturer)
                    .Select(group => new
                    {
                        manufacturer = group.Key,
                        totalPrice = group.Sum(car => car.price)
                    });
            // Hiển thị kết quả
            foreach (var group in groupedByManufacturer)
            {
                Console.WriteLine($"Manufacturer: {group.manufacturer}, Total Price: {group.totalPrice}");
            }
            Console.ReadLine();
        }

        // d) hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất.
        static void showTruckYearOfManufacture()
        {
            var result = Truck.Trucks.OrderByDescending(t => t.YearOfManufacture).ToList();
            // Hiển thị kết quả
            foreach (var truck in result)
            {
                Console.WriteLine(truck.ToString());
            }
            Console.ReadLine();
        }

        // e) hiển thị tên cty chủ quản của Truck.
        static void showCompanyOfTruck()
        {
            var result = Truck.Trucks;
            foreach(var truck in result)
            {
                Console.WriteLine("{0} - {1} - {2}.", truck.id , truck.name, truck.company);
            }
            Console.ReadLine();
        }

    }
}
