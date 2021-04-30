using Microsoft.EntityFrameworkCore;
using RealEstates.Data;
using RealEstates.Services;
using RealEstates.Services.Contracts;
using System;
using System.Text;

namespace RealEstates.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var db = new RealEstateDbContext();
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            IDistrictsService districtsService = new DistrictService(db);
            var districts = districtsService.GetTopDistrictsByAveragePrice();

            foreach (var district in districts)
            {
                Console.WriteLine($"{district.Name} => Price: {district.AveragePrice:0.00} ({district.MinPrice}-{district.MaxPrice}) => {district.PropertiesCount} properties");
            }
        }
    }
}
