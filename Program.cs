using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            //var country = new Country
            //{
            //    Name = "Китай"
            //};

            //var city = new City
            //{
            //    Name = "Пекин"
            //};

            //var street = new Street
            //{
            //    Name = "Ванфуцзинь"
            //};

            //using (var context = new AppContext())
            //{
            //    context.Countries.Add(country);
            //    context.Cities.Add(city);
            //    context.Streets.Add(street);
            //   // context.SaveChanges();
            //}

            using (var context = new AppContext())
            {
                Street street = context.Streets
                    .Include(s=>s)
            }

        }
    }
}
