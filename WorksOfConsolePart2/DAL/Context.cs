using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WorksOfConsolePart2.Entities;

namespace WorksOfConsolePart2.DAL
{
    internal class Context: DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
/*
DbFirst
--> SQL'deki tablolar birer sınıfa, bu tablolar içinde yer alan sütunlar ise birer property'e dönüşüyor
CodeFirst
--> C#'daki sınıflar SQL'de birer tabloya, sınıflar içindeki proplar ise birer tablo sutununa dönüşecek.
s takısı
pluralize
senin sınıfların ve tabloların biribirine karışmasın diye
yalın halini sınıf
çoğul halini tablo
job --> class
jobs --> table
migration --> göç
 */