using CityLuxProject.Data;
using CityLuxProject.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CityLuxProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CItyLuxDbContext, Configuration>());

             var database = new CItyLuxDbContext();
             database.Database.CreateIfNotExists();
        }
    }
}