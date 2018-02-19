using CityLuxProject.Data;
using CityLuxProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CityLuxProject
{
    public partial class CreateComponent : System.Web.UI.Page
    {
        private CItyLuxDbContext dbContext = new CItyLuxDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindComponentCategoriesDropDown();
            }
        }

        private void BindComponentCategoriesDropDown()
        {
            var data = this.dbContext.ComponentType.Select(x => new
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            this.ComponentTypeDropDown.DataSource = data;
            this.ComponentTypeDropDown.DataBind();
        }

        protected void CreateComponentBtn_Click(object sender, EventArgs e)
        {
            var name = this.ComponentNameTextBox.Text.ToString();
            var type = this.ComponentTypeDropDown.SelectedValue.ToString();
            var price = double.Parse(this.PriceTextBox.Text.ToString());

            var component = new Component()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                ComponentTypeId = type,
                Price = price
            };

            this.dbContext.Component.Add(component);
            this.dbContext.SaveChanges();
        }
    }
}