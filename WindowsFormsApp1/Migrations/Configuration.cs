
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace WindowsFormsApp1.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp1.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}