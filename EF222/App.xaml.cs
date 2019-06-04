using EF222.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EF222
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private App()
        {
            using(UniDbContext db=new UniDbContext())
            {
                Group group = new Group() {
                     Name="Best Group"
                };
                Student student = new Student()
                {
                     Name="Elvin",
                      Surname="Camalzade",
                       GroupId=1
                };
                db.Groups.Add(group);
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
