using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorksOfConsolePart2.DAL;
using WorksOfConsolePart2.Entities;

namespace WorksOfConsolePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person 
            //Job
            //Data Acces Layer --> DAL --> Connection
            //Context --> Veri tabanı bağlantı adresi ve veri tabanı bağlantı yapılandırması

            //Code First

            Context c = new Context();
            

            void listele()
            {
                var values = c.Customers.ToList();
                foreach (var value in values)
                {
                    Console.WriteLine(value.Name);
                }
            }

            //Customer customer = new Customer();
            //customer.Name = "Eylül Yücedağ";
            //customer.City = "Lviv";
            //c.Customers.Add(customer);
            //c.SaveChanges();

            //var values2 = c.Customers.Where(x => x.Id == 4).FirstOrDefault();
            //c.Customers.Remove(values2);
            //c.SaveChanges();


            var values3 = c.Customers.Where(x => x.Id == 3).FirstOrDefault();
            values3.City = "Adana";
            c.SaveChanges();
            listele();


            Console.ReadLine();
        }
    }
}
